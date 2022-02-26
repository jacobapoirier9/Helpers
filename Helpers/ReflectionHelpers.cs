using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public static class ReflectionHelpers
    {
        /// <summary>
        /// Gets a class level attribute of a type
        /// </summary>
        public static T Attr<T>(this Type type) where T : Attribute
        {
            foreach (var data in type.GetCustomAttributes())
            {
                try { return (T)(object)(data); }
                catch { }
            }

            return default;
        }

        public static T Attr<T>(this Type type, T defaultIfNull) where T : Attribute
        {
            var attr = type.Attr<T>();
            return attr ?? defaultIfNull;
        }


        /// <summary>
        /// Gets an attribute from a member
        /// </summary>
        public static T Attr<T>(this MemberInfo info) where T : Attribute
        {
            return info.DeclaringType.Attr<T>(info.Name);
        }

        ///// <summary>
        ///// Gets an attribute from a member
        ///// </summary>
        //public static T Get<T>(this object instance, string member) where T : Attribute =>
        //    instance.GetType().Get<T>(member);

        /// <summary>
        /// Gets an attribute from a member
        /// </summary>
        public static T Attr<T>(this Type type, string member) where T : Attribute
        {
            foreach (var info in type.GetMembers())
            {
                if (info.Name.ToLower() == member.ToLower())
                {
                    foreach (var data in info.GetCustomAttributes())
                    {
                        try { return (T)(object)(data); }
                        catch { }
                    }
                }
            }

            return default;
        }
    }
}

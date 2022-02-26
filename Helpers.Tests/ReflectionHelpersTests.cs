using System;
using Xunit;
using Helpers;
using System.Linq;

namespace Helpers.Tests
{
    public class ReflectionHelpersTests
    {
        [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property)]
        public class TestAttribute : Attribute
        {
            private string _testValue;
            public TestAttribute(string testValue) => _testValue = testValue;

            public string TestValue => _testValue;
        }


        private const string _classLevelMessage = "This is the test level";
        private const string _methodLevelMessage = "This is the method level";
        private const string _propertyLevelMessage = "This is the property level";

        [Test(_classLevelMessage)]
        public class TestClass
        {
            [Test(_propertyLevelMessage)]
            public string Name { get; set; }
            [Test(_methodLevelMessage)]
            public void SayHello() => Console.WriteLine("Hello World!");
        }



        [Fact]
        public void GetClassAttrTest()
        {
            var attr = ReflectionHelpers.Attr<TestAttribute>(typeof(TestClass));

            Assert.NotNull(attr);
            Assert.Equal(_classLevelMessage, attr.TestValue);
        }

        [Fact]
        public void GetMethodAttrTest()
        {
            var member = typeof(TestClass).GetMethod(nameof(TestClass.SayHello));
            var attr = ReflectionHelpers.Attr<TestAttribute>(member);

            Assert.NotNull(attr);
            Assert.Equal(_methodLevelMessage, attr.TestValue);
        }

        [Fact]
        public void GetPropertyAttrTest()
        {
            var property = typeof(TestClass).GetProperty(nameof(TestClass.Name));
            var attr = ReflectionHelpers.Attr<TestAttribute>(property);

            Assert.NotNull(attr);
            Assert.Equal(_propertyLevelMessage, attr.TestValue);
        }
    }
}

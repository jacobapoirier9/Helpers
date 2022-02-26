using System;
using System.Collections.Generic;

namespace Helpers
{
    public static class DayOfWeekHelpers
    {
        public const byte NumberOfDaysInAWeek = 7;


        public static byte CountDaysBetween(this DayOfWeek startDayOfWeek, DayOfWeek endDayOfWeek)
        {
            var numberOfDays = (byte)(endDayOfWeek >= startDayOfWeek ?
               endDayOfWeek - startDayOfWeek :
               NumberOfDaysInAWeek - (startDayOfWeek - endDayOfWeek));

            return numberOfDays;
        }

        public static DayOfWeek AddDays(this DayOfWeek startDayOfWeek, byte numberOfDaysToAdd)
        {
            for (byte i = 0; i < numberOfDaysToAdd; ++i)
            {
                if (++startDayOfWeek > DayOfWeek.Saturday)
                {
                    startDayOfWeek = DayOfWeek.Sunday;
                }
            }

            return startDayOfWeek;
        }

        public static List<DayOfWeek> GetDaySequence(this DayOfWeek startDayOfWeek, byte numberOfDaysToAdd)
        {
            var sequence = new List<DayOfWeek>();
            for (byte i = 0; i < numberOfDaysToAdd; ++i)
            {
                sequence.Add(startDayOfWeek);
                if (++startDayOfWeek > DayOfWeek.Saturday)
                {
                    startDayOfWeek = DayOfWeek.Sunday;
                }
            }

            return sequence;
        }

        public static List<DayOfWeek> GetDaySequence(this DayOfWeek startDayOfWeek, DayOfWeek endDayOfWeek)
        {
            var count = CountDaysBetween(startDayOfWeek, endDayOfWeek);
            return GetDaySequence(startDayOfWeek, count);
        }

        public static DateTime Next(this DayOfWeek dayOfWeek)
        {
            return Next(DateTime.Now, dayOfWeek);
        }

        public static DateTime Next(this DateTime dateTime, DayOfWeek dayOfWeek)
        {
            var numberOfDaysBetween = CountDaysBetween(dateTime.DayOfWeek, dayOfWeek);
            return dateTime.AddDays(numberOfDaysBetween);
        }

        public static string FastToString(this DayOfWeek dayOfWeek)
        {
            return dayOfWeek switch
            {
                DayOfWeek.Sunday => nameof(DayOfWeek.Sunday),
                DayOfWeek.Monday => nameof(DayOfWeek.Monday),
                DayOfWeek.Tuesday => nameof(DayOfWeek.Tuesday),
                DayOfWeek.Wednesday => nameof(DayOfWeek.Wednesday),
                DayOfWeek.Thursday => nameof(DayOfWeek.Thursday),
                DayOfWeek.Friday => nameof(DayOfWeek.Friday),
                DayOfWeek.Saturday => nameof(DayOfWeek.Saturday),

                _ => throw new IndexOutOfRangeException(nameof(dayOfWeek))
            };
        }

        //public static byte FastToByte(this DayOfWeek dayOfWeek)
        //{
        //    return dayOfWeek switch
        //    {
        //        DayOfWeek.Sunday => 0,
        //        DayOfWeek.Monday => 1,
        //        DayOfWeek.Tuesday => 2,
        //        DayOfWeek.Wednesday => 3,
        //        DayOfWeek.Thursday => 4,
        //        DayOfWeek.Friday => 5,
        //        DayOfWeek.Saturday => 6,

        //        _ => throw new IndexOutOfRangeException(nameof(dayOfWeek))
        //    };
        //}
    }
}

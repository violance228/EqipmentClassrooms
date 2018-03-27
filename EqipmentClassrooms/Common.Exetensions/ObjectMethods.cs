using System;

namespace Common.Extensions
{
    public static class ObjectMethods
    {

        public static string ToObjectString(this Object value)
        {
            return value == null ? "(об'єкт відсутній)" : value.ToString();
        }

        public static void WriteToConsole(this Object value)
        {
            Console.WriteLine(ToObjectString(value));
        }

        public static string ToObjectString(this Object value, string prompt)
        {
            return String.Format("{0}\t{1}\n", prompt + ":", ToObjectString(value));
        }

        public static void WriteToConsole(this Object value, string prompt)
        {
            Console.WriteLine(ToObjectString(value, prompt));
        }
    }
}

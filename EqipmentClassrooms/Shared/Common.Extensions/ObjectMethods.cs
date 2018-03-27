using System;

namespace Common.Extensions {
    public static class ObjectMethods {

        public static string ToObjectString(this object value) {
            return value == null ? "(об'єкт відсутній)" : value.ToString();
        }

        public static void WriteToConsole(this object value) {
            Console.WriteLine(ToObjectString(value));
        }

        public static string ToObjectString(this object value, string prompt) {
            return string.Format("{0}\t{1}\n", prompt + ":", ToObjectString(value));
        }

        public static void WriteToConsole(this object value, string prompt) {
            Console.WriteLine(ToObjectString(value, prompt));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Extensions {
    public static class EnumerableObjectMethods {

        public static string ToObjectsString(
            this IEnumerable<object> collection) {
                StringBuilder sb = new StringBuilder();
                var objects = collection.ToArray();
                if (objects.Length == 0) {
                    sb.Append("(дані відсутні)\n");
                } else {
                    foreach (var obj in objects) {
                        sb.Append(obj + "\n");
                    }
                }
                return sb.ToString();
        }

        public static void WriteToConsole(
            this IEnumerable<object> collection) {
                Console.WriteLine(ToObjectsString(collection));
        }

        public static string ToObjectsString(
            this IEnumerable<object> collection, string prompt) {
                StringBuilder sb = new StringBuilder();
                sb.Append(prompt + "\n");
                var objects = collection.ToArray();
                if (objects.Length == 0) {
                    sb.Append("\t(дані відсутні)\n");
                } else {
                    foreach (var obj in objects) {
                        sb.Append("\t" + obj + "\n");
                    }
                }
                return sb.ToString();
        }

        public static void WriteToConsole(
            this IEnumerable<object> collection, string prompt) {
                Console.WriteLine(ToObjectsString(collection, prompt));
        }

    }
}

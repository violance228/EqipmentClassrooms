using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Entities.Extensions {
    public static class EnumerableEntityMethods {

        public static string ToKeysString(this IEnumerable<IEntity> objects) {
                var sb = new StringBuilder();
                foreach (var obj in objects) {
                    sb.Append(obj.Key);
                    sb.AppendLine();
                }
                return sb.ToString();
        }

        public static void WriteKeysToConsole(this IEnumerable<IEntity> objects) {
                Console.WriteLine(ToKeysString(objects));
        }

        public static string ToKeysString(
            this IEnumerable<IEntity> collection, string prompt) {
                StringBuilder sb = new StringBuilder();
                sb.Append(string.Format("{0}:", prompt));//\n
                int count = 0;
                foreach (var obj in collection) {
                    sb.Append("\n\t" + obj.Key);
                    count++;
                }
                if(count == 0) {
                    sb.Append("\tоб'єкти відсутні");
                }
                sb.AppendLine();
                return sb.ToString();
        }

        public static void WriteKeysToConsole(
            this IEnumerable<IEntity> collection, string prompt) {
                Console.Write(ToKeysString(collection, prompt));
        }

    }
}

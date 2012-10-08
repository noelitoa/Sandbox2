using System;
using System.Collections.Generic;

using System.Text;
using System.IO;

namespace MasteringCSharp4
{
    public static class Extensions
    {

        public static IEnumerable<TResult> Select<TSource, TResult>
            (this IEnumerable<TSource> source,
            Func<TSource, TResult> selector)
        {
            foreach (TSource item in source)
            {
                yield return selector(item);
            }
        }

        public static IEnumerable<TSource> Where<TSource>
            (this IEnumerable<TSource> source,
            Func<TSource, bool> predicate)
        {
            foreach (TSource item in source)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }
        





        public static string Reverse(this string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            

            return new string(chars);
        }

        public static byte[] ReadFully(this Stream input)
        {
            MemoryStream output = new MemoryStream();
            byte[] buffer = new byte[8192];

            int bytesRead;

            while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, bytesRead);
            }

            return output.ToArray();
        }



    }
}

using System.Collections;

namespace GenericMethods
{
    public class Utility()
    {
        /// <summary>
        /// Print values from any type of collection specified
        /// </summary>
        /// <param name="myCollection"></param>
        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (var item in myCollection)
            {
                Console.Write($" | {item} ");
            }
            Console.WriteLine();
        }
    }
}

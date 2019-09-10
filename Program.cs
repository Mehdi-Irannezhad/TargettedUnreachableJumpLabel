using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TargettedUnreachableJumpLabel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You can see that \"Reached\" is not printed.");
            try
            {
                Test();
            }
            catch
            {
            }
            Console.ReadLine();
        }

        public static void Test()
        {
            try
            {
                goto label;
            }
            finally
            {
                throw new Exception();
            }
            label:
                Console.WriteLine("Reached");
        }
    }
}

using System;

namespace Strings_Ex7
{
    class Program
    {
        static void Main(string[] args)
        {

            string infoBlabla = RemoveNewline(@"       a1

                                                        a2


                                                a3

                                              ");
            Console.WriteLine(infoBlabla);
        }

        //Write a method that to remove a newline.

        public static string RemoveNewline(string input)
        {
            string newLine = @"
";
            string changedString = input.Replace(newLine, "");

            return changedString;
        }
    }
}

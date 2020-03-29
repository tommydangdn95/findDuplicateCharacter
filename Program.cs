using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string dupString = "abca";
            Console.WriteLine($"String cu : {dupString}");
            string newString = refactorDupChar(dupString);
            Console.WriteLine($"String moi la : {newString}");
            Console.ReadKey();
        }


        static string refactorDupChar(string checkString)
        {
            char[] charArray = checkString.ToCharArray();
            Array.Sort(charArray);
            bool[] checkBoolean = new bool[256];
            StringBuilder stringBuilder = new StringBuilder();
            for(int i = 0; i <= charArray.Length - 1; i++)
            {
                int index = (int)charArray[i];
                if (!checkBoolean[index])
                {
                    if(i == charArray.Length - 1)
                    {
                        stringBuilder.Append(charArray[i]);
                    }
                    else if (charArray[i] != charArray[i + 1])
                    {
                        stringBuilder.Append(charArray[i]);
                    }

                }

                checkBoolean[index] = true;
            }

            return stringBuilder.ToString();
        }
    }
}

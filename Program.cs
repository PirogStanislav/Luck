using System;
using System.Collections.Generic;

namespace Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter the number of ticket");
                string question = Console.ReadLine();
                if (IsValid(question))
                {
                    IsLucky(question);
                }
                else
                {
                    Console.WriteLine("Invalid data");
                }
            }
        }
        public static bool IsValid(string s)
        {
            if ((s.Length >= 4) && (s.Length <= 8))
                return true;
            return false;
        }
        public static void IsLucky(string param)
        {
            char[] charArray = param.ToCharArray();
            List<int> list = new List<int>();
            try
            {
                for (int i = 0; i < charArray.Length; i++)
                {
                    string s = "" + charArray[i];

                    int x = int.Parse(s);
                    list.Add(x);

                }

                if (list.Count % 2 == 0)
                {
                    Console.WriteLine($"Lucky ticket is:{Solution(list.ToArray())}");
                }
                else
                {
                    list.Reverse();
                    list.Add(0);
                    Console.WriteLine($"Lucky ticket is:{Solution(list.ToArray())}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Use only numbers!");
            }
        }
        private static bool Solution(int[] array)
        {
            int firstHalf = 0;
            int secondHalf = 0;
            for (int i = 0; i < array.Length / 2; i++)
            {
                firstHalf += array[i];
            }
            for (int i = array.Length / 2; i <= array.Length - 1; i++)
            {
                secondHalf += array[i];
            }
            if (firstHalf == secondHalf)
                return true;
            return false;

        }
    }
}

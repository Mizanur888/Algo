using System;
using System.Linq;

namespace AlgoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            countStringCombination();
        }

        public static void countStringCombination()
        {
            string combination = "aabbcdddeeettb";
            int count = 0;
            string temp = "";
            char[] arr = new char[combination.Length];
            arr = combination.ToCharArray();

            char[] holdChar = new char[combination.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                char current = arr[i];
                count = 0;
                if (!holdChar.Contains(current))
                {
                    for (int k = i; k < arr.Length; k++)
                    {
                        if (current == arr[k])
                        {
                            count++;
                            holdChar[i] = arr[i];
                        }
                    }
                }
                if (count != 0)
                    temp += arr[i] + count.ToString();
            }


            Console.WriteLine(temp);
        }
    }
}

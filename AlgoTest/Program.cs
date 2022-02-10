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
            string combination = "Inflation has been driven higher by soaring demand and lack of supply caused by Covid pandemic’s global impact on trade";
            int count = 0;
            string temp = "";
            char[] arr = new char[combination.Length];
            arr = combination.ToCharArray();

            char[] holdChar = new char[combination.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                char current = arr[i];

                Console.WriteLine(current);

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
                        temp +=arr[i]!=' '? arr[i] + count.ToString(): 'S' + count.ToString();
                

            }


            Console.WriteLine(temp);
            
        }
    }
}

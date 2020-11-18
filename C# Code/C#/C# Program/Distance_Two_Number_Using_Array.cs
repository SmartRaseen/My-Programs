using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA
{

    public class ArrayDemo
    {
        public void RunArrayDemo()
        {
            int[] num = { 15, 25, 13, 16, 22, 26, 28, 10, 5, 11 };
            int i;
            Console.WriteLine("Array Of 10 Numbers : ");
            Console.WriteLine();

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Number " + i + " : " + num[i]);
            }
            Console.WriteLine();
            int[] num1 = new int[num.Length - 1];
            int min = int.MaxValue;
            int index = 0;
           // num1[0] = Math.Abs(num[1] - num[0]);

            for (i = 0; i < num.Length-1; i++)
            {
                num1[i] = Math.Abs(num[i] - num[i + 1]);
            }
            for (i = 0; i < num1.Length - 1; i++)
            {
                if (min > num1[i])
                {
                    min = num1[i];
                    index = i;
                }
            }
            for (i = 0; i < 9; i++)
            {
                Console.WriteLine("Difference Of Array Number  "+i+"  is  "+num1[i]);
            }
            Console.WriteLine("\n Array " + num[index] + " is Number : " + index + "\t And");
            Console.WriteLine(" Array " +num[index + 1] +" is Number : " + (index + 1));
            Console.WriteLine("\n The Minimum Difference  ");
            Console.WriteLine(" *** ******* **********  ");
            Console.WriteLine("\n the Difference is :" + num1[index]);
            Console.ReadLine();

        }
    }
}
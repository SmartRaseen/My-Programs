using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance_Array
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i, j, k;
            int[] arr = new int[10];
            int[] arr1 = null;

            Console.WriteLine("\nNumbers 0 to 9 : \n");

            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
                Console.WriteLine("Number " + i + " Array Has : " + arr[i]);
            }

            Console.WriteLine();

            arr1 = new int[arr.Length + 10];
            Console.WriteLine("\nNumbers Are Extended To 0 to 19 : \n");

            for (j = 0; j < arr.Length; j++)
            {
                arr1[j] = arr[j];
            }

            for (j = 0; j < arr.Length; j++)
            {
                Console.WriteLine("Number " + j + " Array Has : " + arr[j]);
            }

            for (k = arr.Length; k < arr1.Length; k++)
            {

                arr1[k] = k;
                Console.WriteLine("Number " + k + " Array Has : " + arr1[k]);
            }

            Console.ReadLine();
        }
    }
}


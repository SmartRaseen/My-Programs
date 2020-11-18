


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrSizeExtend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i,j,k;
            int[] nums = new int[10];
            int[] nums1 = null;// new int[20];
            
            
            Console.WriteLine("\nNumbers 0 to 9 : \n");
            for(i = 0; i <nums.Length; i++)
            {
                nums[i] =i;
                Console.WriteLine("NUMBER " + i + " array value is " + nums[i]);
            }

            Console.WriteLine();
            
            nums1 = new int[nums.Length + 10];
            Console.WriteLine("\nNumbers Are Extended To 0 to 19 : \n");
            for (j = 0; j < nums.Length; j++)
            {
                nums1[j] = nums[j];
            }
            for (j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("NUMBER " + j + " array value is " + nums[j]);
            }
            for (k = nums.Length; k < nums1.Length; k++)
            
            {
                
                nums1[k] = k;
                Console.WriteLine("NUMBER " + k+ " array value is " + nums1[k]);
            }

            Console.ReadLine();
        }
        
    }
}
using System;
					
public class Program
{
	public static void Main()
	{
		//7 69 2 221 8974
		
		int[] arr = { 1, 2, 3, 4, 5 };
		int[] array = arr;
            int max = 0;
            int min = 0;
            int arrValue = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[0] > arr[i])
                    arr[0] = arr[0];

                else
                    arr[0] = arr[i];

                max = arr[0];
            }

           arr[0] = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[0] < arr[i])
                    arr[0] = arr[0];

                else
                    arr[0] = arr[i];

                min = arr[0];
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arrValue = arrValue + arr[i];
            }
		
            Console.WriteLine("Array Elements : " + arrValue);
			Console.WriteLine("Max : "+max);
            int arr1 = arrValue - max;
            Console.WriteLine("Remaining Of Max Element : " + arr1);

            Console.WriteLine("\nArray Elements : " + arrValue);
			Console.WriteLine("Min : "+min);
            int arr2 = arrValue - min;
            Console.WriteLine("Remaining Of Min Element : " + arr2);
	}
}
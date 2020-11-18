using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    public class Program
    {
        public static void Main()
        {
            int[] scores = { 100, 100, 50, 40, 40, 20, 10 };    // Scores
            int[] alice = { 5, 25, 50, 120 };                   // Alice Scores
            int n = scores.Length;                              // Scores Length
            int m = alice.Length;                               // Alice Scores Length
            int[] rank = new int[n];                            // Scores Rank
            int[] alicerank = new int[m];                       // Alice Rank

            Console.Write("Score :".PadRight(16));

            for (int i = 0; i < n; i++)
                Console.Write(" " + scores[i]);

            Console.WriteLine("\n");

            for (int i = 1; i < n; i++)
            {
                rank[0] = 1;
                if (scores[i] == scores[i-1])
                  rank[i] = rank[i - 1];
                
                else if (scores[i] < scores[i - 1])
                   rank[i] = rank[i - 1] + 1;
            }

            Console.Write("Rank :".PadRight(16));

            for (int i = 0; i < n; i++)
                Console.Write(" " + rank[i]);

            for (int i = 0; i < m; i++)
            {
                int aliceScore = alice[i];
                if (aliceScore > scores[i])
                    alicerank[i] = rank[0];
                
                else if (aliceScore < scores[n - 1])
                    alicerank[i] = rank[n - 1] + 1;
                
                else
                    alicerank[i] = BinarySearch(scores, alice,n-1,0,i);
            }

            Console.WriteLine("\n");
            Console.Write("Alice Score :".PadRight(16));

            for (int i = 0; i < m; i++)
                Console.Write(" " + alice[i]);

            Console.WriteLine("\n");

            Console.Write("Alice Rank :".PadRight(16));

            for (int i=0;i<m;i++)
            Console.Write(" " + alicerank[i]);

            Console.ReadLine();
        }

        public static int BinarySearch(int[] scores,int[] alice,int r,int l,int i)
        {
            if (r>=l)
            {
                int mid = l + (r - l) / 2;

                if ((scores[mid] == alice[i]) || (alice[i] > scores[mid]) || (alice[i] < scores[mid]))
                {
                    if(alice[i] > scores[mid])
                        return mid-1;

                    if (alice[i] < scores[mid])
                        return mid+1;
                }

                else if (scores[mid] > alice[i])
                    return BinarySearch(scores, alice, mid - 1, l, i);

                else
                    return BinarySearch(scores, alice, r, mid + 1, i);
            }
                return -1;
        }
    }

}

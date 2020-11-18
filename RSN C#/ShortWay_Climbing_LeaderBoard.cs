using System;
					
public class Program
{
	public static void Main()
	{
			int[] Score = {100, 100, 50, 40, 40, 20, 10};     	//Score
            int[] AliceScore = {5, 25, 50, 120 };              	//AliceScore
            int m = Score.Length;                       		//Score Length
            int n = AliceScore.Length;                  		//AliceScore Length
            int[] AliceRank = new int[n];
            

            Console.Write("Score : ");
            for (int i = 0; i < m; i++)
                Console.Write(" " + Score[i]);

            Console.WriteLine("\n\n");

            Console.Write("Alice Score : ");
            for (int i = 0; i < n; i++)
                Console.Write(" " + AliceScore[i]);

            Console.WriteLine("\n\n");

            int count = 0;
		

            foreach (int game in AliceScore)
            {
				var currentRank = 1;
				var lastScore = 0;
                for (int i = 0; i < m; i++)		
                {
					if(lastScore == Score[i])
						continue;
					
                    if (game < Score[i])
                        currentRank = currentRank + 1;	
                    else
                        break;
					   lastScore =Score[i];
                }
                AliceRank[count] = currentRank;
                count += 1;
            }

            Console.Write("Alice Rank : ");
            for(int i=0;i<n;i++)
            Console.Write(" "+AliceRank[i]);
	}
}



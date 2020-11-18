using System;

public class rsn
{
	public static void Main(string[] args)
	{
		string str="The pot is in the top floor." + " He saw what was a good film." +
                         " hello the word parts is an anagram of strap and traps." + " Moreover 24 is 42. Please stop for pots";
		string[] sar=str.Split();
		int n = sar.Length;
		
		for(int i=0;i<n-1;i++)
		{
			for(int j=i+1;j<n;j++)
			{
				if(sar[i].Length==sar[j].Length)
				{
					if(!sar[i].Equals(sar[j]))
					{
						bool y = isAnagram(sar[i],sar[j]);
						if(y)
							Console.WriteLine("Anagram "+sar[i]+" is "+sar[j]);
					}
				}
			}
		}
		
		bool isAnagram(string word,string anagram)
		{
			char[] chars = word.ToCharArray();
		
			foreach(char c in chars)
			{
				int index = anagram.IndexOf(c);		
			
				anagram = anagram.Substring(0, index) + anagram.Substring(index + 1, anagram.Length - (index + 1));
			}
			return (anagram.Equals(string.Empty));
		}
	}
}
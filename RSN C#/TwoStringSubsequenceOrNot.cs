// Recursive C# program to check if a string  
// is subsequence of another string 
using System; 
  
class GFG { 
      
    // Returns true if str1[] is a  
    // subsequence of str2[] m is  
    // length of str1 and n is length  
    // of str2 
    static bool isSubSequence(string str1, 
                  string str2, int m, int n) 
    { 
          
        // Base Cases 
        if (m == 0)  
            return true; 
        if (n == 0)  
            return false; 
              
        // If last characters of two strings 
        // are matching 
        if (str1[m-1] == str2[n-1]) 
            return isSubSequence(str1, str2, 
                                    m-1, n-1); 
  
        // If last characters are not matching 
        return isSubSequence(str1, str2, m, n-1); 
    } 
      
    // Driver program 
    public static void Main ()  
    { 
        string str1 = "gksrek"; 
        string str2 = "geeksforgeeks"; 
        int m = str1.Length; 
        int n = str2.Length; 
        bool res = isSubSequence(str1, str2, m, n); 
          
        if(res) 
            Console.Write("Yes"); 
        else
            Console.Write("No"); 
    } 
} 
  
// This code is contributed by nitin mittal. 

Output :
Yes
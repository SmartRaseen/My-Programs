using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
using System;
					
    class Bank
    {
		private readonly int id;
        private string Branch;

        public Bank()
        {
            Console.WriteLine("Bank Object Created " + GetHashCode());
        }
        public Bank(int id)
        {
            Console.WriteLine("Bank Object Created " + GetHashCode());
            this.id=id;
        }
        public Bank(int id,string strBranch)
        {
            Console.WriteLine("New Bank Object " + GetHashCode());
            this.id=id;
            Branch=strBranch;			
        }
		//Getters and Setters
        public string GetBranch() { return Branch; }
    
        public void SetBranch(string s1)
        {
            if (s1 == null)
                throw new Exception("INVALID BANK BRANCH !!! Bank Branch must not be null");
            if (s1 == string.Empty)
                throw new Exception("INVALID BANK BRANCH !!! Bank Branch must not be empty");
            if (s1.Length < 3)
                throw new Exception("INVALID BANK BRANCH !!! Bank Branch must be greater than 3 characters");
            if (s1.Length > 15)
                throw new Exception("INVALID BANK BRANCH !!! Bank Branch must be lesser than 15 characters");
            char[] data = s1.ToUpper().ToCharArray();
            foreach (char c1 in data)
            {
                int x = (int)c1;
                if (x < 65 || x > 90)
                    throw new Exception("INVALID BANK NAME !!! Bank name must be only Alphabets");
            }
            Branch = s1;
        }
	}
}
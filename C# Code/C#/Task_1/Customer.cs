using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
class Customer
    {		
		
        private readonly long AccountNo;
        private string Name;
        private long PhoneNo;
		private string EMail;
		private string Address;
                        
		public Customer()
        {
			int n1;
			Console.WriteLine("\tCustomer AccountType");
			Console.WriteLine("\t******** ***********\n");	
			Console.Write(" Enter The Value : ");
			n1=Convert.ToInt32(Console.ReadLine());
				if(n1==0)
				Console.WriteLine("\n Customer AccountType : Savings ");	
				if(n1==1)
			Console.WriteLine("\n Customer AccountType : Current ");
            Console.WriteLine("Customer Object Created " + GetHashCode());
        }
        public Customer(long id)
        {
            Console.WriteLine("Customer Object Created " + GetHashCode());
            this.AccountNo = id;
        }
        public Customer(long id,string strName,long lPhoneNo,string strEMail,string strAddress)
        {
            Console.WriteLine("Customer Object Created " + GetHashCode());
            this.AccountNo = id;
            Name = strName;
            PhoneNo = lPhoneNo;
            EMail = strEMail;
            Address = strAddress;
        }

        //Getters and Setters
		public string GetName() { return Name; }
        public long GetPhoneNo() { return PhoneNo; }
        public string GetEmail() { return EMail; }
        public string GetAddress() { return Address; }
        
        public void SetName(string s1)
        {
            if (s1 == null)
                throw new Exception("INVALID CUSTOMER NAME !!! Customer name must not be null");
            if (s1 == string.Empty)
                throw new Exception("INVALID CUSTOMER NAME !!! Customer name must not be empty");
            if (s1.Length < 3)
                throw new Exception("INVALID CUSTOMER NAME !!! Customer name must be greater than 3 characters");
            if (s1.Length > 15)
                throw new Exception("INVALID CUSTOMER NAME !!! Customer name must be lesser than 15 characters");
            char[] data = s1.ToUpper().ToCharArray();
            foreach(char c1 in data)
            {
                int x =(int)c1;
                if (x < 65 || x > 90)
                    throw new Exception("INVALID CUSTOMER NAME !!! Customer name must be only Alphabets");
            }
            Name = s1;
        }
		public void SetPhoneNo(long l1)
        {
            if (l1 < 9000000000 || l1 > 10000000000)
                throw new Exception("INVALID MOBILE NUMBER");
            if (l1 < 9000000000L || l1 > 10000000000L)
                throw new Exception("INVALID MOBILE NUMBER");
            PhoneNo = l1;
        }
		public void SetEMail(string s2)
        {
            if (s2 == null)
                throw new Exception("INVALID CUSTOMER EMAIL !!! customer Email must not be null");
            if (s2 == string.Empty)
                throw new Exception("INVALID CUSTOMER EMAIL !!! customer Email must not be empty");
            if (s2.Length < 3)
                throw new Exception("INVALID CUSTOMER EMAIL !!! customer Email must be greater than 3 characters");
            if (s2.Length > 40)
                throw new Exception("INVALID CUSTOMER EMAIL !!! customer Email must be lesser than 40 characters");
            if (!(s2.Contains("@")))
                throw new Exception("INVALID CUSTOMER EMAIL !!! customer Email must be  @ symbol");
            EMail =s2;
        }
        public void SetAddress(string s3)
        {
            if (s3 == null)
                throw new Exception("INVALID CUSTOMER ADDRESS !!! Customer address must not be null");
            if (s3 == string.Empty)
                throw new Exception("INVALID CUSTOMER ADDRESS !!! Customer address must not be empty");
            if (s3.Length < 3)
                throw new Exception("INVALID CUSTOMER ADDRESS !!! Customer address must be greater than 3 characters");
            if (s3.Length > 40)
                throw new Exception("INVALID CUSTOMER ADDRESS !!! Customer address must be lesser than 40 characters");
            Address =s3;
        }
	}	
}
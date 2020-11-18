using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Emp
    {
        private readonly int id;
        private string Name;
        private string Address;
        private long MobileNo;
        private string EMail;

        public Emp()
        {
            Console.WriteLine("Emp Object Created " + GetHashCode());
        }
        public Emp(int id)
        {
            Console.WriteLine("Emp Object Created " + GetHashCode());
            this.id=id;
        }
        public Emp(int id,string strName,string strAddress,long lMobileNo,string strEMail)
        {
            Console.WriteLine("New Employee Object " + GetHashCode());
            this.id=id;
            Name=strName;
            Address=strAddress;
            MobileNo=lMobileNo;
            EMail=strEMail;				
        }
        //Getters and Setters
        public string GetName() { return Name; }
        public string GeAddress() { return Address; }
        public long GetMobileNo() { return MobileNo; }
        public string GetEMail() { return EMail; }
    
        public void SetName(string s1)
        {
            if (s1 == null)
                throw new Exception("INVALID EMP NAME !!! Emp name must not be null");
            if (s1 == string.Empty)
                throw new Exception("INVALID EMP NAME !!! Emp name must not be empty");
            if (s1.Length < 3)
                throw new Exception("INVALID EMP NAME !!! Emp name must be greater than 3 characters");
            if (s1.Length > 15)
                throw new Exception("INVALID EMP NAME !!! Emp name must be lesser than 15 characters");
            char[] data = s1.ToUpper().ToCharArray();
            foreach (char c1 in data)
            {
                int x = (int)c1;
                if (x < 65 || x > 90)
                    throw new Exception("INVALID EMP NAME !!! Emp name must be only Alphabets");
            }
            Name = s1;
        }
        public void SetAddress(string s2)
        {
            if (s2 == null)
                throw new Exception("INVALID EMP ADDRESS !!! Emp address must not be null");
            if (s2 == string.Empty)
                throw new Exception("INVALID EMP ADDRESS !!! Emp address must not be empty");
            if (s2.Length < 3)
                throw new Exception("INVALID EMP ADDRESS !!! Emp address must be greater than 3 characters");
            if (s2.Length > 50)
                throw new Exception("INVALID EMP ADDRESS !!! Emp address must be lesser than 50 characters");
            Address = s2;
        } 
        public void SetMobileNo(long l1)
        {
            if (l1 < 9000000000 || l1 > 10000000000)
                throw new Exception("INVALID MOBILE NUMBER !!!");
            if (l1 < 9000000000L || l1 > 10000000000L)
                throw new Exception("INVALID MOBILE NUMBER !!!");
            string value = Convert.ToString(l1.GetType());
            if (value == "long")
                throw new Exception("INVALID MOBILE NUMBER !!!");
            MobileNo = l1;
        }
        public void SetEMail(string s3)
        {
            if (s3 == null)
                throw new Exception("INVALID EMP E-Mail !!! Emp E-Mail must not be null");
            if (s3 == string.Empty)
                throw new Exception("INVALID EMP E-Mail !!! Emp E-Mail must not be empty");
            if (s3.Length < 3)
                throw new Exception("INVALID EMP E-Mail !!! Emp E-Mail must be greater than 3 characters");
            if (s3.Length > 50)
                throw new Exception("INVALID EMP E-Mail !!! Employee E-Mail must be lesser than 50 characters");
            if (!(s3.Contains("@")))
                throw new Exception("INVALID EMP E-Mail !!! Employee E-Mail must contain @ symbol");
            EMail = s3;
        }
    }
}

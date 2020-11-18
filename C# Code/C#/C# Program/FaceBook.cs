using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friend
{
    public class Friend
    {
        // Fields 

        private string Name;
        private string Gender;
        private int Age;
        private string Address;
        private string Email;

        //Getter and Setters

        public string GetName() { return Name; }
        public string GetGender() { return Gender; }
        public int GetAge() { return Age; }
        public string GeAddress() { return Address; }
        public string GetEMail() { return Email; }

        public void SetName()
        {
            Console.Write("\n Enter The Friend Name : ");
            string s1 = Console.ReadLine();

            if (s1 == null)
                throw new Exception("INVALID NAME !!! Name must not be null");
            if (s1 == string.Empty)
                throw new Exception("INVALID NAME !!! Name must not be empty");
            if (s1.Length < 3)
                throw new Exception("INVALID NAME !!! Name must be greater than 3 characters");
            if (s1.Length > 20)
                throw new Exception("INVALID NAME !!! Name must be lesser than 20 characters");
            char[] data = s1.ToUpper().ToCharArray();
            foreach (char c1 in data)
            {
                int x = (int)c1;
                if (x < 65 || x > 90)
                    throw new Exception("INVALID NAME !!! Name must be only alphabets");
            }
            Name = s1;
        }

        public void SetGender()
        {
            Console.Write("\n Enter The Friend Gender : ");
            string s2 = Console.ReadLine();
            if (s2 == null)
                throw new Exception("INVALID GENDER !!! Gender must not be Null");
            if (s2 == String.Empty)
                throw new Exception("INVALID GENDER !!! Gender must not Empty");
            if (s2.Length > 7)
                throw new Exception("INVALID GENDER !!! Gender must be Lesser than 7 characters");
            if (s2.Length < 3)
                throw new Exception("INVALID GENDER !!! Gender must be Greater than 3 characters");
            char[] data = s2.ToUpper().ToCharArray();
            foreach (char c1 in data)
            {
                int x = (int)c1;
                if (x < 65 || x > 90)
                    throw new Exception("INVALID NAME !!! Name must be only alphabets");
            }
            switch (s2)
            {
                case "Male":
                case "male":
                    //Console.WriteLine("MALE");
                    s2 = "Male";
                    break;

                case "Female":
                case "female":
                    //Console.WriteLine("FEMALE");
                    s2 = "Female";
                    break;

                default:
                 // Console.WriteLine("Unspecified Gender");
                    s2="Unspecified Gender";
					break;
            }
            Gender = s2;
        }

        public void SetAge()
        {
            Console.Write("\n Enter Your Age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Age = age;
        }

        public void SetAddress()
        {
            Console.Write("\n Enter The Friend Address : ");
            string s4 = Console.ReadLine();
            if (s4 == null)
                throw new Exception("INVALID ADDRESS !!! Address must not be Null");
            if (s4 == string.Empty)
                throw new Exception("INVALID ADDRESS !!! Address must not be Empty");
            if (s4.Length < 3)
                throw new Exception("INVALID ADDRESS !!! Address must be Greater than 3 characters");
            if (s4.Length > 50)
                throw new Exception("INVALID ADDRESS !!! Address must be Lesser than 50 characters");
            Address = s4;
        }

        public void SetEmail()
        {
            Console.Write("\n Enter The Friend Email : ");
            string s5 = Console.ReadLine();
            if (s5 == null)
                throw new Exception("INVALID E-Mail !!! E-Mail must not be Null");
            if (s5 == string.Empty)
                throw new Exception("INVALID E-Mail !!! E-Mail must not be Empty");
            if (s5.Length < 3)
                throw new Exception("INVALID E-Mail !!! E-Mail must be Greater than 3 characters");
            if (s5.Length > 50)
                throw new Exception("INVALID E-Mail !!! E-Mail must be Lesser than 50 characters");
            if (!(s5.Contains("@")))
                throw new Exception("INVALID E-Mail !!! E-Mail must contain @ symbol");
            Email = s5;
        }

        public void SendRequest()
        {
            Console.WriteLine("\n\n Send Request To Friend");
            Console.WriteLine(" **** ******* ** ******");
            Console.Write("\n Requested Friend Name : ");
            string RequestFrnd = Console.ReadLine();
            Console.WriteLine("\n Sending Request From.... " + RequestFrnd);
        }

        public void Accepted()
        {
            Console.Write("\n Requested To : ");
            string Requested_To = Console.ReadLine();
            Console.WriteLine("\n Request Accepted By : " + Requested_To);
        }

        public void SendMsg()
        {
            Console.Write("Enter The Message To Your Friend : ");
            string Msg = Console.ReadLine();
            Console.Write("\n Requested Friend Name : ");
            string Requested_To = Console.ReadLine();
            Console.WriteLine("\n" + Msg + "\t Message Send By : " + Requested_To);
            Console.WriteLine("\n" + Msg + "\t Sending Message To.... " + Name);
        }

        public void ShowDetails()
        {
            Console.WriteLine("\n Friend Name : " + Name);
            Console.WriteLine("\n Friend Gender : " + Gender);
            Console.WriteLine("\n Friend Age : " + Age);
            Console.WriteLine("\n Friend Address : " + Address);
            Console.WriteLine("\n Friend Email : " + Email);
        }

    }

    public class Tester
    {
        public static void Main()
        {
            int i;
            Friend f = new Friend();

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("\n\n\t\t\t\t\t Adding Friends On FaceBook ");
                Console.WriteLine("\t\t\t\t\t ****** ******* ** ********");

                f.SetName();
                f.SetGender();
                f.SetAge();
                f.SetAddress();
                f.SetEmail();
                f.SendRequest();
                f.Accepted();
                Console.WriteLine("\n\n Details Of The Friends ");
                Console.WriteLine(" ******* ** *** ******* ");
                f.ShowDetails();
                Console.WriteLine("\n\n Message To The New Friend");
                Console.WriteLine(" ******* ** *** *** ******");
                f.SendMsg();
            }
            Console.ReadLine();
        }
    }
}


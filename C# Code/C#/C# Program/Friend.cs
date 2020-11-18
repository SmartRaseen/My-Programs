using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

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

        public void SetName(string s1)
        {
			Console.WriteLine("\n\n Don't Using Any Space On Name");
			Console.WriteLine(" ***** ***** *** ***** ** **** \n");
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
                    Console.WriteLine("INVALID NAME !!! Name must be only alphabets");
            }
            Name = s1;
        }

        public void SetGender(string s2)
        {
            Console.WriteLine();
            if (s2 == null)
                throw new Exception("INVALID GENDER !!! Gender must not be null");
            if (s2 == String.Empty)
                throw new Exception("INVALID GENDER !!! Gender must not empty");
            switch (s2)
            {
                case "M":
                case "m":
                    //Console.WriteLine("MALE");
					s2="Male";
                    break;

                case "F":
                case "f":
                    //Console.WriteLine("FEMALE");
					s2="Female";
                    break;

                default:
                    Console.WriteLine("Unspecified Gender");
                    break;
            }
			Gender=s2;
        }

     // public void SetAge(int s3)
     // {
            
            

     // }

        public void SetAddress(string s4)
        {
            if (s4 == null)
                throw new Exception("INVALID ADDRESS !!! Address must not be null");
            if (s4 == string.Empty)
                throw new Exception("INVALID ADDRESS !!! Address must not be empty");
            if (s4.Length < 3)
                throw new Exception("INVALID ADDRESS !!! Address must be greater than 3 characters");
            if (s4.Length > 50)
                throw new Exception("INVALID ADDRESS !!! Address must be lesser than 50 characters");
            Address = s4;
        }

        public void SetEmail(string s5)
        {
            if (s5 == null)
                throw new Exception("INVALID E-Mail !!! E-Mail must not be null");
            if (s5 == string.Empty)
                throw new Exception("INVALID E-Mail !!! E-Mail must not be empty");
            if (s5.Length < 3)
                throw new Exception("INVALID E-Mail !!! E-Mail must be greater than 3 characters");
            if (s5.Length > 50)
                throw new Exception("INVALID E-Mail !!! E-Mail must be lesser than 50 characters");
            if (!(s5.Contains("@")))
                throw new Exception("INVALID E-Mail !!! E-Mail must contain @ symbol");
            Email = s5;
        }

        public void SendRequest(string FriendSuggestion)
        {
            Console.WriteLine(" Sending Request.... " + FriendSuggestion);
        }

        public void Accepted(string FriendRequest)
        {
            Console.WriteLine("\n Request Accepted...." + FriendRequest);
        }

        public void SendMsg(string MsgToFriend, string Msg)
        {
            Console.WriteLine("\n " + Msg + " Sending Message To.... " + MsgToFriend);
        }

        public void ReceivedMsg(string MsgFrom, string Msg)
        {
            Console.WriteLine("\n " + Msg + " Sending Message To.... " + MsgFrom);
        }

        public void ShowDetails()
        {
            Console.WriteLine("\n Friend Name : " + Name);
            Console.WriteLine("\n Friend Gender : " + Gender);
           // Console.WriteLine("Friend Age : " + Age);
            Console.WriteLine("\n Friend Address : " + Address);
            Console.WriteLine("\n Friend Email : " + Email);
        }

    }

    public class Tester
    {
        public static void Main()
        {
            Friend f = new Friend();
            Console.WriteLine("\n\t\t\t\t\t Adding Friends On FaceBook ");
            Console.WriteLine("\t\t\t\t\t ****** ******* ** ********");
                // Console.WriteLine("Enter The Name : ");
                // string str1=Console.ReadLine();
                f.SetName("SmartRaseen");
                f.SetGender("M");
                f.SetAddress("12,Syed Palli Street, Nagore");
                f.SetEmail("smartraseen05@gmail.com");
                f.SendRequest("HameedSulthan");
                f.Accepted("SmartRaseen");
			Console.WriteLine("\n\n Details Of The Friends ");
            Console.WriteLine(" ******* ** *** ******* ");
                f.ShowDetails();
			Console.WriteLine("\n\n Message To The New Friend");
			Console.WriteLine(" ******* ** *** *** ******");
				f.SendMsg(" SmartRaseen","Assalamu Alaikum - ");
                f.ReceivedMsg(" HameedSulthan","Wa Alaikum Salam - ");
                Console.ReadLine();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
using System;

	class Application
	{
	        public readonly int Studentid;
            string StudentName;
		    string DOB;
		    string BloodGroup;
            float Height;
		    public readonly int Mark;
		
		    Application()
			{
                Console.WriteLine("Student Object Created " + GetHashCode());
			}
			Application(int id,int Mark)
            {
                Console.WriteLine("New Student Object Created " + GetHashCode());
                this.Studentid=id;
				
                for(int i=1;i<=5;i++)
                {
                    Console.WriteLine("Enter The Value : ");
                    Mark=Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("\n Mark Of The Students Are : "+Mark);
				this.Mark=Mark;
            }
            public Application(int id,string strName,string strDOB,string strBloodGroup,float fHeight,int Mark)
            {
                Console.WriteLine("New Student Object " + GetHashCode());
                this.Studentid=id;
                    StudentName=strName;
                    DOB=strDOB;
                    BloodGroup=strBloodGroup;
                    Height=fHeight;
			        this.Mark=Mark;
            }
                //Getters and Setters
            public string GetStudentName() { return StudentName; }
            public string GetDOB() { return DOB; }
            public string GetBloodGroup() { return BloodGroup; }
            public float GetHeight() { return Height; }

		    public void SetStudentName(string s1)
            {
                if (s1 == null)
                    throw new Exception("INVALID STUDENT NAME !!! Student name must not be null");
                if (s1 == string.Empty)
                    throw new Exception("INVALID STUDENT NAME !!! Student name must not be empty");
                if (s1.Length < 3)
                    throw new Exception("INVALID STUDENT NAME !!! Student name must be greater than 3 characters");
                if (s1.Length > 15)
                    throw new Exception("INVALID STUDENT NAME !!! Student name must be lesser than 15 characters");
                char[] data = s1.ToUpper().ToCharArray();
                foreach (char c1 in data)
                {
                    int x = (int)c1;
                    if (x < 65 || x > 90)
                        throw new Exception("INVALID STUDENT NAME !!! Student name only on Alphabets");
                }
                StudentName = s1;
            }
            public void SetDOB(string s2)
            {
                if (s2 == null)
                    throw new Exception("INVALID STUDENT DOB !!! Student DOB must not be null");
                if (s2 == string.Empty)
                    throw new Exception("INVALID STUDENT DOB !!! Student DOB must not be empty");
                if (s2.Length < 3)
                    throw new Exception("INVALID STUDENT DOB !!! Student DOB must be greater than 3 characters");
                if (s2.Length > 15)
                    throw new Exception("INVALID STUDENT DOB !!! Student DOB must be lesser than 15 characters");
                Console.WriteLine("Date_Of_Birth Must Be This Format->dd/mm/yy\n");
                Console.WriteLine("Enter The Date/Of/Birth : ");
		        string name = Console.ReadLine();
	            Console.WriteLine(""+name);
                name = s2;
            }
            public void SetBloodGroup(string s3)
            {
                if (s3 == null)
                    throw new Exception("INVALID STUDENT BLOOD_GROUP !!! Student Blood_Group must not be null");
                if (s3 == string.Empty)
                    throw new Exception("INVALID STUDENT BLOOD_GROUP !!! Student Blood_Group must not be empty");
                if (s3.Length == 1)
                    throw new Exception("INVALID STUDENT BLOOD_GROUP !!! Student Blood_Group must be Greater or Equal to 2 characters");
                if (s3.Length > 5)
                    throw new Exception("INVALID STUDENT BLOOD_GROUP !!! Student Blood_Group must be lesser than 5 characters");
                Console.WriteLine("Enter Your Blood Group : ");
		        string blood = Console.ReadLine();
	            Console.WriteLine(""+blood);            
                blood = s3;
            }
            public void SetHeight(float l1)
            {
                if (l1.Equals(null))
                    throw new Exception("INVALID STUDENT HEIGHT !!! Student Height must not be null");
                Console.WriteLine("Enter The Height Of Student : ");
                float Height=float.Parse(Console.ReadLine());
                Console.WriteLine(Height);
                Height = l1;
            }
			public static void Main()
			{
				int n1;
				Console.WriteLine("\t Student Database");
				Console.WriteLine("\t ******* ********\n");	
				id=Studentid;
				StudentName=GetStudentName();
		}
	}		   
	
}
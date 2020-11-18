using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
using System;

	class Employee
	{
		    string BloodGroup;
            float Height;
		
            public Employee(string strBloodGroup,float fHeight)
            {
                    BloodGroup=strBloodGroup;
                    Height=fHeight;
            }
                //Getters and Setters
            public string GetBloodGroup() { return BloodGroup; }
            public float GetHeight() { return Height; }

            public void SetBloodGroup(string s1)
            {
                if (s1 == null)
                    throw new Exception("INVALID EMPLOYEE BLOOD_GROUP !!! Employee Blood_Group must not be null");
                if (s1 == string.Empty)
                    throw new Exception("INVALID EMPLOYEE BLOOD_GROUP !!! Employee Blood_Group must not be empty");
                if (s1.Length == 1)
                    throw new Exception("INVALID EMPLOYEE BLOOD_GROUP !!! Employee Blood_Group must be Greater or Equal to 2 characters");
                if (s1.Length > 5)
                    throw new Exception("INVALID EMPLOYEE BLOOD_GROUP !!! Employee Blood_Group must be lesser than 5 characters");
                Console.WriteLine("Enter The Blood Group Of Employee : ");
		        string blood = Console.ReadLine();
	            Console.WriteLine(""+blood);            
                blood = s1;
            }
            public void SetHeight(float l1)
            {
                if (l1.Equals(null))
                    throw new Exception("INVALID EMPLOYEE HEIGHT !!! Employee Height must not be null");
                Console.WriteLine("Enter The Height Of Employee : ");
                float Height=float.Parse(Console.ReadLine());
                Console.WriteLine(Height);
                Height = l1;
            }
	}		   
	
}
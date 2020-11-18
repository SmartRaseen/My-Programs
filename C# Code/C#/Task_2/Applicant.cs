using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{					
	class Applicant
	{
	    private readonly int Applicantid;
        private string ApplicantName;
		private string ApplicantAddress;
		private long ApplicantMobileNo;
        private string ApplicantEMail;
		private string ApplicantPost;
        private string InterviewDate;
			
		public Applicant()
        {
			int n1;
			Console.WriteLine("\t ApplicantPost");
			Console.WriteLine("\t *************\n");	
			Console.Write(" Enter The Value : ");
			n1=Convert.ToInt32(Console.ReadLine());
				if(n1==1)
				Console.WriteLine("\n Applicant Post : Clerks ");	
				if(n1==2)
				Console.WriteLine("\n Applicant Post : ProbationaryOfficers  ");
            Console.WriteLine("Applicant Object Created " + GetHashCode());
        }
        public Applicant(int id)
        {
            Console.WriteLine("New Applicant Object Created " + GetHashCode());
            this.Applicantid=id;
        }
        public Applicant(int id,string strName,string strAddress,long lMobileNo,string strEMail,string strDate)
        {
            Console.WriteLine("New Employee Object " + GetHashCode());
            this.Applicantid=id;
            ApplicantName=strName;
            ApplicantAddress=strAddress;
            ApplicantMobileNo=lMobileNo;
            ApplicantEMail=strEMail;
			InterviewDate=strDate;
        }
        //Getters and Setters
        public string GetApplicantName() { return ApplicantName; }
        public string GeApplicantAddress() { return ApplicantAddress; }
        public long GetApplicantMobileNo() { return ApplicantMobileNo; }
        public string GetApplicantEMail() { return ApplicantEMail; }

		public void SetApplicantName(string s1)
        {
            if (s1 == null)
                throw new Exception("INVALID APPLICANT NAME !!! Applicant name must not be null");
            if (s1 == string.Empty)
                throw new Exception("INVALID APPLICANT NAME !!! Applicant name must not be empty");
            if (s1.Length < 3)
                throw new Exception("INVALID APPLICANT NAME !!! Applicant name must be greater than 3 characters");
            if (s1.Length > 15)
                throw new Exception("INVALID APPLICANT NAME !!! Applicant name must be lesser than 15 characters");
            char[] data = s1.ToUpper().ToCharArray();
            foreach (char c1 in data)
            {
                int x = (int)c1;
                if (x < 65 || x > 90)
                    throw new Exception("INVALID APPLICANT NAME !!! Applicant name must be only Alphabets");
            }
            ApplicantName = s1;
        }
        public void SetApplicantAddress(string s2)
        {
            if (s2 == null)
                throw new Exception("INVALID APPLICANT ADDRESS !!! Applicant address must not be null");
            if (s2 == string.Empty)
                throw new Exception("INVALID APPLICANT ADDRESS !!! Applicant address must not be empty");
            if (s2.Length < 3)
                throw new Exception("INVALID APPLICANT ADDRESS !!! Applicant address must be greater than 3 characters");
            if (s2.Length > 50)
                throw new Exception("INVALID APPLICANT ADDRESS !!! Applicant address must be lesser than 50 characters");
            ApplicantAddress = s2;
        }
        public void SetApplicantMobileNo(long l1)
        {
            if (l1 < 9000000000 || l1 > 10000000000)
                throw new Exception("INVALID MOBILE NUMBER !!!");
            if (l1 < 9000000000L || l1 > 10000000000L)
                throw new Exception("INVALID MOBILE NUMBER !!!");
            string value = Convert.ToString(l1.GetType());
            if (value == "long")
                throw new Exception("INVALID MOBILE NUMBER !!!");
            ApplicantMobileNo = l1;
        }
        public void SetApplicantEMail(string s3)
        {
            if (s3 == null)
                throw new Exception("INVALID APPLICANT E-Mail !!! Applicant E-Mail must not be null");
            if (s3 == string.Empty)
                throw new Exception("INVALID APPLICANT E-Mail !!! Applicant E-Mail must not be empty");
            if (s3.Length < 3)
                throw new Exception("INVALID APPLICANT E-Mail !!! Applicant E-Mail must be greater than 3 characters");
            if (s3.Length > 50)
                throw new Exception("INVALID APPLICANT E-Mail !!! Applicant E-Mail must be lesser than 50 characters");
            if (!(s3.Contains("@")))
                throw new Exception("INVALID APPLICANT E-Mail !!! Applicant E-Mail must contain @ symbol");
            ApplicantEMail = s3;
        }
		public void SetInterviewDate(string s4)
		{
			Console.WriteLine("Interview Date");
			Console.WriteLine("********* ****\n");
			Console.WriteLine("Date ormat Like : dd/mm/yy");
			Console.WriteLine("Enter The Interview Date : ");
		string name = Console.ReadLine();
	    Console.WriteLine(""+name);
		}
	} 
}

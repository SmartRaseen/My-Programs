using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
	public partial class Candidate : Applicant
	{
	    private readonly int Candidateid;
        private string CandidateName;
		private string CandidateAddress;
		private long CandidateMobileNo;
        private string CandidateEMail;
		
		//Getters and Setters
		public string GetCandidateName() { return CandidateName; }
        public string GeCandidateAddress() { return CandidateAddress; }
        public long GetCandidateMobileNo() { return CandidateMobileNo; }
        public string GetCandidateEMail() { return CandidateEMail; }
		
		public static void Main()
		{
			int n1;
			Console.WriteLine("\t Selection Process");
			Console.WriteLine("\t ********* *******\n");	
			Console.Write(" Enter The Value : ");
			n1=Convert.ToInt32(Console.ReadLine());
				if(n1==1)
				Console.WriteLine("\n Congratulations!! You are selected to the post Of Clerk !! ");	
				if(n1==2)
				CandidateName=GetApplicantName();
			    CandidateAddress=GetApplicantAddress();
			    CandidateMobileNo=GetApplicantMobileNo();
                CandidateEMail=GetApplicantEMail();	
				Console.WriteLine("\n Congratulations!! You are selected to the post Of Probationary Officer !!");			
			    if(n1==3)
				Console.WriteLine("\n Thank you very much for taking the time to interview with us for the position \n We Regret to inform that You have not cleared interview \n We Wish all the Best for your upcoming interviews");	
				CandidateName=GetApplicantName();
			    CandidateAddress=GetApplicantAddress();
			    CandidateMobileNo=GetApplicantMobileNo();
                CandidateEMail=GetApplicantEMail();			
		}	
	} 
}
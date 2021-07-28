using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.Globalization;

namespace Miniproject1
{
    public class AllComplaints
    {
       
        static List<Complaint>  data = new List<Complaint>();

        static AllComplaints()
        {
            using (var reader = new StreamReader(@"D:\Mini Project I\.NET\complaints.csv"))
            {
                using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    data = csvReader.GetRecords<Complaint>().ToList();
                }
            }
        }

       



        //Display all the complaints based on the year provided by the user
        public void DisplayComplaintsByYear(string year)
        {
            foreach (Complaint details in data)
            {

                if ((details.DateReceived.Split("/")[2]) == year )
                {
                    //    Console.WriteLine("->" + details.DateReceived + " "
                    //        + details.Product + " "
                    //        + details.SubProduct + " "
                    //        + details.Issue + " "
                    //        + details.SubIssue + " "
                    //        + details.Company + " "
                    //        + details.State + " "
                    //        + details.ZipCode + " "
                    //        + details.SubmittedVia + " "
                    //        + details.DateSentToCompany + " "
                    //        + details.CompanyResponseToConsumer + " "
                    //        + details.TimelyResponse + " "
                    //        + details.ConsumerDisputed + " "
                    //        + details.ComplaintID);

                    Complaint.Display(details);
                
                }
                
            }
        }


        //Display all the complaints based on the name of the bank provided by the user
        public void DisplayComplaintsByBankName(string bankName)
        {
            foreach (Complaint details in data)
            {

                if ((details.Company) == bankName)
                {
                  
                    //Console.WriteLine("->"+details.DateReceived + " "
                    //    + details.Product + " "
                    //    + details.SubProduct + " "
                    //    + details.Issue + " "
                    //    + details.SubIssue + " "
                    //    + details.Company + " "
                    //    + details.State + " "
                    //    + details.ZipCode + " "
                    //    + details.SubmittedVia + " "
                    //    + details.DateSentToCompany + " "
                    //    + details.CompanyResponseToConsumer + " "
                    //    + details.TimelyResponse + " "
                    //    + details.ConsumerDisputed + " "
                    //    + details.ComplaintID);
                    Complaint.Display(details);
                }

            }
        }



        //Display complaints based on the complaint id provided by the user
        public void DisplayComplaintsByComplaintID(string complaintID)
        {
            foreach (Complaint details in data)
            {

                if ((details.ComplaintID) == complaintID)
                {
                    //Console.WriteLine("->" + details.DateReceived + " "
                    //    + details.Product + " "
                    //    + details.SubProduct + " "
                    //    + details.Issue + " "
                    //    + details.SubIssue + " "
                    //    + details.Company + " "
                    //    + details.State + " "
                    //    + details.ZipCode + " "
                    //    + details.SubmittedVia + " "
                    //    + details.DateSentToCompany + " "
                    //    + details.CompanyResponseToConsumer + " "
                    //    + details.TimelyResponse + " "
                    //    + details.ConsumerDisputed + " "
                    //    + details.ComplaintID);
                    Complaint.Display(details);
                }

            }
        }


        //Display number of days took by the Bank to close the complaint
        //public void DisplayComplaintsByDaysForClosure()
        //{
        //    Console.WriteLine("Enter the Complaint ID:");
        //    string cpId = Console.ReadLine();
            
        //    foreach (Complaint details in data)
        //    {

        //        if (((DateTime.Parse(details.DateSentToCompany) - DateTime.Parse(details.DateReceived)).Days) == cpId)
        //        {
        //            Console.WriteLine(details.DateReceived + " "
        //                + details.Product + " "
        //                + details.SubProduct + " "
        //                + details.Issue + " "
        //                + details.SubIssue + " "
        //                + details.Company + " "
        //                + details.State + " "
        //                + details.ZipCode + " "
        //                + details.SubmittedVia + " "
        //                + details.DateSentToCompany + " "
        //                + details.CompanyResponseToConsumer + " "
        //                + details.TimelyResponse + " "
        //                + details.ConsumerDisputed + " "
        //                + details.ComplaintID);

        //        }

        //    }
        //}


        //Display number of days took by the Bank to close the complaint

        public void DisplayComplaintDaysForClosure()
        {
            Console.WriteLine("Enter the Complaint ID:");
            string cpId = Console.ReadLine();

            Console.WriteLine("Complaint ID | Days Taken To Close Complaint");
            foreach (Complaint details in data)
            {
                if (details.ComplaintID == cpId)
                {
                    Console.WriteLine(details.ComplaintID + " "
                        + (DateTime.Parse(details.DateSentToCompany, new CultureInfo("en-CA")) - DateTime.Parse(details.DateReceived, new CultureInfo("en-CA"))).Days);
                    break;
                }
            }
                    
        }

        //Display all the complaints closed/closed with explanation
        public void DisplayComplaintsClosedOrClosedWithExplain()
        {
            foreach (Complaint details in data)
            {

                if ((details.CompanyResponseToConsumer) == "Closed" || (details.CompanyResponseToConsumer) == "Closed with explanation")
                {
                    //Console.WriteLine("->" + details.DateReceived + "| "
                    //    + details.Product + "| "
                    //    + details.SubProduct + "| "
                    //    + details.Issue + "| "
                    //    + details.SubIssue + "| "
                    //    + details.Company + "| "
                    //    + details.State + "| "
                    //    + details.ZipCode + "| "
                    //    + details.SubmittedVia + "| "
                    //    + details.DateSentToCompany + "| "
                    //    + details.CompanyResponseToConsumer + "| "
                    //    + details.TimelyResponse + "| "
                    //    + details.ConsumerDisputed + "| "
                    //    + details.ComplaintID);
                    Complaint.Display(details);
                }

            }
        }



        //Display all the complaints which received a timely response
        public void DisplayComplaintsByTimelyResponse()
        {
            foreach (Complaint details in data)
            {

                if ((details.TimelyResponse) == "Yes")
                {
                    //Console.WriteLine("->" + details.DateReceived + " "
                    //    + details.Product + " "
                    //    + details.SubProduct + " "
                    //    + details.Issue + " "
                    //    + details.SubIssue + " "
                    //    + details.Company + " "
                    //    + details.State + " "
                    //    + details.ZipCode + " "
                    //    + details.SubmittedVia + " "
                    //    + details.DateSentToCompany + " "
                    //    + details.CompanyResponseToConsumer + " "
                    //    + details.TimelyResponse + " "
                    //    + details.ConsumerDisputed + " "
                    //    + details.ComplaintID);
                    Complaint.Display(details);

                }

            }
        }


        // Take input from user for storing new complaints
        public void RaiseComplaint()
        {
            Complaint regrComplaint = new Complaint();

            Console.WriteLine("Date Received:");
            regrComplaint.DateReceived = Console.ReadLine();
          
            Console.WriteLine("Product:");
            regrComplaint.Product = Console.ReadLine();
          
            Console.WriteLine("Sub-Product:");
            regrComplaint.SubIssue = Console.ReadLine();

            Console.WriteLine("Issue:");
            regrComplaint.Issue = Console.ReadLine();
            
            Console.WriteLine("SubIssue:");
            regrComplaint.SubIssue = Console.ReadLine();
        
            Console.WriteLine("Company:");
            regrComplaint.Company = Console.ReadLine();
        
            Console.WriteLine("State:");
            regrComplaint.State = Console.ReadLine();
   
            Console.WriteLine("ZIP Code:");
            regrComplaint.ZipCode = Console.ReadLine();

            Console.WriteLine("Submitted Via:");
            regrComplaint.SubmittedVia = Console.ReadLine();
 
            Console.WriteLine("Date Sent To Company:");
            regrComplaint.DateSentToCompany = Console.ReadLine();
   
            Console.WriteLine("Company response to consumer:");
            regrComplaint.CompanyResponseToConsumer = Console.ReadLine();         

            Console.WriteLine("Timely Response?:");
            regrComplaint.TimelyResponse = Console.ReadLine();

            Console.WriteLine("Consumer Disputed:");
            regrComplaint.ConsumerDisputed = Console.ReadLine();   

            Console.WriteLine("Complaint ID:");
            regrComplaint.ComplaintID = Console.ReadLine();

            data.Add(regrComplaint);
            Console.WriteLine("Complaint Raised Successfully!");
           
        }




    }
}

using System;

namespace Miniproject1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int choice;
            string param;
            AllComplaints user = new AllComplaints();
            while (flag)
            {
                Console.WriteLine("hello worlds");
                Console.WriteLine("1235");
                Console.WriteLine("6547");
                Console.WriteLine("hello world8");
                Console.WriteLine("1.Display all the complaints based on the year provided by the user\n" +
                "2.Display all the complaints based on the name of the bank provided by the user\n" +
                "3.Display complaints based on the complaint id provided by the user\n" +
                "4.Display number of days took by the Bank to close the complaint\n" +
                "5.Display all the complaints closed/closed with explanation\n" +
                "6.Display all the complaints which received a timely response\n" +
                "7.Take input from user for storing new complaints\n" +
                "8.Exit");
                
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the year:");
                        param=Console.ReadLine();
                        user.DisplayComplaintsByYear(param);
                        break;
                    case 2:
                        Console.WriteLine("Enter the bank name:");
                        param = Console.ReadLine();
                        user.DisplayComplaintsByBankName(param);
                        break;
                    case 3:
                        Console.WriteLine("Enter the Complaint ID:");
                        param = Console.ReadLine();
                        user.DisplayComplaintsByComplaintID(param);
                        break;
                    case 4:
                        user.DisplayComplaintDaysForClosure();
                        break;
                    case 5:
                        user.DisplayComplaintsClosedOrClosedWithExplain();
                        break;
                    case 6:
                        user.DisplayComplaintsByTimelyResponse();
                        break;
                    case 7:
                        user.RaiseComplaint();
                        break;
                    case 8:
                        Console.WriteLine("THANK YOU FOR USING OUR SERVICE");
                        flag = false;
                        break;

                }
            }
            
      
        }
    }
}

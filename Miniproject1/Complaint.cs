using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;
using CsvHelper.Configuration;

namespace Miniproject1
{
    class Complaint
        //hello
        
    {
        //Date received, Product, Sub-product,Issue,Sub-issue,Company,State,ZIP code, Submitted via,
        //Date sent to company, Company response to consumer,Timely response?, Consumer disputed?,Complaint ID
            
        [Name("Date received")]
        public string DateReceived { get; set; }
        
        [Name("Product")]
        public string Product{ get; set; }

        [Name("Sub-product")]
        public string SubProduct { get; set; }


        [Name("Issue")]
        public string Issue { get; set; }

        [Name("Sub-issue")]
        public string SubIssue { get; set; }

        [Name("Company")]
        public string Company { get; set; }

        [Name("State")]
        public string State { get; set; }

        [Name("ZIP code")]
        public string ZipCode { get; set; }

        [Name("Submitted via")]
        public string SubmittedVia { get; set; }

        [Name("Date sent to company")]
        public string DateSentToCompany { get; set; }


        [Name("Company response to consumer")]
        public string CompanyResponseToConsumer { get; set; }


        [Name("Timely response?")]
        public string TimelyResponse { get; set; }


        [Name("Consumer disputed?")]
        public string ConsumerDisputed { get; set; }

        [Name("Complaint ID")]
        public string ComplaintID { get; set; }


      



    }
}

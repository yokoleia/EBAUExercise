using System;
using System.Collections.Generic;
using System.Linq;
using EBAUExercise.Repository;
using EBAUExercise.Models; 

namespace EBAUExercise.Services
{
    
    public class CustomerReportService
    {

        public static List<CustomerReport> _CustomerReportList { get; set; }

        private readonly SampleDataRepository _sampleDataRepository;

        public CustomerReportService(SampleDataRepository sampleDataRepository)
        {
            _sampleDataRepository = sampleDataRepository;
        }


        /// <summary>
        /// Build and output a list of data that breaks down the data by customer id, taking count of orders and summing 'order total'.
        /// </summary>
        /// 

        // the most obvious approach is to do a nested for loop which could be computationally expensive
        // instead, sort list, and loop through once, checking current userID vs last saved userID. 


        private void CustomerReport()
        {
            System.Console.WriteLine("Calculating Report");

            var dataset = _sampleDataRepository.GetDataset;
            
            // LINQ to sort the dataset by the embedded customerid
            List<CustomerOrder> SortedList = dataset.OrderBy(o => o.CustomerId).ToList();

            //Customer Reports
            List<CustomerReport> CustomerReportList = new List<CustomerReport>();

            for (int i = 0; i < SortedList.Count; i++)
            {

                CustomerOrder current = SortedList[i];

                
                if (CustomerReportList.Count() == 0)
                {
                    CustomerReportList.Add(new CustomerReport(current.CustomerId, 1, current.OrderTotal));
                    Console.WriteLine(CustomerReportList.Count());
                    Console.WriteLine("{0} {1} {2}", current.CustomerId, 1, current.OrderTotal);
                }
                else
                {
                    // checking to see if its the same customer's orders and summing totals for count and cost. 
                    // if customer in list == last customer in report. 
                    int currIndex = CustomerReportList.Count()-1;
                    if (SortedList[i].CustomerId == CustomerReportList[currIndex].CustomerId)
                    {
                        CustomerReportList[currIndex].OrderCount++;
                        CustomerReportList[currIndex].OrderTotal += SortedList[i].OrderTotal;
                    }
                    else
                    {
                        CustomerReportList.Add(new CustomerReport(current.CustomerId, 1, current.OrderTotal));  
                    }

                }
            }
            _CustomerReportList = CustomerReportList;
        }

        

        /// <summary>
        /// Needs to be called to calculate and finalise the reports. 
        /// </summary>
        public void update()
        {
            CustomerReport();
        }
    }
}
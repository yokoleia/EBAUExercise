using System;
using System.Collections.Generic;
using System.Linq;
using EBAUExercise.Repository;
using EBAUExercise.Models; 

namespace EBAUExercise.Services
{
    
    public class StoresReportService
    {


        public static List<StoreReport> _StoreDailyReportList { get; set; }

        private readonly SampleDataRepository _sampleDataRepository;

        public StoresReportService(SampleDataRepository sampleDataRepository)
        {
            _sampleDataRepository = sampleDataRepository;
        }

        /// <summary>
        /// Build and output a list of data that shows the number of orders by date and a sum of 'order total'.
        /// </summary>
        public void StoreDailyReport()
        {
            var dataset = _sampleDataRepository.GetDataset;
            // LINQ to sort the dataset by the embedded customerid
            List<CustomerOrder> SortedList = dataset.OrderBy(o => o.OrderDate).ToList();

            //Store Reports
            List<StoreReport> StoreReportList = new List<StoreReport>();

            for (int i = 0; i < SortedList.Count; i++)
            {

                CustomerOrder current = SortedList[i];


                if (StoreReportList.Count() == 0)
                {
                    StoreReportList.Add(new StoreReport(current.OrderDate, 1, current.OrderTotal));
                }
                else
                {
                    // checking to see if its the same customer's orders and summing totals for count and cost. 
                    // if customer in list == last customer in report. 
                    int currIndex = StoreReportList.Count() - 1;
                    TimeSpan ts = SortedList[i].OrderDate - StoreReportList[currIndex].OrderDate;
                    if (ts.TotalDays < 1)
                    {

                       
                        StoreReportList[currIndex].OrderCount++;
                        StoreReportList[currIndex].OrderTotal += SortedList[i].OrderTotal;
                    }
                    else
                    {
                        StoreReportList.Add(new StoreReport(current.OrderDate, 1, current.OrderTotal));
                    }

                }

            }

            _StoreDailyReportList = StoreReportList;

        }

        /// <summary>
        /// Needs to be called to calculate and finalise the reports. 
        /// </summary>
        public void update()
        {
            StoreDailyReport();
        }
    }
}
using System;

namespace EBAUExercise.Models
{
    /// <summary>
    /// Model for Organising Customer Reports
    /// </summary>
    public class CustomerReport
    {
        
        public CustomerReport(int customerId, int orderCount, decimal orderTotal)
        {
            CustomerId = customerId;
            OrderCount = orderCount;
            OrderTotal = orderTotal;
        }

        public int CustomerId { get; set; }
        public int OrderCount { get; set; }
        public decimal OrderTotal { get; set; }
    }

    /// <summary>
    /// Model for organising StoreDailyReports. 
    /// </summary>
    public class StoreReport
    {
        public StoreReport(DateTime orderDate, int orderCount, decimal orderTotal)
        {
            OrderDate = orderDate;
            OrderCount = orderCount;
            OrderTotal = orderTotal;
        }

        public DateTime OrderDate { get; set; }
        public int OrderCount { get; set; }
        public decimal OrderTotal { get; set; }
    }
}
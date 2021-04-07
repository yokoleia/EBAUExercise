using EBAUExercise.Repository;

namespace EBAUExercise.Services
{
    public class ReportService
    {
        private readonly SampleDataRepository _sampleDataRepository;

        public ReportService(SampleDataRepository sampleDataRepository)
        {
            _sampleDataRepository = sampleDataRepository;
        }

        /// <summary>
        /// Build and output a list of data that breaks down the data by customer id, taking count of orders and summing 'order total'.
        /// </summary>
        private void CustomerReport()
        {
            var dataset = _sampleDataRepository.GetDataset;



        }

        /// <summary>
        /// Build and output a list of data that shows the number of orders by date and a sum of 'order total'.
        /// </summary>
        private void StoreDailyReport()
        {
            var dataset = _sampleDataRepository.GetDataset;



        }
    }
}
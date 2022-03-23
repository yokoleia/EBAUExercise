using EBAUExercise.Repository;

namespace EBAUExercise.Services
{
    public class DoWorkService
    {
        
        private CountingService _CountingService;
        private MockDataRepository _mockDataRepository;




        public DoWorkService(MockDataRepository mockDataRepository, CountingService CountingService)
        {
            _mockDataRepository = mockDataRepository;
            _CountingService = CountingService;

        }

        public bool DoWork()
        {
            _CountingService.Increment();
            return _mockDataRepository.Save();
        }
    }
}
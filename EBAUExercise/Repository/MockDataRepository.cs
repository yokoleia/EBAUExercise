using EBAUExercise.Services;

namespace EBAUExercise.Repository
{
    public class MockDataRepository
    {

        private CountingService _CountingService;
        public MockDataRepository(CountingService CountingService)
        {
            _CountingService = CountingService;
        }


        public bool Save()
        {
            

            _CountingService.Increment();

            return true;
        }
    }
}
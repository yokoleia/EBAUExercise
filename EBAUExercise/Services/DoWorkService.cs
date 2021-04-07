using EBAUExercise.Repository;

namespace EBAUExercise.Services
{
    public class DoWorkService
    {
        private readonly MockDataRepository _mockDataRepository;

        public DoWorkService(MockDataRepository mockDataRepository)
        {
            _mockDataRepository = mockDataRepository;
        }

        private bool DoWork()
        {
            return _mockDataRepository.Save();
        }
    }
}
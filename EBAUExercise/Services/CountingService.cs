using EBAUExercise.Repository;

namespace EBAUExercise.Services
{
    public class CountingService
    {

        // Counter
        // main counter variable, private, access only with get and set.
        private static int _Count;
        public int Count
        {
            get => _Count;
            set => _Count = value;
        }


        public int Increment()
        {
           return _Count++;
        }

        
        public static int Reset()
        {
           return _Count = 0;
        }
    }


}
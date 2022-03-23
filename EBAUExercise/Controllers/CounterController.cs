using EBAUExercise.Repository;

namespace EBAUExercise.Services
{
    public class CounterController
    {
        // main counter variable, private, access only with get and set. 
        private int _counter;

        // main access method
        public int Counter
        {
            get => _counter;
            set => _counter = value;


        }
    }
}
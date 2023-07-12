namespace UnitTestLearning
{
    public class SampleService
    {
        public int Sum(int a, int b) => a + b;
        
        public int Subtraction(int a, int b) => a - b;
        
        public int Multiply(int a, int b) => a * b;
        
        public int Divide(int a, int b)
        {
            if (b != 0)
            {
                return a / b;
            }
            return 0;
        }
    }
}

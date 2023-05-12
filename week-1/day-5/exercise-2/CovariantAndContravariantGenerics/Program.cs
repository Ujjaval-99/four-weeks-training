namespace CovariantAndContravariantGenerics
{
    interface IProcessor<in TInput, out TResult>
    {
        TResult Process(TInput input);
    }

    class StringToIntProcessor : IProcessor<string, int>
    {
        // Implement Process method
        public int Process(string input)
        {
            //throw new NotImplementedException();
            return input.Length;
        }
    }

    class DoubleToStringProcessor : IProcessor<double, string>
    {
        // Implement Process method
        public string Process(double input)
        {
           //throw new NotImplementedException();
            return input.ToString();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Demonstrate covariance and contravariance with IProcessor interface
            // Covariance example
            IProcessor<string, int> stringToObjectProcessor = new StringToIntProcessor();
            string inputString = "Hello Universe!!";
            object resultObject = stringToObjectProcessor.Process(inputString);
            Console.WriteLine($"String length: {resultObject}");

            // Contravariance example
            IProcessor<double, string> objectToStringProcessor = new DoubleToStringProcessor();
            double inputDouble = 3.14;
            string resultString = objectToStringProcessor.Process(inputDouble);
            Console.WriteLine($"String representation of double: {resultString}");
        }
    }
}
namespace FileLoggerDisposableApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var logger = new FileLogger("Ujjval Mistry.txt"))
            {
                logger.Log("I am Ujjval...!");
                // some code here
                logger.Log("I'm a unemployeed.....!!");
                logger.Dispose();
            }
            // Use FileLogger and dispose of it properly
        }
    }
    class FileLogger : IDisposable
    {
        private StreamWriter _writer;
        public FileLogger(string filePath)
        {
            _writer = new StreamWriter(filePath);
            // Initialize StreamWriter instance
        }
        public void Dispose()
        {
            _writer.Dispose();
            // Implement IDisposable pattern
        }
        public void Log(string message)
        {
            _writer?.WriteLine(message);
            // Write message to the file
        }
    }
}
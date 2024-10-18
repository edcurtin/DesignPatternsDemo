namespace DesignPatternsLibrary.Services
{
    using DesignPatternsLibrary.Creational.Interfaces;

    /// <summary>
    /// LoggerService
    /// </summary>
    public class LoggerService : ILoggerService
    {
        private readonly List<string> _logMessages = new();

        /// <summary>
        /// Log
        /// </summary>
        /// <param name="message"></param>
        public void Log(string message)
        {
            _logMessages.Add($"{DateTime.Now}: {message}");
        }

        /// <summary>
        /// GetAllLogs
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllLogs()
        {
            return _logMessages;
        }
    }
}

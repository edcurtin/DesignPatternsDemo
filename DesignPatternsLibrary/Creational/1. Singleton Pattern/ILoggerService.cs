
namespace DesignPatternsLibrary.Creational.Interfaces
{
    /// <summary>
    /// ILoggerService
    /// </summary>
    public interface ILoggerService
    {
        void Log(string message);

        List<string> GetAllLogs();
    }
}

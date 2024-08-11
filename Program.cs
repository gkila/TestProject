using NUnit.Framework;

public class Program
    {
        private const string filePath = "application.log";

        public void LogFormat(string message, string logStatus)
        {       
        string logEntry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{logStatus}] {message}";     
        File.AppendAllText(filePath, logEntry + Environment.NewLine);

        }
    }
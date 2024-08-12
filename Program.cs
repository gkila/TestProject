using NUnit.Framework;

public class Program
    {
        private const string filePath = "application.log";

        public void LogFormat(string message, string logStatus)
        {                   
            string logEntry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{logStatus}] {message}";     
            File.AppendAllText(filePath, logEntry + Environment.NewLine);
        }

        public List<Product> ListProducts(List<Product> products, string sortKey, bool ascending)
        {
            switch (sortKey.ToLower())
            {
                case "name":
                 return ascending 
                    ? products.OrderBy(p => p.Name).ToList()
                    : products.OrderByDescending(p => p.Name).ToList();
                
                case "price":
                return ascending 
                    ? products.OrderBy(p => p.Price).ToList()
                    : products.OrderByDescending(p => p.Price).ToList();
                
                case "stock":
                return ascending 
                    ? products.OrderBy(p => p.Stock).ToList()
                    : products.OrderByDescending(p => p.Stock).ToList();
                
                default:
                throw new ArgumentException();
            }
        }
    }
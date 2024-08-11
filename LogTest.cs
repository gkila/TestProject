using NUnit.Framework;

public class ProgramTest
    {
        private Program p;
        private string filePath = "application.log";

        [SetUp]
        public void Setup()
        {
            p = new Program();
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        [TearDown]
        public void Teardown()
        {
             if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
    
        [Test]
        public void LogTest()
        {
          
        }
    }
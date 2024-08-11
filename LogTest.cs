using NUnit.Framework;
using NUnit.Framework.Interfaces;

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
        public void LogTestFileShouldBeCreated()
        {
            p.LogFormat("User logged in", "INFO");
            Assert.That(File.Exists(filePath), Is.True, "file exist.");
        }
    }
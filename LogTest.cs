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

          [Test]
        public void ValidateLogFileMessage()
        {
             p.LogFormat("User logged in", "INFO");
             p.LogFormat("Failed login attempt", "WARNING");

            var logContents = File.ReadAllLines(filePath);
            Assert.That(logContents, Has.Some.Contains("[INFO] User logged in"));
            Assert.That(logContents, Has.Some.Contains("[WARNING] Failed login attempt"));
        }
    }
using NUnit.Framework;

public class ProgramTest
    {

        [SetUp]
        public void Setup()
        {
            Program p = new Program();
            p.Function();
        }

        [Test]
        public void TestFunction()
        {
          
        }

        [TearDown]
        public void Teardown()
        {
    
        }
    }
using NUnit.Framework;
using lab2;

namespace lab2.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Maint_ValidInput_ReturnsZero()
        {
            using (StringWriter sw = new StringWriter())  
            using (StringReader sr = new StringReader("5\n"))  
            {
                Console.SetOut(sw);
                Console.SetIn(sr);

                int exitCode = lab2.Program.Main();  

                Assert.That(exitCode, Is.EqualTo(0));  
                Assert.That(sw.ToString().Trim(), Does.EndWith("Result: 120"));  
            }
        }

        [Test]
        public void Main_NegativeNumber_ReturnsOne()
        {
            using (StringWriter sw = new StringWriter())
            using (StringReader sr = new StringReader("-1\n"))
            {
                Console.SetOut(sw);
                Console.SetError(sw);
                Console.SetIn(sr);

                int exitCode = lab2.Program.Main();

                Assert.That(exitCode, Is.EqualTo(1));  
                Assert.That(sw.ToString().Trim(), Does.Contain("Error: Factorial is defined only for non-negative numbers."));
            }
        }

        [Test]
        public void Main_ZeroInput_ReturnsOne()
        {
            using (StringWriter sw = new StringWriter())
            using (StringReader sr = new StringReader("0\n"))
            {
                Console.SetOut(sw); 
                Console.SetIn(sr);   

                int exitCode = lab2.Program.Main();  

                Assert.That(exitCode, Is.EqualTo(0));  
                Assert.That(sw.ToString().Trim(), Does.Contain("Result: 1"));  
            }
        }

        [Test]
        public void Main_IvalidInput_ReturnsOne()
        {
            using (StringWriter sw = new StringWriter())
            using (StringReader sr = new StringReader("abc\n"))
            {
                Console.SetOut(sw);
                Console.SetError(sw);  
                Console.SetIn(sr);

                int exitCode = lab2.Program.Main(); 

                Assert.That(exitCode, Is.EqualTo(1)); 
                Assert.That(sw.ToString().Trim(), Does.Contain("Error: Invalid number format.")); 
            }
        }

        [Test]
        public void Main_EmptyInput_ReturnsOne()
        {
            using (StringWriter sw = new StringWriter())
            using (StringReader sr = new StringReader("\n"))
            {
                Console.SetOut(sw);
                Console.SetError(sw);
                Console.SetIn(sr);

                int exitCode = lab2.Program.Main();

                Assert.That(exitCode, Is.EqualTo(1));
                Assert.That(sw.ToString().Trim(), Does.Contain("Error: Input value cannot be empty."));
            }

        }
    }
}
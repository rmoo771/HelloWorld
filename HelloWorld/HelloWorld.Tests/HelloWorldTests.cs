using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace HelloWorld.Tests
{
    [TestClass]
    public class HelloWorldTests
    {
       
       
        [TestMethod]
        public void ConsoleWriteLine_OutputText_ExpectHelloWorld()
        {

            // Arrange
            var mocKConsole = new Mock<IOutputWriter>();           
            var consoleWriter= new ConsoleWriter();
            consoleWriter.Console = mocKConsole.Object;
            
            // Act
            consoleWriter.Console.WriteLine("Hello World");

            // Assert
            mocKConsole.Verify(console => console.WriteLine("Hello World"));     
           

        }
    }
}

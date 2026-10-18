using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Tests
{
    public class GreetingServiceTests
    {
        [Fact]
        public void GetMessage_ReturnsHelloWorld()
        {
            var service = new GreetingService();

            var result = service.GetMessage();

            Assert.Equal("Hello, Prashant!", result);
        }
    }
}

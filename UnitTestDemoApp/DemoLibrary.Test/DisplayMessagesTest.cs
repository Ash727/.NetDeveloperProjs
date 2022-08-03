using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Test
{
    public class DisplayMessagesTest
    {
        [Fact]
        public void GreetingShouldReturnGoodMorningMessage()
        {
            // Arrange 
            DisplayMessages displayMessages = new DisplayMessages();
            
            // Act 
            var actual =displayMessages.Greeting("Ash", 2);
            var expted = $"Good Morning Ash";

            // Assert 
            Assert.Equal(expted, actual);

        }

        [Fact]
        public void GreetingShouldReturnGoodAfternoon()
        {
            // Arrange 
            DisplayMessages displayMessages = new DisplayMessages();

            // Act 
            var actual = displayMessages.Greeting("Ash", 13);
            var expted = $"Good Afternoon Ash";

            // Assert 
            Assert.Equal(expted, actual);

        }


        [Theory]
        [InlineData("John", "Good Morning John", 0)]
        public void GreetingShouldReturnSpecificGoodMorningMessage(
            string firstName,
            string expected,
            int timeOfDay)
        {
            DisplayMessages displayMessage = new DisplayMessages();
            var actual = displayMessage.Greeting(firstName, timeOfDay);
            //  var expected = $"Good Morning {firstName}";
            Assert.Equal(expected, actual);

        }
    }
}

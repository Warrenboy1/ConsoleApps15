using ConsoleAppProject.App04;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp.Test
{
    [TestClass]
    public class TestNewsFeed
    {

        [TestMethod]
        public void AddMessage()
        {
            // Arrange
            NetworkApp App04 = new NetworkApp();
       
            MessagePost post = new MessagePost("Warren", "Cats are the Best. :D");
            post.Display();

            // Act
            string expectedMessage = "Cats are the Best. :D";

            // Assert
            Assert.AreEqual(expectedMessage, post.Message);
        }

        public void AddPhoto()
        {
            // Arrange
            NetworkApp App04 = new NetworkApp();

            MessagePost post = new MessagePost("Warren", "Cats are the Best. :D");
            post.Display();

            // Act
            string expectedMessage = "Cats are the Best. :D";

            // Assert
            Assert.AreEqual(expectedMessage, post.Message);
        }

    }
}

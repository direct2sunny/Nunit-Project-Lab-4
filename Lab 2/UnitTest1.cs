using NUnit.Framework;
namespace NUnitDemonstration.Tests
{
    [TestFixture]
    public class TriangleTests
    {

        //Test1
        [Test]
        public void ValidTriangle_ValidInput_ReturnsValidMessage()
        {
            // Arrange
            int firstAngle = 50;
            int secondAngle = 60;
            int thirdAngle = 60;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }

        //Test2
        [Test]
        public void ValidTriangle_InvalidInput_ReturnsInvalidMessage()
        {
            int firstAngle = 70;
            int secondAngle = 50;
            int thirdAngle = 60;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }
        // Test3
        // Add more test methods as needed to cover different scenarios
        [Test]
        public void ValidTriangle_EqualInput_ReturnsInvalidMessage2()
        {
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 60;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }

        //Test4
        // Add more test methods as needed to cover different scenarios
        [Test]
        public void ValidTriangletwo_InvalidInput_ReturnsInvalidMessage2()
        {
            int firstAngle = 30;
            int secondAngle = 30;
            int thirdAngle = 120;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }

        //Test5
        // Add more test methods as needed to cover different scenarios
        [Test]
        public void ValidTrianglethree_InvalidInput_ReturnsInvalidMessage2()
        {
            int firstAngle = 0;
            int secondAngle = 80;
            int thirdAngle = 120;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);
        }

        //Test6
        // Add more test methods as needed to cover different scenarios
        [Test]
        public void ValidTrianglefour_InvalidInput_ReturnsInvalidMessage2()
        {
            int firstAngle = 0;
            int secondAngle = 60;
            int thirdAngle = 120;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);
        }

        //Test7
        [Test]
        public void AllZeroAngles_InvalidInput_ReturnsInvalidMessage()
        {
            int firstAngle = 0;
            int secondAngle = 0;
            int thirdAngle = 0;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);
        }

        // Add more test methods following a similar structure for other scenarios.

    }
}
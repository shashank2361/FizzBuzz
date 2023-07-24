using FizzBuzz.Service;

namespace FizzBuzz.Test
{
    [TestClass]
    public class FizzBuzzServiceTests
    {

        private IFizzBuzzService fizzBuzzService;

        [TestInitialize]
        public void Initialize()
        {
            fizzBuzzService = new FizzBuzzService();
        }


        [TestMethod]
        public void GetFizzBuzz_ShouldReturnFizz_WhenNumberIsDivisibleBy3()
        {
            // Arrange
            int number = 9;

            // Act
            string result = fizzBuzzService.GetFizzBuzz(number);

            // Assert
            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void GetFizzBuzz_ShouldReturnBuzz_WhenNumberIsDivisibleBy5()
        {
            // Arrange
            int number = 10;

            // Act
            string result = fizzBuzzService.GetFizzBuzz(number);

            // Assert
            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void GetFizzBuzz_ShouldReturnFizzBuzz_WhenNumberIsDivisibleByBoth3And5()
        {
            // Arrange
            int number = 15;

            // Act
            string result = fizzBuzzService.GetFizzBuzz(number);

            // Assert
            Assert.AreEqual("FizzBuzz", result);
        }

        [TestMethod]
        public void GetFizzBuzz_ShouldReturnNumber_WhenNumberIsNotDivisibleBy3Or5()
        {
            // Arrange
            int number = 7;

            // Act
            string result = fizzBuzzService.GetFizzBuzz(number);

            // Assert
            Assert.AreEqual(number.ToString(), result);
        }

        [TestMethod]
        public void GetFizzBuzz_ShouldReturnFizz_WhenNumberIsZero()
        {
            // Arrange
            int number = 0;

            // Act
            string result = fizzBuzzService.GetFizzBuzz(number);

            // Assert
            Assert.AreEqual("FizzBuzz", result);
        }

        [TestMethod]
        public void GetFizzBuzz_ShouldReturnBuzz_WhenNumberIsNegativeAndDivisibleBy5()
        {
            // Arrange
            int number = -10;

            // Act
            string result = fizzBuzzService.GetFizzBuzz(number);

            // Assert
            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void GetFizzBuzz_ShouldReturnFizzBuzz_WhenNumberIsNegativeAndDivisibleByBoth3And5()
        {
            // Arrange
            int number = -15;

            // Act
            string result = fizzBuzzService.GetFizzBuzz(number);

            // Assert
            Assert.AreEqual("FizzBuzz", result);
        }

        [TestMethod]
        public void GetFizzBuzz_ShouldReturnNumber_WhenNumberIsNegativeAndNotDivisibleBy3Or5()
        {
            // Arrange
            int number = -7;

            // Act
            string result = fizzBuzzService.GetFizzBuzz(number);

            // Assert
            Assert.AreEqual(number.ToString(), result);
        }

        [TestMethod]
        public void GetFizzBuzz_ShouldReturnNumber_WhenNumberIsIntMaxValue()
        {
            // Arrange
            int number = int.MaxValue;

            // Act
            string result = fizzBuzzService.GetFizzBuzz(number);

            // Assert
            Assert.AreEqual(number.ToString(), result);
        }

        [TestMethod]
        public void GetFizzBuzz_ShouldReturnFizzBuzz_WhenNumberIsIntMinValue()
        {
            // Arrange
            int number = int.MinValue;

            // Act
            string result = fizzBuzzService.GetFizzBuzz(number);

            // Assert
            Assert.AreEqual(number.ToString(), result);
        }

        [TestMethod]
        public void GetFizzBuzz_ShouldReturnFizzBuzz_WhenNumberIsIntMaxValue()
        {
            // Arrange
            int number = int.MaxValue;

            // Act
            string result = fizzBuzzService.GetFizzBuzz(number);

            // Assert
            Assert.AreEqual(number.ToString(), result);
        }


    }
}
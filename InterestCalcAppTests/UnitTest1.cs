using InterestCalcApp;

namespace InterestCalcApp.Tests
{

    public class InterestCalcTests
    {
        private readonly InterestCalc app;

        public InterestCalcTests()
        {
            app = new InterestCalc()
            {
                principle = 200,
                interest = 13,
                length = 5
            };
        }

        [Fact]
        public void Prompt_GetsDataBack()
        {
            string expectedInput = "100";
            var inputStream = new StringReader(expectedInput);
            Console.SetIn(inputStream);
            int actualInput = InterestCalc.Prompt("principle");
            Assert.Equal(int.Parse(expectedInput), actualInput);
        }

        [Theory]
        [InlineData("100", 100)]
        public void Validate_ValidInput_ReturnsInt(string userInput, int expected)
        {
            int result = InterestCalc.Validate(userInput);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("abc")]
        [InlineData("")]
        [InlineData(null)]
        public void Validate_InvalidInput_ThrowsArgumentException(string userInput)
        {
            Assert.Throws<ArgumentException>(() => InterestCalc.Validate(userInput));
        }


        [Fact]
        public void FindTotal()
        {
            Assert.Equal(200 + (200 * 13 / 100 * 5), app.Calculate());
        }

        [Fact]
        public void FindCompound()
        {
            Assert.Equal(200 * 13 / 100 * 5, app.CompoundInterest());
        }
    }
}
 
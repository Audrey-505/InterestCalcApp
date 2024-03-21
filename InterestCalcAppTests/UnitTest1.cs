using InterestCalcApp;

namespace InterestCalcApp.Tests
{

    public class InterestCalcTests
    {
        private readonly InterestCalc app;

        public InterestCalcTests()
        {
            app = new InterestCalc();
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
        [InlineData("abc", 0)]
        [InlineData("", 0)]
        [InlineData(null, 0)]
        public void Validate_CheckNotNullAndInt(string userInput, int expected)
        {
            int result = InterestCalc.Validate(userInput);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void FindTotal()
        {
            InterestCalc app = new()
            {
                principle = 200,
                interest = 13,
                length = 5
            };
            Assert.Equal(200 + (200 * 13 / 100 * 5), app.Calculate());
        }

        [Fact]
        public void FindCompound()
        {
            InterestCalc app = new()
            {
                principle = 200,
                interest = 13,
                length = 5
            };
            Assert.Equal(200 * 13 / 100 * 5, app.CompoundInterest());
        }
    }
}
 
using ConsoleApp1;

namespace FizzBuzzTest
{
    public class FizzBuzz
    {
        private readonly FizzBuzzService fizzBuzzService;
        public FizzBuzz()
        {
            fizzBuzzService = new FizzBuzzService();
        }
       [Theory]
        [InlineData(1,"1")]
        public void Should_Chck_divisbleby3(int input,string expected)
        {
            var result = fizzBuzzService.GetValue(input);

            Assert.Equal(expected, result);
        }
    }
}
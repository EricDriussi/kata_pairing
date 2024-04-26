using FizzBuzzTests.Helpers;
using System.Net;
using Xunit;

namespace FizzBuzzTests
{
    public class FizzBuzzNumberControllerTests
    {
        private readonly CustomApplicationFactory _webApp;

        public FizzBuzzNumberControllerTests()
        {
            _webApp ??= new CustomApplicationFactory();
        }

        [Fact]
        public async Task GetFizzBuzzNumber_Should_Api_Return_OK_When_Number_is_1()
        {
            var number = 1;

            var result = await _webApp.GetHttpClient().GetAsync($"fizzbuzznumber/{number}");

            Assert.Equal(HttpStatusCode.OK, result.StatusCode);
        }
    }
}

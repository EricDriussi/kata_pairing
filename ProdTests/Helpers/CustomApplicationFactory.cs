using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;

namespace FizzBuzzTests.Helpers
{
    public class CustomApplicationFactory : WebApplicationFactory<Program>
    {
        internal HttpClient _api;

        public CustomApplicationFactory()
        {
            _api ??= CreateClient();
        }

        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            base.ConfigureWebHost(builder);
        }

        public HttpClient GetHttpClient()
        {
            return _api;
        }
    }
}

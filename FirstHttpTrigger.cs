using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public class FirstHttpTrigger
    {
        private readonly ILogger<FirstHttpTrigger> _logger;

        public FirstHttpTrigger(ILogger<FirstHttpTrigger> logger)
        {
            _logger = logger;
        }

        [Function("FirstHttpTrigger")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions from test Devops! 1.0");
        }
    }
}

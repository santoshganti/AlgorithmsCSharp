using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using System.Net;

namespace LeetCode.Graph.DFS
{
    public class DFSRecursive
    {
        private readonly ILogger _logger;

        public DFSRecursive(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<DFSRecursive>();
        }

        [Function("DFSRecursive")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequestData req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

            response.WriteString("Welcome to Azure Functions!");

            return response;
        }
    }
}

using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;

namespace FunctionApp;

public class Function1
{
  [FunctionName("Function1")]
  public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req)
  {
    var arr = new int[] { 1, 2, 3 };
    var maxValue = arr.Max();
    return new OkObjectResult(maxValue);
  }
}

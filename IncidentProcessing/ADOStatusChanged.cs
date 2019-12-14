using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;

namespace IncidentProcessing
{
    public static class ADOStatusChanged
    {
        [FunctionName("ADOStatusChanged")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
			string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
			//Rootobject ro = JsonConvert.DeserializeObject<Rootobject>(requestBody);
			
			int i = 1;
			/*
			string history = data?.Status;

			try
			{
				var personalaccesstoken = "pljc56ash6y54dkojtrpsxs2medr7b5uhi3oqd7atqs3tytyhpoq";

				using (HttpClient client = new HttpClient())
				{
					client.DefaultRequestHeaders.Accept.Add(
						new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

					client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
						Convert.ToBase64String(
							System.Text.ASCIIEncoding.ASCII.GetBytes(
								string.Format("{0}:{1}", "", personalaccesstoken))));
					HttpContent content = 
						client.Patch

					using (HttpResponseMessage response = await client.PatchAsync(
								"https://dev.azure.com/{organization}/_apis/projects"))
					{
						response.EnsureSuccessStatusCode();
						string responseBody = await response.Content.ReadAsStringAsync();
						Console.WriteLine(responseBody);
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
			*/
			return (ActionResult)new OkObjectResult($"Hello");
        }
    }
}

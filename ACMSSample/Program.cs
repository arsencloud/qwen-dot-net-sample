using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace ACMSSample
{
    class Program
    {
        static void Main(string[] args)
        {

            // Please refer to this article to generate your own API Key
            // https://www.alibabacloud.com/help/en/model-studio/developer-reference/get-api-key

            string apiKey = "CHANGE YOUR DASHSCOPE API KEY HERE";
            var qwen = new QWEN();

            while (true)
            {
                try
                {
                    Console.WriteLine("Hi, my name is QWEN. Please type your query here");
                    string msg = Console.ReadLine();
                    var result = qwen.SendRequestToQwen(apiKey, msg);
                    var responseContent = result.Result;
                    Console.WriteLine(responseContent);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }
    }

    class QWEN
    {
        private readonly RestClient client;

        public QWEN()
        {
            client = new RestClient("https://dashscope-intl.aliyuncs.com");
        }

        public async Task<string> SendRequestToQwen(string apiKey, string message)
        {
            // For more information on the API endpoint and request body:
            // https://www.alibabacloud.com/help/en/model-studio/developer-reference/qwen-model-api-details?spm=a2c63.p38356.0.0.602d74a1V5taaR
            // Find the section "Sample requests with SSE disabled" on the article above

            var request = new RestRequest("/api/v1/services/aigc/text-generation/generation", Method.Post);
            request.AddHeader("Authorization", $"Bearer {apiKey}");
            request.AddHeader("Content-Type", "application/json");

            var requestBody = new
            {
                model = "qwen-turbo", //Valid values: qwen-turbo, qwen-plus, qwen-max, qwen-max-0403, qwen-max-0107, qwen-max-1201, and qwen-max-longcontext.
                input = new
                {
                    messages = new[]
                    {
                        new {role = "user", content = message}
                    }
                },
                parameters = new
                {
                    result_format = "message" // Valid values: message, text (by default)
                }
            };

            var json = JsonConvert.SerializeObject(requestBody);
            request.AddParameter("application/json", json, ParameterType.RequestBody);
            var response = await client.ExecuteAsync(request);

            if (!response.IsSuccessful)
            {
                Console.WriteLine("Error when trying to send request to QWEN");
                throw new Exception("Error Occurred when sending request to qwen");
            }

            return response.Content;
        }
    }
}

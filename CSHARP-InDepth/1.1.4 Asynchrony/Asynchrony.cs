using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CSHARP_InDepth._1._1._4
{
    class Asynchrony
    {
        static HttpClient client = new HttpClient();
        public void MainInitializerAsync()
        {
            AsynchronyExampleAsync();
        }
        public void AsynchronyExampleAsync()
        {
            var result = GetTodoAsync();
            Console.WriteLine(result.Result);
        }

        public async Task<object> GetTodoAsync()
        {
            string url = "https://jsonplaceholder.typicode.com/todos/1";
            try
            {
                //var content = new StringContent(jsonObject.ToString(), Encoding.UTF8, "application/json");
                var response = await client.GetAsync(url);
                if (response != null)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<object>(jsonString);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return null;
        }
    }
}

class Weather
{
    public string day { get; set; }
    public int temperature { get; set; }
}

class EmailStatus
{
    public string status { get; set; }
}

class Todo
{
    public int userId { get; set; }
    public int id { get; set; }
    public string title { get; set; }
    public bool completed { get; set; }
}
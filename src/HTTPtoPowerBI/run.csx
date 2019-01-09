using System.Net;
using System.Net.Http;
using System.Threading.Tasks; 

private static readonly string connString = ConfigurationManager.AppSettings["connString"];

public static async void Run(HttpRequestMessage req, TraceWriter log)
{
    HttpClient client = new HttpClient();
    dynamic data = await req.Content.ReadAsAsync<object>();
    HttpContent content = new StringContent("[" + data + "]");
    HttpResponseMessage response = await client.PostAsync(connString, content);
    response.EnsureSuccessStatusCode();
}

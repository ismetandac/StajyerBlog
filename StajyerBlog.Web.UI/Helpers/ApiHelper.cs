
using Newtonsoft.Json;
using RestSharp;
using System.Text.Json.Serialization;

namespace StajyerBlog.Web.UI.Helpers
{
    public static class ApiHelper
    {
        static string BaseUrl = "http://localhost:5053/";

        static RestClient Client;
        static ApiHelper()
        {
            Client = new RestClient(BaseUrl);
        }

        public static T Post<T>(string url, object entity)
            where T : class, new()
        {
            var request = new RestRequest(url, Method.Post);
            request.AddJsonBody(entity);
            var response = Client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var data = JsonConvert.DeserializeObject<T>(response.Content);
                return data;
            }
            return null;
        }

        public static void Get()
        {

        }
    }
}

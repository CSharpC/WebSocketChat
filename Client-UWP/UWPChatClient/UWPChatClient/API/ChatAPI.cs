using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using UWPChatClient.Models;
using UWPChatClient.ViewModels;

namespace UWPChatClient.API
{
    public class ChatAPI
    {
        private static string BaseURL = "http://localhost:25565/";
        private static HttpClient Http { get { return new HttpClient() { BaseAddress = new Uri(BaseURL) }; } }

        public async static Task<Channel[]> ListChannels(User u)
        {
            using (var h = Http)
            using (var res = await h.GetAsync("channels/list", new StringContent(body, Encoding.UTF8, "application/json")))
            {
                return JArray.Parse(await res.Content.ReadAsStringAsync()).ToObject<Channel[]>();
            }
        }
    }
}

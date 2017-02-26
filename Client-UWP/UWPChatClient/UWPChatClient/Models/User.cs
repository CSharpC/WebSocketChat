using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPChatClient.Models
{
    public class User
    {
        public User() { }
        public User(string name)
        {
            Name = name;
            Id = Guid.NewGuid();
        }
        [JsonProperty("id")]
        public Guid Id { get; set; }
        [JsonProperty("nickname")]
        public string Name { get; set; }
    }
}

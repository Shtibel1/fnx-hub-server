using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BL.Models
{
    public class RepositoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Owner Owner { get; set; }
    }
    
    public class Owner
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }
        [JsonProperty("login")]
        public string Name { get; set; }
    }
}

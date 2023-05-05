using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Models
{
    public class AuthForm
    {
        [JsonProperty("username")]
        [Required]
        public string UserName { get; set; }
        [JsonProperty("password")]
        [Required]
        public string Password { get; set; }
    }
}

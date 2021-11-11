using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FrontEnd.Models
{
    public class Settings
    {
        [JsonPropertyName("id")]
        public int Id { set; get; }

        [JsonPropertyName("width")]
        public int Width { set; get; }

        [JsonPropertyName("height")]
        public int Height { set; get; }

    }
}

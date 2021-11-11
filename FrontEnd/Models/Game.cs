using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FrontEnd.Models
{
    public class Game
    {
        [JsonPropertyName("settings")]
        public Settings Settings { get; set; }

        [JsonPropertyName("board")]
        public List<List<Boolean>> Board { get; set; }

    }
}

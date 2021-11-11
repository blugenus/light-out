using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAPI.Models
{
    public class Game
    {
        public Settings Settings { get; set; }

        public List<List<Boolean>> Board { get; set; }

    }
}

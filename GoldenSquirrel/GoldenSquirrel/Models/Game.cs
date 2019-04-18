using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoldenSquirrel.Models
{
    public class Game
    {
        public int Number { get; set; } //Number associated to picture to see if numbers match in each row or not

        public string Image { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.MVC.Models
{
    public class PokemonView
    {
        public string name { get; set; }
        public int order { get; set; }

        public SpritesView sprites { get; set; }

        public PokemonView() { }
    }
}
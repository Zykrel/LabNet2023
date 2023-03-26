using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.MVC.Models
{
    public class PokemonListView
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }



        public List<PokemonResultView> results { get; set; } 
        public PokemonListView() { }
    }
}
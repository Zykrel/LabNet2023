using Lab.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Lab.MVC.Controllers
{
    public class PokeApiController : Controller
    {
        // GET: PokeApi
        private HttpClient client = new HttpClient();
        public async Task<ActionResult> Index(string url= "https://pokeapi.co/api/v2/pokemon/")
        {
           PokemonListView pokemonList = null;
           HttpResponseMessage httpResponseMessage = await client.GetAsync(url);

            

            if(httpResponseMessage.IsSuccessStatusCode) 
            {
                var response = await httpResponseMessage.Content.ReadAsStringAsync();
                pokemonList = Newtonsoft.Json.JsonConvert.DeserializeObject<PokemonListView>(response);
            }

            return View(pokemonList);
        }

        public async Task<ActionResult> Detalles(string url)
        {
            PokemonView pokemonView = null;

            HttpResponseMessage httpResponseMessage= await client.GetAsync(url);
            if(httpResponseMessage.IsSuccessStatusCode)
            {
                var reponse = await httpResponseMessage.Content.ReadAsStringAsync();
                pokemonView = Newtonsoft.Json.JsonConvert.DeserializeObject<PokemonView>(reponse);

            }
            return View(pokemonView);
        }
    }
}
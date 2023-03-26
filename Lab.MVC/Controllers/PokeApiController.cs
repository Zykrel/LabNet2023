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
        public async Task<ActionResult> Index()
        {

           PokemonListView pokemonList = null;
           HttpResponseMessage httpResponseMessage = await client.GetAsync("https://pokeapi.co/api/v2/pokemon/");

            

            if(httpResponseMessage.IsSuccessStatusCode) 
            {
                var response = await httpResponseMessage.Content.ReadAsStringAsync();
                pokemonList = Newtonsoft.Json.JsonConvert.DeserializeObject<PokemonListView>(response);
            }

            return View(pokemonList);
        }

        public async Task<ActionResult> Detalles(string url)
        {
            //Incializar Pokemon (clase que vas a crear)
            //Pegarle a la URL
            //verificar StatusCode
            //llenar objetio pokemon con la respuesta
            //retornar view con el (pokemon)
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
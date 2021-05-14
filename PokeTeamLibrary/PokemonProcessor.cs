using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Formatting;

namespace PokeTeamLibrary
{
    public class PokemonProcessor
    {
        public static async Task<PokemonModel> LoadPokemon(int pokemonId = 0)
        {
            string url = "";

            if (pokemonId > 0)
            {
                url = $"https://pokeapi.co/api/v2/pokemon/{ pokemonId }/";
            }
            else
            {
                url = "https://pokeapi.co/api/v2/pokemon/";
            }

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    PokemonModel pokemon = await response.Content.ReadAsAsync<PokemonModel>();

                    return pokemon;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}

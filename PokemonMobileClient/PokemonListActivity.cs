using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;
using PokemonMobileClient.Adapters;
using PokemonMobileClient.DTO;
using System.Threading.Tasks;

namespace PokemonMobileClient
{
    [Activity(Label = "Pokedex")]
    public class PokemonListActivity : Activity
    {

        private List<PokemonDTO> allPokemon;
        private bool canPressButtons = false;
        private ListView pokemonListActivityListView;


        public PokemonListActivity()
        {
            
        }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            
            base.OnCreate(savedInstanceState);


            RetrieveDataAsync();

        }

        private void SetBoilerPlate()
        {
            

            SetContentView(Resource.Layout.PokemonListActivityView);
            FindViews();

            pokemonListActivityListView.Adapter = new PokemonListAdapter(this, allPokemon);
            pokemonListActivityListView.FastScrollEnabled = true;
        }

        private void FindViews()
        {
            pokemonListActivityListView = FindViewById<ListView>(Resource.Id.pokemonListActivityListView);
        }

        private async void RetrieveDataAsync()
        {
            string dataUri = "http://pokemonapp6359.azurewebsites.net/Pkmn/GetAllPokemon";
            using (var httpClient = new HttpClient())
            {
                var uri = new Uri(string.Format(dataUri, string.Empty));

                var response = await httpClient.GetAsync(uri);
                
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    allPokemon = JsonConvert.DeserializeObject<List<PokemonDTO>>(content);
                    SetBoilerPlate();
                    canPressButtons = true; //fix this when implement local db
                    //create toast

                    Utilities.Utilities.ShowToast(this, "Successfully fetched data", ToastLength.Long);
                }
                else
                {
                    Utilities.Utilities.ShowToast(this, "Failed to fetch data", ToastLength.Short);
                }

            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using PokemonAppCore.DTO;
using PokemonAppCore.Service;

namespace PokemonMobileClient
{
    [Activity(Label = "TestListActivity")]
    public class TestListActivity : Activity
    {
        private List<PokemonDto> allPokemon;
        private ListView pokemonListView;
        private PokemonService _pokeService;

        public TestListActivity()
        {
            //_pokeService = new PokemonService();
        }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ListPokemonView);
            _pokeService = new PokemonService();
            // Create your application here
        }
    }
}
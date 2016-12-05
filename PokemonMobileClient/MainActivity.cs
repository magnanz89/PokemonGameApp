using System;
using System.Collections.Generic;
using System.Net.Http;
using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.Widget;
using Android.OS;
using Newtonsoft.Json;
using PokemonMobileClient.DTO;

namespace PokemonMobileClient
{
    [Activity(Label = "Pokedex 2016", MainLauncher = true, Icon = "@drawable/pokedex")]
    public class MainActivity : Activity
    {
        private Button allPokemonButton;
        private Button aboutButton;
        

        public MainActivity()
        {
            //RetrieveDataAsync();
            Console.WriteLine();
            

        }

        

        

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            //int idOfIcon = Resource.Drawable.IconFromName("bulbasauricon");
            //var iconBitmap = Utilities.Utilities.GetImageBitmapFromLocal(this, idOfIcon);
            FindViews();
            HandleEvents();
            

        }

        private void HandleEvents()
        {
            allPokemonButton.Click += AllPokemonButton_Click;
            aboutButton.Click += AboutButtonOnClick;
        }

        private void AboutButtonOnClick(object sender, EventArgs eventArgs)
        {
            
            var intent = new Intent(this, typeof (ContactActivity));
            StartActivity(intent);
            
            
        }

        private void AllPokemonButton_Click(object sender, EventArgs e)
        {
            
            var intent = new Intent(this, typeof(PokemonListActivity));
            //intent.
            StartActivity(intent);
            

        }

        private void FindViews()
        {
            allPokemonButton = FindViewById<Button>(Resource.Id.mainAllPokemonButton);
            aboutButton = FindViewById<Button>(Resource.Id.mainAboutButton);
        }
    }
}


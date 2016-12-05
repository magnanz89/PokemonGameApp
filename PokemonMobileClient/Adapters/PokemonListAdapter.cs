using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Text.Style;
using Android.Views;
using Android.Widget;
using PokemonMobileClient.DTO;
using PokemonMobileClient.Model;

namespace PokemonMobileClient.Adapters
{
    public class PokemonListAdapter : BaseAdapter<PokemonDTO>
    {
        private Activity _context;
        private List<PokemonDTO> _allPokemon;

        public PokemonListAdapter(Activity context, List<PokemonDTO> allPokemon) : base()
        {
            this._context = context;
            this._allPokemon = allPokemon;
        }
        

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = _allPokemon[position];

            string nameOfIcon = item.Name.ToLower() + "icon";
            int idOfIcon = Resource.Drawable.IconFromName(nameOfIcon);
            var iconBitmap = Utilities.Utilities.GetImageBitmapFromLocal(_context, idOfIcon);




            if (convertView == null)
            {
                convertView = _context.LayoutInflater.Inflate(Resource.Layout.PokemonRowView, null);
            }

            //convertView.FindViewById<TextView>(Android.Resource.Id.Text1).Text = item.Name;
            convertView.FindViewById<TextView>(Resource.Id.pokemonRowTextView).Text = item.Name;
            convertView.FindViewById<ImageView>(Resource.Id.pokemonIconImageView).SetImageBitmap(iconBitmap);

            convertView.FindViewById<TextView>(Resource.Id.pokemonTypeRowView).Text = "Moves: "; //so it doesnt recycle text from recycled view

            AddMovesToRow(item.Moves, convertView);
            
            
            return convertView;
        }

        private void AddMovesToRow(ICollection<PokemonMove> moves, View convertView)
        {
            //add moves
            for (int i = 0; i < moves.Count; i++)
            {
                if (i == moves.Count || i >= 4)
                {

                }
                else if (i == 0)
                {

                }
                else
                {
                    convertView.FindViewById<TextView>(Resource.Id.pokemonTypeRowView).Text += ", ";
                }
                if (i >= 4)
                {
                    convertView.FindViewById<TextView>(Resource.Id.pokemonTypeRowView).Text += "...";
                    break;
                }
                var currentMove = moves.ElementAt(i).Name;
                convertView.FindViewById<TextView>(Resource.Id.pokemonTypeRowView).SetTextColor(Color.Black);
                convertView.FindViewById<TextView>(Resource.Id.pokemonTypeRowView).Text += currentMove;


            }
        }

        public override int Count { get { return _allPokemon.Count; } }

        public override PokemonDTO this[int position]
        {
            get { return _allPokemon[position]; }
        }

        
    }
}
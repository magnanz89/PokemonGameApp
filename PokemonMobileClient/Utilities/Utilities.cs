using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Media;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace PokemonMobileClient.Utilities
{
    public class Utilities
    {
        public static void ShowToast(Android.Content.Context context, string message, ToastLength length)
        {
            Toast toast = Toast.MakeText(context, message, length);
            toast.SetGravity(GravityFlags.Center, 0, 0);
            toast.Show();
        }

        public static Bitmap GetImageBitmapFromUrl(string url)
        {
            Bitmap imageBitmap = null;

            using (var webClient = new WebClient())
            {
                var imageBytes = webClient.DownloadData(url);
                if (imageBytes != null && imageBytes.Length > 0)
                {
                    imageBitmap = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
                }
            }

            return imageBitmap;
        }

        public static Bitmap GetImageBitmapFromLocal(Activity context, int iconId)
        {
            Bitmap icon = BitmapFactory.DecodeResource(context.Resources, iconId);
            Console.WriteLine();
            return icon;

        }
    }
}
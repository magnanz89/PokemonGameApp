using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace PokemonMobileClient
{
    public partial class Resource
    {


        public partial class Drawable
        {
            public static int IconFromName(string name)
            {
                Type type = typeof(Resource.Drawable);
                FieldInfo info = type.GetField(name);
                object value = info.GetValue(null);

                return (int)value;
            }
        }
    }
}
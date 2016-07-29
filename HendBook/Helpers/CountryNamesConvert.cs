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

namespace HendBook.Helpers
{
   static class CountryNamesConvert
    {
        public static int ConvertCountry(string Name)
        {
            int country = Resource.Drawable.Icon;

            switch (Name)
            {
                case "ja":  country = Resource.Drawable.Japan; break;
                case "uk": country = Resource.Drawable.England; break;
                case "us": country = Resource.Drawable.USA; break;
                case "ch": country = Resource.Drawable.China; break;

            }

            return country;
        }

    }
}
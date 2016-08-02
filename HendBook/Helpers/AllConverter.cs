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
   static class AllConverter
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
        public static int ConvertForce(clientapi.instaforex.com.Calendar.Importance imp)
        {
            int country = 0;

            switch (imp)
            {
                case clientapi.instaforex.com.Calendar.Importance.High: country = Resource.Drawable.force3; break;
                case clientapi.instaforex.com.Calendar.Importance.Medium: country = Resource.Drawable.force2; break;
                case clientapi.instaforex.com.Calendar.Importance.Low: country = Resource.Drawable.force1; break;
             

            }

            return country;
            
        }
    }

}
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

namespace HendBook.Model
{
   public class EventsViewModel
    {
        public int Id { get; set; }
        public string ShortText { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }

        public string Country { get; set; }
        public string Actual { get; set; }
        public clientapi.instaforex.com.Calendar.Importance Posible { get; set; }
    }
}
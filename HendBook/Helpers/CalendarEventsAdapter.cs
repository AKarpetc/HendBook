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
using Android.Support.Design.Widget;
using HendBook.Model;

namespace HendBook.Helpers
{
    public class HomeScreenAdapter : BaseAdapter<EventsViewModel>
    {
        List<EventsViewModel> items;
        Activity context;
        public HomeScreenAdapter(Activity context, List<EventsViewModel> items)
            : base()
        {
            this.context = context;
            this.items = items;
        }
        public override long GetItemId(int position)
        {
            return position;
        }
        public override EventsViewModel this[int position]
        {
            get { return items[position]; }
        }
        public override int Count
        {
            get { return items.Count; }
        }
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = items[position];
            View view = convertView;
            if (view == null) // no view to re-use, create new
                view = context.LayoutInflater.Inflate(Resource.Layout.EconomicalEventRow, null);
            view.FindViewById<TextView>(Resource.Id.eventName).Text = item.ShortText;
            view.FindViewById<TextView>(Resource.Id.eventDate).Text = item.Date.ToShortTimeString();
           // view.FindViewById<ImageView>(Resource.Id.Image).SetImageResource(item.ImageResourceId);
            return view;
        }
    }
  
}
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
using HendBook.Model;
using Newtonsoft.Json;

namespace HendBook.Modules
{
    public  interface ILoadData
    {
         List<EventsViewModel> LoadEvents(List<clientapi.instaforex.com.Calendar.Event> events);

    }
  
    class  EconomicalEvents: ILoadData
    {
        private static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }
        private static DateTime JavaTimeStampToDateTime(double javaTimeStamp)
        {
            // Java timestamp is millisecods past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(Math.Round(javaTimeStamp / 1000)).ToLocalTime();
            return dtDateTime;
        }
        public List<EventsViewModel> LoadEvents(List<clientapi.instaforex.com.Calendar.Event> events)
        {

            var Events = events.Select(x => new EventsViewModel { Id=x.Id,  ShortText = x.Name,
                Date = UnixTimeStampToDateTime(x.ReleaseTimestamp),Text=x.Description, Country=x.Country, Posible=x.Importance, Actual=x.Actual

            }).ToList();

       
            return Events;
        }

    }
}
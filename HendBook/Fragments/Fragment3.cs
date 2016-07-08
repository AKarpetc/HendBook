using SupportFragment = Android.Support.V4.App.Fragment;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Webkit;

namespace HendBook.Fragments
{
    public class Fragment3 : SupportFragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }
        WebView calendarAPi;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.Fragment3, container, false);
            calendarAPi = view.FindViewById<WebView>(Resource.Id.calendarAPi);
            calendarAPi.Settings.JavaScriptEnabled = true;
            string htmlText = @"<html><body>
    <script type = 'text/javascript' >
         var fxcalendar_config = {      host: 'http://calendar.fxstreet.com',
        css: 'mini',
        rows: 20,
        pastevents: 5,
        hoursbefore: 20,        
        timezone: 'UTC',
        showcountryname: 'false',
        columns: 'date,time,country,event,volatility',
        isfree: 'true',
        countrycode: 'AU,CA,JP,EMU,NZ,CH,UK,US',
        culture: 'ru-RU'
     };
    </script>
    <script type = 'text/javascript' src = 'http://calendar.fxstreet.com/scripts/mini'></script>
    <div id = 'fxst_calendar' style = 'width: 100%' ></div></body></html>";
            calendarAPi.LoadData(htmlText, "text/html", "en_US");
          //  calendarAPi.LoadUrl("http://developer.alexanderklimov.ru/android/");
            return view;
        }
    }
}
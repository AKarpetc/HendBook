using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SupportFragment = Android.Support.V4.App.Fragment;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using HendBook.Modules;
using System.ServiceModel;
using clientapi.instaforex.com.Calendar;

namespace HendBook.Fragments
{
    public class EconomicalCalendar : SupportFragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

        }
        private static BasicHttpBinding CreateBasicHttp()
        {
            BasicHttpBinding binding = new BasicHttpBinding
            {
                Name = "BasicHttpBinding",
                MaxReceivedMessageSize = 2147483647,
                Security = new BasicHttpSecurity { Mode = BasicHttpSecurityMode.Transport },
            };
            return binding;
        }
        public EndpointAddress EndPoint= new EndpointAddress("https://client-api.instaforex.org/soapservices/Calendar.svc/secure");
        CalendarServiceClient sc;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.EconomicalCalendar, container, false);

            BasicHttpBinding binding = CreateBasicHttp();


            
            try
            {
                sc = new CalendarServiceClient(binding, EndPoint);
                sc.GetCalendarCompleted += Sc_GetCalendarCompleted; ;
                sc.GetCalendarAsync(Lang.Ru, new Account { Login = 1370181, Password = "78Kap11" });
                                
            }
            catch (Exception ex)
            {
                sc.Close();
            }


            return view;
        }

        private void Sc_GetCalendarCompleted(object sender, GetCalendarCompletedEventArgs e)
        {
            var Events = e.Result.ToList();

            sc.Close();
        }
    }
}
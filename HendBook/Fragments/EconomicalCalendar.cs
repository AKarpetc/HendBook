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
using Android.Net;
using HendBook.Helpers;
using Android.Support.V7.Widget;
using HendBook.Model;
using static HendBook.Fragments.Fragment1;

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
       public RecyclerView view;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            view = inflater.Inflate(Resource.Layout.Fragment1, container, false) as RecyclerView;
            SetUpReciclerView(view);
            GetEvents();
           
            return view;
        }

        private void GetEvents()
        {

          
            ConnectivityManager connectivityManager = (ConnectivityManager)Activity.GetSystemService(MainActivity.ConnectivityService);
            NetworkInfo activeConnection = connectivityManager.ActiveNetworkInfo;
            bool isOnline = (activeConnection != null) && activeConnection.IsConnected;

            if (isOnline == false)
            {

            }
            else
            {

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
            }
        }
        private void Sc_GetCalendarCompleted(object sender, GetCalendarCompletedEventArgs e)
        {
            ILoadData ild = new EconomicalEvents();
           var EventsList= ild.LoadEvents(e.Result.ToList());
            using (var h = new Handler(Looper.MainLooper))
            {
                h.Post(() => 
                {
                    int start = ssa.ItemCount;
                    ssa.addItems(EventsList);
                    ssa.NotifyItemRangeInserted(start, ssa.ItemCount);

                });
            }
        }
        HomeScreenAdapter ssa;
        private void SetUpReciclerView(RecyclerView recyclerView)
        {
            var values = new List<string> {};
            recyclerView.SetLayoutManager(new LinearLayoutManager(recyclerView.Context));
            ssa = new HomeScreenAdapter(recyclerView.Context, new List<EventsViewModel>(), Activity.Resources);
            recyclerView.SetAdapter(ssa);
        }
        private List<string> GetRandomSubList(List<string> item, int amount)
        {

            List<string> list = new List<string>();
            Random random = new Random();
            while (list.Count < amount)
            {
                list.Add(item[random.Next(item.Count)]);
            }
            return list;
        }
        private void SetEvebtsView(RecyclerView recyclerView,List<EventsViewModel> values)
        {

          //  recyclerView.SetAdapter(new HomeScreenAdapter(recyclerView.Context, values, Activity.Resources));

        }
    }
}
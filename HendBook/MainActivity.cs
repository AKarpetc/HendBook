using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V4.Widget;
using SupportFragmentManager = Android.Support.V4.App.FragmentManager;
using SupportToolBar = Android.Support.V7.Widget.Toolbar;
using SupportFragment = Android.Support.V4.App.Fragment;
using SupportActionBar = Android.Support.V7.App.ActionBar;
using Android.Support.V7.App;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using static Android.Support.V7.Widget.ScrollingTabContainerView;
using Android.Support.V4.App;
using System.Collections.Generic;
using Java.Lang;
using HendBook.Fragments;
using Android.Net;

namespace HendBook
{
    [Activity(Label = "HendBook", MainLauncher = true, Icon = "@drawable/icon",Theme ="@style/Theme.DesignDemo")]
    public class MainActivity : AppCompatActivity
    {
        private DrawerLayout mDrawerLayout;
        ViewPager viewPager;
        TabLayout tabs;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
           
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            SupportToolBar toolBar = FindViewById<SupportToolBar>(Resource.Id.toolBar);
            SetSupportActionBar(toolBar);
            SupportActionBar ab = SupportActionBar;
            ab.SetHomeAsUpIndicator(Resource.Drawable.ic_menu);
            ab.SetDisplayHomeAsUpEnabled(true);
            mDrawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            NavigationView navigationVieew = FindViewById<NavigationView>(Resource.Id.nav_view);
            if (navigationVieew != null)
            {
                SetUpDrawerContent(navigationVieew);
            }
            tabs = FindViewById<TabLayout>(Resource.Id.tabs);
            viewPager = FindViewById<ViewPager>(Resource.Id.viewpager);
            SetUpViewPager();
            tabs.SetupWithViewPager(viewPager);
            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.Click += (o, e) =>
            {
                View anchor = o as View;
                Snackbar.Make(anchor, "Это всплывающее окно", Snackbar.LengthLong)
                .SetAction("Action", v =>
                {
                    // Intent intent = new Intent();
                }).Show();
            };
        }
        TabAdapter adapter;// = new TabAdapter(SupportFragmentManager);
        private void SetUpViewPager()
        {
            adapter = new TabAdapter(SupportFragmentManager);
            adapter.AddFragment(new EconomicalCalendar(), "Экономический Календарь");
            adapter.AddFragment(new Fragment1(), "Fragment 1");
            //  adapter.AddFragment(new Fragment2(), "Fragment 2");
            // adapter.AddFragment(new Fragment3(), "Fragment 3");

            viewPager.Adapter = adapter;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
           

            switch (item.ItemId)
            {
           
                case Android.Resource.Id.Home:
                    mDrawerLayout.OpenDrawer((int)GravityFlags.Left);
                    return true;
                //case Android.Resource.Id.d:
                //    {
                //        mDrawerLayout.OpenDrawer((int)GravityFlags.Left);

                //        Toast.MakeText(ApplicationContext, "Сообщение", ToastLength.Short).Show();
                //        return true;
                //    }
                default:return base.OnOptionsItemSelected(item);
            }
   

        }
        private void SetUpDrawerContent(NavigationView navigationVieew)
        {
            ConnectivityManager connectivityManager = (ConnectivityManager)GetSystemService(ConnectivityService);
            NetworkInfo activeConnection = connectivityManager.ActiveNetworkInfo;
            bool isOnline = (activeConnection != null) && activeConnection.IsConnected;

            navigationVieew.NavigationItemSelected += (object sender, NavigationView.NavigationItemSelectedEventArgs e) =>
            {
                // if(e.MenuItem==)
                var item = (e.MenuItem as IMenuItem);

                switch (item.ItemId)
                {
                    case Resource.Id.nav_home:
                        {
                            SupportFragmentManager.Fragments.Clear();
                            SetUpViewPager();
                            tabs.SetupWithViewPager(viewPager);
                            break;
                        }
                    case Resource.Id.nav_messages:
                        {
                            SupportFragmentManager.Fragments.Clear();
                            adapter = new TabAdapter(SupportFragmentManager);
                            adapter.AddFragment(new Fragment2(), "Фагмент2");
                            viewPager.Adapter = adapter;
                            tabs.SetupWithViewPager(viewPager);
                            break;
                        }
                    case Resource.Id.economicalcalendar:
                        {
                            SupportFragmentManager.Fragments.Clear();
                            adapter = new TabAdapter(SupportFragmentManager);
                            adapter.AddFragment(new EconomicalCalendar(), "Экономический Календарь");
                            viewPager.Adapter = adapter;
                            tabs.SetupWithViewPager(viewPager);
                            break;
                        }
                }

                e.MenuItem.SetChecked(true);
                  mDrawerLayout.CloseDrawers();
              };
          
        }

        public class TabAdapter : FragmentPagerAdapter
        {
            public List<SupportFragment> Fragments { get; set; }
            public List<string> FragmentNames { get; set; }
            public TabAdapter(SupportFragmentManager sfm):base(sfm)
            {
                Fragments = new List<SupportFragment>();
                FragmentNames = new List<string>();
            }
            public void AddFragment(SupportFragment fragment, string name)
            {
                Fragments.Add(fragment);
                FragmentNames.Add(name);
            }
          
            public void Clear()
            {
                Fragments = new List<SupportFragment>();
                FragmentNames = new List<string>();
            }
            public override int Count
            {
                get
                {
                    return Fragments.Count;
                }
            }
            public override SupportFragment GetItem(int position)
            {
                return Fragments[position];
            }
            public override ICharSequence GetPageTitleFormatted(int position)
            {
                return new Java.Lang.String(FragmentNames[position]);
            }
        }
    }
}


﻿using System;
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

namespace HendBook
{
    [Activity(Label = "HendBook", MainLauncher = true, Icon = "@drawable/icon",Theme ="@style/Theme.DesignDemo")]
    public class MainActivity : AppCompatActivity
    {
        private DrawerLayout mDrawerLayout;

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
            TabLayout tabs = FindViewById<TabLayout>(Resource.Id.tabs);
            ViewPager viewPager = FindViewById<ViewPager>(Resource.Id.viewpager);
            SetUpViewPager(viewPager);
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

        private void SetUpViewPager(ViewPager viewPager)
        {
            TabAdapter adapter = new TabAdapter(SupportFragmentManager);
            adapter.AddFragment(new Fragment1(), "Fragment 1");
            adapter.AddFragment(new Fragment2(), "Fragment 2");
            adapter.AddFragment(new Fragment3(), "Fragment 3");
          
            viewPager.Adapter = adapter;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                    mDrawerLayout.OpenDrawer((int)GravityFlags.Left);
                    return true;
                default:return base.OnOptionsItemSelected(item);
            }
            return base.OnOptionsItemSelected(item);

        }
        private void SetUpDrawerContent(NavigationView navigationVieew)
        {
            navigationVieew.NavigationItemSelected += (object sender, NavigationView.NavigationItemSelectedEventArgs e) =>
              {
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


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
using Android.Support.V7.Widget;
using Android.Content.Res;
using Android.Util;
using Android.Graphics;

namespace HendBook.Helpers
{
    public class HomeScreenAdapter : RecyclerView.Adapter
    {
        private readonly TypedValue mTypedValue = new TypedValue();
        private int mBackground;
        private List<EventsViewModel> mValues;
        Resources mResource;
        private Dictionary<int, int> mCalculatedSizes;


        public HomeScreenAdapter(Context context, List<EventsViewModel> items, Resources res)
        {
            context.Theme.ResolveAttribute(Resource.Attribute.selectableItemBackground, mTypedValue, true);
            mBackground = mTypedValue.ResourceId;
            mValues = items;
            mResource = res;

            mCalculatedSizes = new Dictionary<int, int>();
        }

        public void addItem(EventsViewModel value)
        {
            mValues.Add(value);

        }
        public void addItems(List<EventsViewModel> values)
        {
            mValues.AddRange(values);

        }
        public override int ItemCount
        {
            get
            {
                return mValues.Count;
            }
        }

        public override async void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {


                var simpleHolder = holder as SimpleViewHolder;
                simpleHolder.mBoundString = mValues[position].Text;
                simpleHolder.mTxtView.Text = mValues[position].Date.ToString("HH:MM") + "." + mValues[position].ShortText;
                simpleHolder.mTxtView2.Text = mValues[position].Actual.ToString();


                int drawableID = AllConverter.ConvertCountry(mValues[position].Country);
                BitmapFactory.Options options = new BitmapFactory.Options();
                var bitMap = await BitmapFactory.DecodeResourceAsync(mResource, drawableID, options);
                simpleHolder.mImageViewS.SetImageBitmap(bitMap);

                int importentID = AllConverter.ConvertForce(mValues[position].Posible);
                options = new BitmapFactory.Options();
                bitMap = await BitmapFactory.DecodeResourceAsync(mResource, importentID, options);
                simpleHolder.Imponent.SetImageBitmap(bitMap);

        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.EconomicalEventRow, parent, false);
            view.SetBackgroundResource(mBackground);

            return new SimpleViewHolder(view);
        }
    }

    public class SimpleViewHolder : RecyclerView.ViewHolder
    {
        public string mBoundString;
        public readonly View mView;
        public readonly ImageView mImageView;
        public readonly ImageView mImageViewS;
        public readonly TextView mTxtView;
        public readonly TextView mTxtView2;
        public readonly ImageView Imponent;
        public readonly TextView DateText;

        public SimpleViewHolder(View view) : base(view)
        {
            mView = view;
            mImageView = view.FindViewById<ImageView>(Resource.Id.avatar);
            mImageViewS = view.FindViewById<ImageView>(Resource.Id.avatarSquer);
            mTxtView = view.FindViewById<TextView>(Resource.Id.text2);
            mTxtView2= view.FindViewById<TextView>(Resource.Id.text1);
            Imponent= view.FindViewById<ImageView>(Resource.Id.Importent);
            DateText = view.FindViewById<TextView>(Resource.Id.DateText);
        }

        public override string ToString()
        {
            return base.ToString() + " '" + mTxtView.Text;
        }
    }
}
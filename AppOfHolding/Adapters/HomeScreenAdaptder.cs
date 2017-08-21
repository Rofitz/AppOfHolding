﻿using Android.App;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;

namespace AppOfHolding
{
    public class HomeScreenAdapter : BaseAdapter<Item>
    {
        List<Item> items;
        Activity context;
        public HomeScreenAdapter(Activity context, List<Item> items)
            : base()
        {
            this.context = context;
            this.items = items;
        }
        public override long GetItemId(int position)
        {
            return position;
        }
        public override Item this[int position]
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
                view = context.LayoutInflater.Inflate(Resource.Layout.ListItem, null);
            view.FindViewById<TextView>(Resource.Id.Text1).Text = item.Name;
            view.FindViewById<TextView>(Resource.Id.Text2).Text = item.Type.ToString();
            view.FindViewById<ImageView>(Resource.Id.Image).SetImageResource(Resource.Drawable.Icon);
            return view;
        }
    }
}
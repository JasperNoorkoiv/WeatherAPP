using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace WeatherApp
{
    public class CustomAdapter : BaseAdapter<string>
    {
        List<string> items;
        Activity context;
        List<int> images;

        public CustomAdapter(Activity context, List<string> items, List<int> images) : base()
        {
            this.context = context;
            this.items = items;
            this.images = images;
        }

        public override string this[int position]
        {
            get { return items[position]; }
        }

        public override int Count { get { return items.Count; } }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;
            if (view == null)
                view = context.LayoutInflater.Inflate(Resource.Layout.CustomRow, null);

            view.FindViewById<TextView>(Resource.Id.textView1).Text = items[position];

            view.FindViewById<TextView>(Resource.Id.date).Text = items[position];
            view.FindViewById<TextView>(Resource.Id.date).Text = items[position];
            view.FindViewById<ImageView>(Resource.Id.weatherIcon).SetImageResource(images[position]);



            return view;
        }
    }
}
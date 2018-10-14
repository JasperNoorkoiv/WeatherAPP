using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using WeatherApp.Core;
using System.Drawing;

namespace WeatherApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView textView1;
        TextView textView2;
        TextView textView3;
        SearchView searchView;
        Button button;
        TextView textAvg;
        ImageView weatherIcon;


        protected  override  void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            button = FindViewById<Button>(Resource.Id.button1);
            textView1 = FindViewById<TextView>(Resource.Id.textView1);
            textView2= FindViewById<TextView>(Resource.Id.textView2);
            textView3 = FindViewById<TextView>(Resource.Id.textView3);
            searchView = FindViewById<SearchView>(Resource.Id.searchView1);
            textAvg = FindViewById<TextView>(Resource.Id.textTempavg);

            button.Click += Button_Click;
        }

        private async void Button_Click(object sender, System.EventArgs e)
        {
            var weather = await Core.Core.GetWeather(searchView.Query);
            textView1.Text = weather.Temperature;
            textView2.Text = weather.Pressure;
            textView3.Text = weather.Wind;
            textAvg.Text = weather.Tempavg;
        }

    }
}
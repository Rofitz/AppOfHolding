using Android.App;
using Android.Widget;
using Android.OS;
using AppOfHolding.Services.DatabaseServices;
using System.Collections.Generic;

namespace AppOfHolding
{
    [Activity(Label = "AppOfHolding", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
             
            // Set our view from the "main" layout resource
            ItemDbService itemDbService = new ItemDbService();
            ListView listView;
            var homeScreen = new HomeScreenAdapter(this,(List<Item>)itemDbService.TempGet());
            SetContentView(Resource.Layout.Main); // loads the HomeScreen.axml as this activity's view
            listView = FindViewById<ListView>(Resource.Id.List); // get reference to the ListView in the layout

            // populate the listview with data
            listView.Adapter = new HomeScreenAdapter(this, (List<Item>)itemDbService.TempGet());

        }
    }
}


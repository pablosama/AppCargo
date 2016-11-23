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

namespace AppCargo.controller
{
    [Activity(Label = "AwardedCargoesActivity")]
    public class AwardedCargoesActivity : Activity
    {
        private List<string> mItems;
        private ListView mListView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.AwardedCargoes);
            mListView = FindViewById<ListView>(Resource.Id.lstAc);
            mItems = new List<string> { "viaje N°1", "viaje N°2", "viaje N°3", "viaje N°4", "viaje N°5", "viaje N°6" };

            ArrayAdapter<string> adapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1, mItems);
            mListView.Adapter = adapter;
        }
    }
}
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
using AppCargo.models;

namespace AppCargo.controller
{
    [Activity(Label = "PerformedCargoesActivity")]
    public class PerformedCargoesActivity : Activity
    {

        private List<PerformedCagoes> mItems = new List<PerformedCagoes>()
        {
            new PerformedCagoes (1001,"05/11/2016","Pto. Montt - Santiago"),
            new PerformedCagoes (1002,"06/11/2016","Santiago - Arica"),
            new PerformedCagoes (1003,"07/11/2016","Coquimbo - Concepción"),
            new PerformedCagoes (1004,"08/11/2016","Concepción - Temuco"),
            new PerformedCagoes (1005,"15/11/2016","Temuco - Osorno"),
            new PerformedCagoes (1006,"16/11/2016","Osorno - Lanco"),
            new PerformedCagoes (1007,"17/11/2016","Lanco - Valdivia"),
            new PerformedCagoes (1008,"18/11/2016","Valdivia - Pto. Montt"),
            new PerformedCagoes (1009,"19/11/2016","Pto. Montt - Chiloé"),
            new PerformedCagoes (10010,"20/11/2016","Pta. Arenas - Cohyaique")
        };
        private ListView mListView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.PerformedCargoesMain);
            // Create your application here

            mListView = FindViewById<ListView>(Resource.Id.lstPcPerformed);

            PerformedCargoesAdapter adapter = new PerformedCargoesAdapter(this, mItems);

            mListView.Adapter = adapter;
        }

   
    }
}
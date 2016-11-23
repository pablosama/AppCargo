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

        public static PerformedCagoes[] performedCargoesData = new PerformedCagoes[]
        {
            new PerformedCagoes (1,"05/11/2016","Pto. Montt - Santiago"),
            new PerformedCagoes (2,"06/11/2016","Santiago - Arica"),
            new PerformedCagoes (3,"07/11/2016","Coquimbo - Concepción"),
            new PerformedCagoes (4,"08/11/2016","Concepción - Temuco"),
            new PerformedCagoes (5,"15/11/2016","Temuco - Pto. Montt")
        };

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.PerformedCargoes);
            // Create your application here

            var adapter = new AdaptedPerformedCargoes(this);

        }

        private void CargasRealizadas_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
           
        }

        public class AdaptedPerformedCargoes : ArrayAdapter<PerformedCagoes>
        {
            Activity context;

            public AdaptedPerformedCargoes(Activity context) : base(context, Resource.Layout.PerformedCargoes, performedCargoesData)
            {              
                this.context = context;
            }

            public override View GetView(int position, View view, ViewGroup parent)
            {              
                if (view == null)
                {
                    view = context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem1, null);                  
                }

                view.FindViewById<TextView>(Resource.Id.lblPcNumOperation).Text = performedCargoesData[position].ToString();
                view.FindViewById<TextView>(Resource.Id.lblPcDateList).Text = performedCargoesData[position].ToString();
                view.FindViewById<TextView>(Resource.Id.lblPcOriginDestiny).Text = performedCargoesData[position].ToString();

                //TextView numOperacion = (TextView)view.FindViewById(Resource.Id.lblPcNumOperation);
                //TextView fecha = (TextView)view.FindViewById(Resource.Id.lblPcDateList);
                //TextView origenDestino = (TextView)view.FindViewById(Resource.Id.lblPcOriginDestiny);

                //numOperacion.SetText(performedCargoes[position].getNumeroOperacion());    
                //numOperacion.Text = performedCargoesData[position].getNumeroOperacion().ToString();
                //fecha.Text = performedCargoesData[position].getFecha();
                //origenDestino.Text = performedCargoesData[position].getOrigenDestino();

                return view;
            }
        }

    }
}
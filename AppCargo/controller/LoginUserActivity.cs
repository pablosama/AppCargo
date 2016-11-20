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
    [Activity(Label = "LoginUser")]
    public class LoginUserActivity : Activity
    {
        private Button btnVolver;
        private TextView txtWelcomeUser;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.LoginUser);
            // Create your application here
            txtWelcomeUser = FindViewById<TextView>(Resource.Id.txtLUAWelcomeUser);
            txtWelcomeUser.Text = txtWelcomeUser.Text + " "+ Intent.GetStringExtra("userName") ?? "Default User";

            btnVolver = FindViewById<Button>(Resource.Id.btnLUAReturn);
            btnVolver.Click += BtnVolver_Click;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            //var main = new MainActivity();
            AuthService.DeleteCredentials();

            Intent nextScreen = new Intent(this, typeof(MainActivity));
            StartActivity(nextScreen);
        }
    }
}
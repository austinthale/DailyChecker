using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Net;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DailyChecker.Services;
using DailyChecker.Droid.Services;

[assembly: Xamarin.Forms.Dependency(typeof(NetworkConnection))]

namespace DailyChecker.Droid.Services
{
    public class NetworkConnection : INetworkConnection
    {
        public bool IsConnected { get; set; }

        [Obsolete]
        public void CheckInternetConnection()
        {
            var ConnectivityManager = (ConnectivityManager)Application.Context.GetSystemService(Context.ConnectivityService);
            var ActiveNetworkInfo = ConnectivityManager.ActiveNetworkInfo;
            //IsConnected = 
            if(ActiveNetworkInfo != null && ActiveNetworkInfo.IsConnectedOrConnecting)
            {
                IsConnected = true;
            }
            else
            {
                IsConnected = false;
            }
        }
    }
}
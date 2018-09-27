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

namespace YoCity.Droid
{
    /// <summary>
    /// Service function to ensure that the geofencing continue running even if the application is closed
    /// I really have no idea what is going on here. I just copy and pasted. If I have to figure it out
    /// I will later
    /// </summary>
    [Service]
    public class GeofenceService : Service
    {
        public override void OnCreate()
        {
            base.OnCreate();

            System.Diagnostics.Debug.WriteLine("Geofence Service - Created");
        }

        public override StartCommandResult OnStartCommand(Android.Content.Intent intent, StartCommandFlags flags, int startId)
        {
            System.Diagnostics.Debug.WriteLine("Geofence Service - Started");
            return StartCommandResult.Sticky;
        }

        public override Android.OS.IBinder OnBind(Android.Content.Intent intent)
        {
            System.Diagnostics.Debug.WriteLine("Geofence Service - Binded");
            return null;
        }

        public override void OnDestroy()
        {
            System.Diagnostics.Debug.WriteLine("Geofence Service - Destroyed");
            base.OnDestroy();
        }
    }
}
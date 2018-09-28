using Plugin.Geofence;
using Plugin.Geofence.Abstractions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace YoCity.Helpers
{
    /// <summary>
    /// Class that controls what happens when geofence events happen. Here is where we will handle giving people points and all
    /// URL to this Plugin's Documentation: https://github.com/CrossGeeks/GeofencePlugin
    /// </summary>
    public class CrossGeofenceListener : IGeofenceListener
    {
        public void OnMonitoringStarted(string region)
        {
            Debug.WriteLine(string.Format("Monitoring started in region: {0}", region));
        }

        public void OnMonitoringStopped()
        {
            Debug.WriteLine(string.Format("{0}", "Monitoring stopped for all regions"));
        }

        public void OnMonitoringStopped(string identifier)
        {
            Debug.WriteLine(string.Format("{0}: {1}", "Monitoring stopped in region", identifier));
        }

        public void OnError(string error)
        {
            Debug.WriteLine(string.Format("{0}: {1}", "Error", error));
        }

        // Note that you must call CrossGeofence.GeofenceListener.OnAppStarted() from your app when you want this method to run.
        public void OnAppStarted()
        {
            Debug.WriteLine(string.Format("{0}", "App started"));
        }

        // This interface is triggered when the state of a user's geofence changes. E.g. Entered, Stayed, Exited.
        public void OnRegionStateChanged(GeofenceResult result)
        {
            Debug.WriteLine(string.Format("{0}", result.ToString()));
        }

        // I believe that this interface is triggered when the geofence plugin updates the users geolocation
        public void OnLocationChanged(GeofenceLocation location)
        {
            Debug.WriteLine("Location: {0} - {1}",location.Latitude,location.Longitude);
        }
    }
}

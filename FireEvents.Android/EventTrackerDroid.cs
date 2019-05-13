using System;
using System.Collections.Generic;
using Android.OS;
using Firebase.Analytics;
using FireEvents;
using FireEvents.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(EventTrackerDroid))]
namespace FireEvents.Droid
{

    public class EventTrackerDroid : IEventTracker
    {
        public void SendEvent(string eventId)
        {
            SendEvent(eventId, null);
        }

        public void SendEvent(string eventId, string paramName, string value)
        {
            SendEvent(eventId, new Dictionary<string, string>
            {
                {paramName, value}
            });
        }

        public void SendEvent(string eventId, IDictionary<string, string> parameters)
        {
            var firebaseAnalytics = FirebaseAnalytics.GetInstance(Forms.Context);

            if(parameters == null)
            {
                firebaseAnalytics.LogEvent(eventId, null);
                return;
            }

            var bundle = new Bundle();
            foreach(var param in parameters)
            {
                bundle.PutString(param.Key, param.Value);
            }

            firebaseAnalytics.LogEvent(eventId, bundle);
        }
    }
}

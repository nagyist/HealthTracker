
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Preferences;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace HealthTracker
{
	[Activity (Label = "PreferencesActivity")]			
	public class PreferencesActivity : PreferenceActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			// Load the preferences from an XML resource
			AddPreferencesFromResource(Resource.Xml.Preferences);

		}


	}
}


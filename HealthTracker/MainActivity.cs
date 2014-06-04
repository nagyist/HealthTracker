using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace HealthTracker
{
	[Activity (Label = "HealthTracker", MainLauncher = true)]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			var button = FindViewById<Button> (Resource.Id.EnterButton);

			button.Click += (sender, e) => 
			{
				var editText = FindViewById<EditText> (Resource.Id.EnterProtienEditText);
				var total = FindViewById<TextView>(Resource.Id.TotalProtienTextView);
				total.Text = editText.Text + " grams";
			};

		}
	}
}



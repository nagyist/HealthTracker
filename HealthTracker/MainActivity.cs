﻿using System;

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
			SetContentView (Resource.Layout.Manual);

			var button = FindViewById<Button> (Resource.Id.EnterButton);

			button.Click += (sender, e) => 
			{
				var editText = FindViewById<EditText> (Resource.Id.EnterProtienEditText);
				var total = FindViewById<TextView>(Resource.Id.TotalProtienTextView);
				total.Text = editText.Text + " grams";
			};

			var goalsButton = FindViewById<Button> (Resource.Id.GoalsButton);

			goalsButton.Click += (sender, e) => 
			{
				StartActivity(typeof(Goals));
			};

			var spinner = FindViewById<Spinner> (Resource.Id.vegetableDropdown);

			var adapter = ArrayAdapter.CreateFromResource (this, Resource.Array.Vegetables, Android.Resource.Layout.SimpleSpinnerItem);

			adapter.SetDropDownViewResource (Android.Resource.Layout.SimpleSpinnerDropDownItem);

			spinner.Adapter = adapter;

		}
	}
}



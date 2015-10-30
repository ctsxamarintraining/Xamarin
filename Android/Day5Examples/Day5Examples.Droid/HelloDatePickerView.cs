
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

namespace Day5Examples.Droid
{
	[Activity (Label = "HelloDatePickerView")]			
	public class HelloDatePickerView : Activity
	{
		private TextView dateDisplay;
		private Button pickDate;
		private Button pickTime;
		private DateTime date;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.HelloDatePicker);

			// capture our View elements
			dateDisplay = FindViewById<TextView> (Resource.Id.dateDisplay);
			pickDate = FindViewById<Button> (Resource.Id.pickDate);
			pickTime = FindViewById<Button> (Resource.Id.pickTime);

			// add a click event handler to the button
			pickDate.Click += delegate {				
				DatePickerFragment newFragment = new DatePickerFragment();
				newFragment.OnDateSet +=  OnDateSet;
				newFragment.Show(this.FragmentManager, "Date Picker"); 
			};

			pickTime.Click += delegate {				
				TimePickerFragment newFragment = new TimePickerFragment();
				newFragment.OnTimeSet +=  OnTimeSet;
				newFragment.Show(this.FragmentManager, "Time Picker"); 
			};

			// get the current date
			date = DateTime.Today;

			// display the current date (this method is below)
			UpdateDisplay ();
		}

		private void UpdateDisplay ()
		{
			dateDisplay.Text = date.ToString ("dd-MM-yyyy");
		}
		void OnDateSet (object sender, DatePickerDialog.DateSetEventArgs e)
		{
			this.date = e.Date;
			UpdateDisplay ();
		}

		void OnTimeSet (object sender, TimePickerDialog.TimeSetEventArgs e)
		{
			
			//UpdateDisplay ();
		}

	}
}


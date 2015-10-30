
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace Day5Examples.Droid
{
	public class DatePickerFragment : DialogFragment
	{
		public event EventHandler<DatePickerDialog.DateSetEventArgs> OnDateSet;

		public override Dialog OnCreateDialog (Bundle savedInstanceState)
		{			
			// Create a new instance of TimePickerDialog and return it
			return new DatePickerDialog(this.Activity, OnDateSet, DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
		}
	}

	public class TimePickerFragment : DialogFragment
	{
		public event EventHandler<TimePickerDialog.TimeSetEventArgs> OnTimeSet;

		public override Dialog OnCreateDialog (Bundle savedInstanceState)
		{			
			// Create a new instance of TimePickerDialog and return it
			return new TimePickerDialog(this.Activity, OnTimeSet, DateTime.Now.Hour, DateTime.Now.Minute, true);
		}
	}
}


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
using Evolve.Core;

namespace AndroidStack
{
	[Activity (Label = "Speakers", Icon = "@drawable/ic_action_speakers")]
	public class SpeakersActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.speakers_screen);
		}
	}
}
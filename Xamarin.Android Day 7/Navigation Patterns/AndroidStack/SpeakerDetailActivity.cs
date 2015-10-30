using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace AndroidStack
{
	[Activity (Label = "Speaker")]
	public class SpeakerDetailsActivity : Activity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			var index = Intent.Extras.GetInt("current_speaker_id", 0);

			var details = SpeakerDetailsFragment.NewInstance(index); // Details
			var fragmentTransaction = FragmentManager.BeginTransaction();
			fragmentTransaction.Add(Android.Resource.Id.Content, details);
			fragmentTransaction.Commit();
		}
	}
}
using System;
using System.Linq;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using Evolve.Core;

namespace AndroidActionBarTabs
{
	internal class SpeakerListFragment : ListFragment
	{
        private int currentSpeakerId;

		public override void OnActivityCreated (Bundle savedInstanceState)
		{
			base.OnActivityCreated (savedInstanceState);

			var adapter = new ArrayAdapter<String> (Activity, Android.Resource.Layout.SimpleListItem1, EvolveData.SpeakerData.Select (session => session.Name).ToArray ());
			ListAdapter = adapter;

			if (savedInstanceState != null) {
				currentSpeakerId = savedInstanceState.GetInt ("current_speaker_id", 0);
			}
		}

		public override void OnSaveInstanceState (Bundle outState)
		{
			base.OnSaveInstanceState (outState);
			outState.PutInt ("current_speaker_id", currentSpeakerId);
		}

		public override void OnListItemClick (ListView l, View v, int position, long id)
		{
			ShowDetails (position);
		}

		private void ShowDetails (int speakerId)
		{
			currentSpeakerId = speakerId;

			// Check what fragment is shown, replace if needed.
			var details = SpeakerDetailsFragment.NewInstance (speakerId);
				// Insert the fragment by replacing any existing fragment
			FragmentManager.BeginTransaction ()
				.Replace (Resource.Id.content_frame, details)
				.AddToBackStack (null)
				.Commit ();
		}
	}
}
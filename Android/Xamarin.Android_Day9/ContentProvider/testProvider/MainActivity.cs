
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace testProvider
{
	[Activity (Label = "testProvider", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		public static string PROVIDER_NAME = "monodroid.contentproviderdemo.LocationProvider";

		public static Android.Net.Uri CONTENT_URI = Android.Net.Uri.Parse("content://" + PROVIDER_NAME + "/locations");


		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);

			button.Text = "Get Content";

			button.Click += delegate {
				
				Android.Net.Uri allLocations = CONTENT_URI;
				Android.Database.ICursor c = ContentResolver.Query(allLocations, null, null, null, "name DESC");
				if (c.MoveToFirst ()) {
					do {
						// This will show in the output window of Visual Studio // MonoDevelop when you run it in debug mode
						System.Diagnostics.Debug.WriteLine ("Location:\n"
						+ "ID: " + c.GetString (c.GetColumnIndex ("_ID")) + "\n"
							+ "Name: " + c.GetString (c.GetColumnIndex ("name")) + "\n"
							+ "Latitude: " + c.GetString (c.GetColumnIndex ("longitude")) + "\n"
							+ "Longitude: " + c.GetString (c.GetColumnIndex ("latitude")) + "\n"
						);
					} while (c.MoveToNext ());
				}

			};


			Button btnUpdate = FindViewById<Button> (Resource.Id.btnUpdate);

			btnUpdate.Click += delegate {
				ContentValues values = new ContentValues();
				values.Put("_ID", 1); 
				values.Put("name", "Raghu");
				values.Put("longitude", 552);
				values.Put("latitude", 1297);
				ContentResolver.Update(Android.Net.Uri.Parse("content://" + PROVIDER_NAME + "/locations/1"), values,null,null);
			};
		}
	}
}




using System;

using Foundation;
using UIKit;
using SignaturePad;

namespace Sample.iOS
{
	public partial class FirstViewController : UIViewController
	{
		public FirstViewController () : base ("FirstViewController", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
			var signature = new SignaturePadView (View.Frame) {
				StrokeWidth = 3f
			};
			View.AddSubview (signature);

			Database db = new Database ();
			db.Save ();
		}
	}
}


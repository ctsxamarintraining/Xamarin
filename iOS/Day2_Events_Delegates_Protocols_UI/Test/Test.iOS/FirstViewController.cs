
using System;

using Foundation;
using UIKit;
using CoreGraphics;
using System.Threading.Tasks;

namespace Test.iOS
{
	public partial class FirstViewController : UIViewController
	{
		public FirstViewController () : base ("FirstViewController", null)
		{
			
		}


		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.

			Btn.TouchUpInside += Btn_TouchUpInside;

			Task.Run (() => {

				InvokeOnMainThread (() => {

					UILabel label = new UILabel (new CGRect (50, 30, 200, 20));
					label.Text = "UI From Code";

					Add (label);
				});
			});
		}



		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);

		}

		public override void ViewDidUnload ()
		{
			Btn.TouchUpInside -= Btn_TouchUpInside;

			base.ViewDidUnload ();
		}

		partial void OnButtonClicked (NSObject sender)
		{
			lbl.Text = "you clicked me !";
		}

		void Btn_TouchUpInside (object sender, EventArgs e)
		{
			lbl.Text = "you clicked me !";
		}
	}
}


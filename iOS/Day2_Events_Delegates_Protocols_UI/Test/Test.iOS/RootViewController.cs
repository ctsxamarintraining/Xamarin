using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Test.iOS
{
	partial class RootViewController : UIViewController
	{
		public RootViewController (IntPtr handle) : base (handle)
		{
		}

		partial void OnButtonClick (UIButton sender)
		{
			ThirdViewController vc = new ThirdViewController();

			this.NavigationController.PushViewController(vc,true);
		}

		public override void PrepareForSegue (UIStoryboardSegue segue, NSObject sender)
		{
			base.PrepareForSegue (segue, sender);

			var nxtVC =	segue.DestinationViewController as SecondViewController;
			nxtVC.Data = "Hello from Root View";
		}

		public override bool ShouldPerformSegue (string segueIdentifier, NSObject sender)
		{
			base.ShouldPerformSegue (segueIdentifier, sender);

			if (segueIdentifier == "navigationSegue")
				return false;
			else
				return true;
		}
	}
}

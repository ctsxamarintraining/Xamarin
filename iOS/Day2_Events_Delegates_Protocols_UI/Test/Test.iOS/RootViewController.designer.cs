// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Test.iOS
{
	[Register ("RootViewController")]
	partial class RootViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton ButtonFromSB { get; set; }

		[Action ("OnButtonClick:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void OnButtonClick (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (ButtonFromSB != null) {
				ButtonFromSB.Dispose ();
				ButtonFromSB = null;
			}
		}
	}
}

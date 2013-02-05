// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace MyLucid
{
	[Register ("SentEmailViewController")]
	partial class SentEmailViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton newEmailButton { get; set; }

	

		[Action ("newMessageButton:")]
		partial void newMessageButton (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (newEmailButton != null) {
				newEmailButton.Dispose ();
				newEmailButton = null;
			}
		}
	}
}

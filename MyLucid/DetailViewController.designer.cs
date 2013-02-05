// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace MyLucid
{
	[Register ("DetailViewController")]
	partial class DetailViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIBarButtonItem cancelComposeEmailButton { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField toTextField { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField subjectTextField { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextView bodyTextView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIBarButtonItem insertVideoButton { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIBarButtonItem insertImageButton { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIBarButtonItem insertTakePictureButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (cancelComposeEmailButton != null) {
				cancelComposeEmailButton.Dispose ();
				cancelComposeEmailButton = null;
			}

			if (toTextField != null) {
				toTextField.Dispose ();
				toTextField = null;
			}

			if (subjectTextField != null) {
				subjectTextField.Dispose ();
				subjectTextField = null;
			}

			if (bodyTextView != null) {
				bodyTextView.Dispose ();
				bodyTextView = null;
			}

			if (insertVideoButton != null) {
				insertVideoButton.Dispose ();
				insertVideoButton = null;
			}

			if (insertImageButton != null) {
				insertImageButton.Dispose ();
				insertImageButton = null;
			}

			if (insertTakePictureButton != null) {
				insertTakePictureButton.Dispose ();
				insertTakePictureButton = null;
			}
		}
	}
}

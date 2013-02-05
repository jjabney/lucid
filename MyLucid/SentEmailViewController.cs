
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Linq;

namespace MyLucid
{
	public partial class SentEmailViewController : UIViewController
	{
		private DetailViewController _composeEmailCtrlr = null;

		public SentEmailViewController (IntPtr handle) : base (handle)
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

			if (SplitViewController.ViewControllers.Count() > 1) {
				_composeEmailCtrlr = this.SplitViewController.ViewControllers [1] as DetailViewController;
			}

			newEmailButton.TouchDown += OnComposeNewEmail;
		}
		
		public override void ViewDidUnload ()
		{
			base.ViewDidUnload ();
			
			// Clear any references to subviews of the main view in order to
			// allow the Garbage Collector to collect them sooner.
			//
			// e.g. myOutlet.Dispose (); myOutlet = null;
			
			ReleaseDesignerOutlets ();
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return true;
		}

		private void OnComposeNewEmail (object sender, EventArgs e)
		{
			if (_composeEmailCtrlr != null) {
				_composeEmailCtrlr.CancelEmailMessage();
			}
		}
	}
}


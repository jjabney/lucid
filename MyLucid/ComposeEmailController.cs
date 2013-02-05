
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.MessageUI;

namespace MyLucid
{
	public partial class ComposeEmailController : UIViewController
	{
		MFMailComposeViewController _mailComposeViewController = null;

		public ComposeEmailController (IntPtr handle) : base (handle)
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
			_mailComposeViewController = new MFMailComposeViewController();
			_mailComposeViewController.Finished += (object sender, MFComposeResultEventArgs e) => {};
		

			_mailComposeViewController.View.Frame = new RectangleF(0,0,this.View.Bounds.Width,
			                                                       this.View.Bounds.Height);
			this.PresentViewController(_mailComposeViewController,false,null);
			
			// Perform any additional setup after loading the view, typically from a nib.
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
	}
}


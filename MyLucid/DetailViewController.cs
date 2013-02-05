using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.MessageUI;

namespace MyLucid
{
	public partial class DetailViewController : UIViewController
	{
		public DetailViewController (IntPtr handle) : base (handle)
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
			cancelComposeEmailButton.Clicked += OnCancel;
			insertVideoButton.Clicked += OnInsertVideo;
			insertImageButton.Clicked += OnInsertImage;
			insertTakePictureButton.Clicked += OnInsertTakePicture;
		}
		
		/// <summary>
		/// Clears all fields of the current email message
		/// </summary>
		/// <returns>
		/// 
		/// </returns>
		public void CancelEmailMessage ()
		{
			this.toTextField.Text = string.Empty;
			this.subjectTextField.Text = string.Empty;
			this.bodyTextView.Text = string.Empty;

		
		}
	
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return true;
		}

		private void OnCancel (object sender, EventArgs e)
		{
			CancelEmailMessage();
		}

		private void OnInsertVideo (object sender, EventArgs e)
		{
			throw new NotImplementedException ();
		}

		private void OnInsertImage (object sender, EventArgs e)
		{
			throw new NotImplementedException ();
		}

		private void OnInsertTakePicture (object sender, EventArgs e)
		{
			throw new NotImplementedException ();
		}
	}
}



using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Collections.Generic;
using MonoTouch.AddressBook;
using MonoTouch.MessageUI;
using System.Linq;

namespace MyLucid
{
	public partial class LucidTableViewController : UITableViewController
	{

		private List<LucidContent> _content = new List<LucidContent>();
		MFMailComposeViewController _mailController = null;

		public LucidTableViewController (IntPtr handle) : base(handle)
		{
			this.Title = NSBundle.MainBundle.LocalizedString ("Send", "Second");
			this.TabBarItem.Image = UIImage.FromBundle ("second");
			LucidVideoCollection lvc = new LucidVideoCollection ();
			foreach (var v in lvc.Videos) {
				_content.Add(v);
			}
		

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
			base.TableView.Source = new LucidTableSource(_content);
		
		   NextButton.Clicked += OnNext;
			// Perform any additional setup after loading the view, typically from a nib.
		}

	
		void OnNext (object sender, EventArgs e)
		{

		
			_mailController = new MFMailComposeViewController ();
			_mailController.Finished += OnFinished;
		    
			LucidTableSource src = this.TableView.Source as LucidTableSource;

			if (TableView.IndexPathsForSelectedRows != null) {
				List<LucidContent> selected = new List<LucidContent> ();
				foreach (var i in TableView.IndexPathsForSelectedRows) {
			
					selected.Add (src.TableItems [i.Row]);
				}
				_mailController.SetMessageBody(HtmlBuilder.ToHtml(selected),true);
			}
		

			this.PresentViewController(_mailController,true,null);
			 var x = this._mailController.ChildViewControllers;
		}

		void OnFinished (object sender, MFComposeResultEventArgs e)
		{

		

			e.Controller.DismissModalViewControllerAnimated (true); 
			e.Controller.Dispose();
			DeselectAll();
			this.TabBarController.SelectedIndex = 1;
		}

		void DeselectAll ()
		{
			foreach (var i in this.TableView.IndexPathsForSelectedRows) {
				TableView.DeselectRow(i,false);
			}

		}
	}
}


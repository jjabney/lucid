
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Collections.Generic;
using MonoTouch.CoreGraphics;
using System.Linq;

namespace MyLucid
{
	public partial class LucidCollectionViewController : UICollectionViewController
	{
		static NSString movieCellId = new NSString ("MyCell");
	
		LucidVideoCollection _lucid = new LucidVideoCollection();
		List<Movie> _content = null;
		public VideoViewController _videoViewController = null;

		public LucidCollectionViewController (IntPtr handle) : base(handle)
		{
		
			this.Title = NSBundle.MainBundle.LocalizedString ("Play", "Second");
			this.TabBarItem.Image = UIImage.FromBundle ("second");
			_content = _lucid.Videos;
		 
		}
		
		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}
		
		#region View lifecycle
		
		public override void ViewDidLoad ()
		{
		
			base.ViewDidLoad ();
	
			videoFilteringSegmentedControl.ValueChanged += VideoFilterChanged;

			_videoViewController = this.Storyboard.InstantiateViewController("videoViewCtrlr") as VideoViewController;


		}

		
		private void VideoFilterChanged (object sender, EventArgs e)
		{
			int selectedIndex = ((UISegmentedControl)sender).SelectedSegment;
		
			switch (selectedIndex) 
			{
				case 1:
				_content = _lucid.Videos.Where(x=>x.IsFavorite == true).ToList();
				break;
				case 2:
				_content = _lucid.Videos.Where(x=>x.IsPopular == true).ToList();
				break;
				default:
				_content = _lucid.Videos;
				break;
			}
		
			this.CollectionView.ReloadData();
		}
		
		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}
		
		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);


		}
		
		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}
		
		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		public override void DidRotate (UIInterfaceOrientation fromInterfaceOrientation)
		{
			base.DidRotate (fromInterfaceOrientation);
			this.CollectionView.ReloadData();
		}
#endregion
		

		

		#region 


		
		public override int NumberOfSections (UICollectionView collectionView)
		{
			return 1;
		}

		public override int GetItemsCount (UICollectionView collectionView, int section)
		{
			return _content.Count;
		}
		
	 	public override UICollectionViewCell GetCell (UICollectionView collectionView, MonoTouch.Foundation.NSIndexPath indexPath)
		{
			var movieCell = (MyCollectionViewCell)collectionView.DequeueReusableCell (movieCellId, indexPath);
			Movie movie = _content[indexPath.Row];
			movieCell.title.Text = movie.Title;
			movieCell.imageView.Image = UIImage.FromBundle(movie.Image);
			movieCell.subTitle.Text = movie.SubTitle;
			movieCell.count.Text = movie.TotalViews + " Views";
			return movieCell;
		}

		public override void ItemSelected (UICollectionView collectionView, NSIndexPath indexPath)
		{
			var movie = _content[indexPath.Row];
			this.NavigationController.PushViewController(_videoViewController,true);
			_videoViewController.PlayVideo(movie);

			//base.ItemSelected(collectionView,indexPath);
			//base.ItemSelected (collectionView, indexPath);
		}

		public override void ItemDeselected (UICollectionView collectionView, NSIndexPath indexPath)
		{
			base.ItemDeselected (collectionView, indexPath);
		}

		public override void ItemHighlighted (UICollectionView collectionView, NSIndexPath indexPath)
		{
			var cell = collectionView.CellForItem(indexPath);
			cell.ContentView.BackgroundColor = UIColor.Yellow;
		}
		
		public override void ItemUnhighlighted (UICollectionView collectionView, NSIndexPath indexPath)
		{
			var cell = collectionView.CellForItem(indexPath);
			cell.ContentView.BackgroundColor = UIColor.Black;
		}
		
		public override bool ShouldHighlightItem (UICollectionView collectionView, NSIndexPath indexPath)
		{
			return true;
		}
		
		public override bool ShouldSelectItem (UICollectionView collectionView, NSIndexPath indexPath)
		{
			return true;
		}
		
		// for edit menu
		public override bool ShouldShowMenu (UICollectionView collectionView, NSIndexPath indexPath)
		{
			return true;
		}
		
		public override bool CanPerformAction (UICollectionView collectionView, MonoTouch.ObjCRuntime.Selector action, NSIndexPath indexPath, NSObject sender)
		{
			return true;
		}
	

		

		
	
#endregion
	}
}



using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.MediaPlayer;

namespace MyLucid
{
	public partial class VideoViewController : UIViewController
	{
		MPMoviePlayerController _player;
		NSObject _preloadObserver, _playbackObserver;
		const string NOTIFICATION_PRELOAD_FINISH = "MPMovierPlayerContentPreloadDidFinishNotication";
		const string NOTIFICATION_PLAYBLACK_FINISH = "MPMoviePlayerPlaybackDidFinishNotification";
		
		public VideoViewController (IntPtr handle) : base (handle)
		{
		
		}

	

		public void PlayVideo (Movie movie)
		{
			if (_player == null) 
			{
				_player = new MPMoviePlayerController();
				//_player.ControlStyle = MPMovieControlStyle.Fullscreen;
				_player.SourceType = MPMovieSourceType.Streaming;
				_player.Fullscreen = true;

				var center = NSNotificationCenter.DefaultCenter;
				_preloadObserver = center.AddObserver(NOTIFICATION_PRELOAD_FINISH,
				                                      (notify)=>{
					
					_player.Play();
					notify.Dispose();
				});
				
				_playbackObserver = center.AddObserver(NOTIFICATION_PLAYBLACK_FINISH,
				                                       (notify)=>{
					
					notify.Dispose();
					
				});


				var f = this.View.Frame;
				_player.View.Frame = new Rectangle(0,0,(int)f.Width,(int)f.Height);
				this.Add(_player.View);
			}
			
			var url = NSUrl.FromString(movie.Url);
			_player.ContentUrl = url;
			_player.Play();
		}


		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			var f = this.View.Frame;

			_player.View.Frame = new Rectangle(0,0,(int)f.Height,(int)f.Width);
			return true;
		}


		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			this.View.AutoresizingMask = UIViewAutoresizing.All;
			this.View.AutosizesSubviews = true;
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewDidDisappear(animated);
			_player.Dispose();
			_player = null;
		}
    	

	}
}


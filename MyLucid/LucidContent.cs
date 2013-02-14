using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Collections.Generic;

namespace MyLucid
{
	public abstract class LucidContent
	{
		public string Title {
			get;
			set;
		}
		
		public string Image {
			get;
			set;
		}
		public string Url {
			get;
			set;
		}
		public string SubTitle {
			get;
			set;
		}
		
		public bool IsFavorite {
			get;
			set;
		}
		
		public bool IsPopular {
			get;
			set;
		}
		
		public int TotalViews{
			get;
			set;
		}
	}


}


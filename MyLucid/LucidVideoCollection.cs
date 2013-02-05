using System;
using System.Collections.Generic;
using MonoTouch.UIKit;

namespace MyLucid
{
	public class LucidVideoCollection 
	{

		public LucidVideoCollection ()
		{
			Videos = new List<Movie>();
			Movie carpalTunnel = new Movie ();
			carpalTunnel.Image = "CarpelTunnel.jpeg";
			carpalTunnel.Title = "Carpal Tunnel";
			carpalTunnel.Url = "http://progressive.iplayerhd.com/data/6/302764e6.mp4";
			carpalTunnel.SubTitle = "Lucid";
			carpalTunnel.IsFavorite = true;
			Videos.Add (carpalTunnel);
			
			
			Movie nervousSystem = new Movie ();
			nervousSystem.Image = "NervousSystem.jpg";
			nervousSystem.Title = "Nervous System";
			nervousSystem.Url = "http://progressive.iplayerhd.com/data/4/6ef2aaa4.mp4";
			nervousSystem.SubTitle = "Lucid";
			Videos.Add (nervousSystem);
			
			Movie adjustments = new Movie();
			adjustments.Image = "Adjustments.jpg";
			adjustments.Title = "Adjustments";
			adjustments.Url = "http://progressive.iplayerhd.com/data/f/1f5a8adf.mp4";
			adjustments.SubTitle = "Lucid";
			adjustments.IsPopular = true;
			Videos.Add(adjustments);

			Movie firstVisit = new Movie();
			firstVisit.Image = "FirstVisit.jpg";
			firstVisit.Title = "First Visit";
			firstVisit.Url = "http://progressive.iplayerhd.com/data/f/6167161f.mp4";
			firstVisit.SubTitle = "Lucid";
			firstVisit.IsPopular = true;
			Videos.Add(firstVisit);
	
			Movie tmj = new Movie();
			tmj.Image = "TMJ.jpg";
			tmj.Title = "TMJ";
			tmj.Url = "http://progressive.iplayerhd.com/data/8/6f5fb4f8.mp4";
			tmj.SubTitle = "Lucid";
			tmj.IsPopular = true;
			Videos.Add(tmj);

			Movie asthma = new Movie();
			asthma.Image = "Asthma.jpg";
			asthma.Title = "Asthma";
			asthma.Url = "http://progressive.iplayerhd.com/data/a/11cef65a.mp4";
			asthma.SubTitle = "Lucid";
			asthma.IsPopular = true;
			Videos.Add(asthma);

			Movie digestive = new Movie();
			digestive.Image = "Digestive.jpg";
			digestive.Title = "Digestive";
			digestive.Url =	"http://progressive.iplayerhd.com/data/9/2917ff19.mp4";
			digestive.SubTitle = "Lucid";
			digestive.IsPopular = true;
			Videos.Add(digestive);

			Movie headaches = new Movie();
			headaches.Image = "Headaches.jpg";
			headaches.Title = "Headaches";
			headaches.Url = "http://progressive.iplayerhd.com/data/b/56dd77bb.mp4";
			headaches.SubTitle = "Lucid";
			headaches.IsPopular = true;
			Videos.Add(headaches);
		}


		public List<Movie> Videos 
		{
			get;
			private set;
		}
	}
}


﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace BVETimetable.time.hokkaido.Train
{
	public class M2120 : ContentPage
	{
		public M2120 ()
		{

            var webView = new WebView
            {
                Source = "https://goo.gl/forms/xdxTn12ETjjBFHyF2"
            };
            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);
            Content = webView;

		}
	}
}
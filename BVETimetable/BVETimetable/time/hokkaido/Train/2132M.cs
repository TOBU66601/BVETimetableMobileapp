﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace BVETimetable.time.hokkaido.Train
{
	public class Train2132M : ContentPage
	{
		public Train2132M ()
		{
            Title = "2132M 行路表";

            var webView = new WebView
            {
                Source = "https://bvedrive.azurewebsites.net/template.html" //ここをファイル名変更。（当分はてすとURL）
            };
            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);
            Content = webView;
        }
	}
}
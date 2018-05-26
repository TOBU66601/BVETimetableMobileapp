using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BVETimetable
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactformPage : ContentPage
	{
		public ContactformPage ()
		{
			InitializeComponent ();
            var webView= new WebView
            {
                Source = "https://goo.gl/forms/xdxTn12ETjjBFHyF2"
            };
            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);


            Content = webView;

        }
	}
}
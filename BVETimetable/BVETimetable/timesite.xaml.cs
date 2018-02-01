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
    public partial class timesite : ContentPage
    {
        public timesite()
        {
            var webView = new WebView
            {
                Source = "http://bvedrive.azurewebsites.net/"
            };
            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);
            Content = webView;
            InitializeComponent();

            
        }

        

    }
    }
   



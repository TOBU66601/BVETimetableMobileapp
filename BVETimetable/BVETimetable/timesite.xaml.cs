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

        public class TitleWebViewRender : WebView
        {
            public string PageTitle { get; internal set; }
        }


        public static readonly BindableProperty PageTitleProperty = BindableProperty.Create<TitleWebViewRender, string>(v => v.PageTitle, null, BindingMode.OneWayToSource);

            public string PageTitle
            {
                get { return (string)GetValue(PageTitleProperty); }
                set { SetValue(PageTitleProperty, value); }
            }
        }
    }
   



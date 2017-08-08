using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BVETimetable.time
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class area : ContentPage
	{
		public area ()
		{
			InitializeComponent ();

            //Listviewを作る
            var ar = new List<areaitem>()
            {
                new areaitem { area = "北海道", ds = "第1DS" },new areaitem { area = "東北" }
            };
            var listview = new ListView
            {
                ItemsSource = ar,
                RowHeight=70
            };
            Content = new StackLayout
            {
                Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0),
                Children = {listview}
                //var cell = new DataTemplate(typeof(ImageCell));
            //cell.SetBinding(ImageCell.ImageSourceProperty, "Url");
            //cell.SetBinding(TextCell.TextProperty, "Name");
            //cell.SetBinding(TextCell.DetailProperty, new Binding("Age", stringFormat: "{0}才"));
        };

		}
	}



}

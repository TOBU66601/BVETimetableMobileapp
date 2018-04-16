using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BVETimetable.time.hokkaido
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class N1page : ContentPage
	{
        public N1page()
        {
            InitializeComponent();

            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

        }

    }
}
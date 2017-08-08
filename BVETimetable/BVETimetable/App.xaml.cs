using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace BVETimetable
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage =new NavigationPage (new BVETimetable.MainPage());      

            
		}
		
	};
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BVETimetable.time.hokkaido
{
	//[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class N1Page : ContentPage
	{
		public N1Page ()
		{
			InitializeComponent ();

		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Train.Train2120M());
            //なんか知らないけどJRの列番方式だとNGなのね・・・てことは貨物もNG？？？
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Train.Train121M());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Train.Train2124M());
        }
    }
}
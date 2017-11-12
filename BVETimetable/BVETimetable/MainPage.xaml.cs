using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BVETimetable
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
         
        }







        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new timesite(), true);
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new cr(), true);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new time.area(), true);
        }
    }
}
            

    


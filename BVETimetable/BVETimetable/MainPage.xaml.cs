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
            InitializeComponent();
        }





        //ボタンごとにリンク設定を張る

            //個別列車検索
        private void Button_Clicked_1(object sender, EventArgs e)
        {
            DisplayAlert("お知らせ", "この機能は現在利用できません", "OK");
        }


        private void Button_Clicked_2(object sender, EventArgs e)
        {
            //ボタンを押した際のイベント（挙動の順番がおかしい）
          
                var answer = await DisplayAlert("お知らせ", "外部サイトを表示します",  "はい","いいえ");

            if (answer)
            {
                Device.OpenUri(new Uri("http://bvedrive.azurewebsites.net"));

            }
            else
            {
                
            }
            

        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new cr(), true);
        }

        //地域選択の部分
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new time.area(), true);
        }
    }
}
            

    


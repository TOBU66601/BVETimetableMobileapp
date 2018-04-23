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
    public partial class cr : ContentPage
    {
        public cr()
        {
            InitializeComponent();

            //Text="\n",

            //             Text="\n"+
            //           "データベースより取得した時刻表をもとに、運転時間の表示、誤通過防止のための機能を備え付けます。\n"+
            //         "また、運転中はログを取得し、そのデータをフィードバックすることにより、本データの一部の改善が進みます。\n\n"

            //      Text="項目メニューの説明\n",

            //画像貼り付け
            //    Text="\n",
            //  Text="お問い合わせは下記のボタンよりお願いします。\n",


        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContactformPage());
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel; //

namespace BVETimetable.time
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class area : ContentPage
    {
        // 任意のListViewを生成する
        ObservableCollection<ItemClass> _page1 = new ObservableCollection<ItemClass>();

        //任意の文字列の設定（ここに追加する）
        public string[] _loacls =
        {
            "北海道","東北",　"東京近郊",//"東京電車特定"
        };
        public string _select;

        public area()
        {
            InitializeComponent();
            // iOSだけ、上部に余白をとる
            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

            for (int i = 0; i < _loacls.Length; i++)
            {
                _page1.Add(new ItemClass { Word = _loacls[i] });
            }
            arealist.ItemsSource = _page1;

            //セル選択→上から行って、北海道フォルダのページへ画面推移

            arealist.ItemTapped += async (sender, args) => {
                var word = (arealist.SelectedItem as ItemClass).Word;
                Page targetPage;


                switch (word)
                {
                    case "北海道":
                        targetPage = new hokkaido.kouro();
                        break;

                    case "東北":
                        targetPage = new tohoku.kouro();
                        break;

                        

                        //同様の処理をさせる

                }

                
                await Navigation.PushModalAsync(targetPage);
                //await DisplayAlert("Item Tapped", "An item was tapped.", "OK");だと全部アラート出る


            };

        }
    }

    public class ItemClass
    {
        public string Word { get; set; }
    }


    //北海道が選択されたとき
}
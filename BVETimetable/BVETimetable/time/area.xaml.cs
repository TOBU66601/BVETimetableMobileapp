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
        ObservableCollection<string> _page1 = new ObservableCollection<string>();

        //任意の文字列の設定（ここに追加する）
        public string[] _loacls =
        {
            "北海道","東北",　"東京近郊","東京電車特定","東海","名古屋周辺","京阪神"
        };
        public string _select;
        public area()
        {
            InitializeComponent();
            // iOSだけ、上部に余白をとる
            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

            for (int i = 0; i < _loacls.Length; i++)
            {
                _page1.Add( _loacls[i] );
            }
            arealist.ItemsSource = _page1;

            //セル選択→上から行って、北海道フォルダのページへ画面推移

            arealist.ItemTapped += async (sender, e) => {

                _select = (arealist.SelectedItem as string);
                switch (_select)


              
                {
                    case "北海道":
                        await Navigation.PushAsync(new hokkaido.kouro());
                        break;

                    case "東北":
                        await Navigation.PushAsync(new tohoku.kouro());
                        break;

                    case "東京近郊":
                        await Navigation.PushAsync(new Kanto.KoroPage());
                        break;

                    default:
                        break;

                        //同様の処理をさせる

                }

                



            };

        }
    }

}
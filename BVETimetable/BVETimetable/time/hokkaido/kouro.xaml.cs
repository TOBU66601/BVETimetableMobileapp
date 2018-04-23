using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace BVETimetable.time.hokkaido
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class kouro : ContentPage
    {
        // 任意のListViewを生成する
        ObservableCollection<string> _Hkouro = new ObservableCollection<string>();

        //任意の文字列の設定（ここに追加する）
        public string[] _loacls =
        {
            "N1","N2","N3","N4","N5","N6","N7","N8" //行路番号一覧
        };
        public string _select;
        public kouro()
        {
            InitializeComponent();
            // iOSだけ、上部に余白をとる
            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

            for (int i = 0; i < _loacls.Length; i++)
            {
                _Hkouro.Add(_loacls[i]);
            }
            kourolist.ItemsSource = _Hkouro;

            //セル選択→上から行って、北海道フォルダのページへ画面推移

            kourolist.ItemTapped += async (sender, e) =>
            {
                _select = (kourolist.SelectedItem as string);
                switch (_select)
                {
                    case "N1":
                        await Navigation.PushAsync(new hokkaido.N1Page());
                        break;

                    default:break;
                            //同様の処理をさせる

                    }

            };

        }
    }
}
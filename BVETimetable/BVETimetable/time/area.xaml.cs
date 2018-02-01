using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BVETimetable.time
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class area : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public area()
        {
            InitializeComponent();

            Title = "エリア選択"; //XAMLに書くとエラー起こすので、あえてここに書いた。
            Items = new ObservableCollection<string>
            {
                "Item 1",
                "Item 2",
                "Item 3",
                "Item 4",
                "Item 5"
            };
			
			MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //タップ時は文字の読み取りができるのだろうか。その際に、例としてItem1→１という動作もしくはページ移動の動作を再度繰り返す。

            if (e.Item == null)
                return; //何もない時

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

     
                
 

            //Deselect Item
            //string ((ListView)sender).SelectedItem == "Item 1";
        }
    }
}

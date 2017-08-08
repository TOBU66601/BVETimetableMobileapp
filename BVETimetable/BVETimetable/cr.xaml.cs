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

            Content = new Label
            {


                FormattedText = new FormattedString
                {
                    Spans =
                    {
                        new Span
                        {
                            Text = "法的情報\n",
                            FontSize = 20,
                        },
                        new Span
                        {
                            Text="Copyright 2017 jre657 All rights reserved.\n"+
                            "This app made by Xamarin.\n\n"
                        },

                        //アプリ説明
                     new Span
                     {
                         Text="取扱説明書\n",
                         FontSize=18,
                     }   ,
                     new Span
                     {
                         Text="本アプリは、BVE　日本線の運転を補助するアプリです。\n"+
                         "データベースより取得した時刻表をもとに、運転時間の表示、誤通過防止のための機能を備え付けます。\n"+
                         "また、運転中はログを取得し、そのデータをフィードバックすることにより、本データの一部の改善が進みます。\n\n"
                     },

                    new Span
                    {
                        Text="項目メニューの説明\n",
                        FontSize=16,
                    },
                    new Span
                    {
                        Text="\n",

                    //画像貼り付け
                    },


                    //お問い合わせについて
                    new Span
                    {
                        Text="お問い合わせ\n",
                        FontSize=18,
                    },
                    new Span
                    {
                        Text="お問い合わせは下記のボタンよりお願いします。\n",

                    },
                    


                    }

                    

                }
            };
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("お問い合わせボタン");
        }

    };
}
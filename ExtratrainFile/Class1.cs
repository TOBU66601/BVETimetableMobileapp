using System;
using System.Collections.Generic;

namespace ExtratrainFile
{
     class HokkaidoEXtrainInfo
    {

        //1ページ目で表示
        public string KoroName { get; set; }//行路名
        public string Targettrain { get; set; }//行路選択時の列車情報をテキストで
        public DateTime MadeDate { get; set; }//作成日時
        public DateTime TargetDay { get; set; }//施行日時


        //2ページ目で表示
        public List<string> Trainnumbers { get; set; }
    }

     class HokkaidoEXtrain
    {
        public static void Main(string[]args)
        {
            HokkaidoEXtrainInfo train = new HokkaidoEXtrainInfo
            {
                KoroName = "試N601行路",
                Targettrain = "試回9120M～試9120M～試9121M～試9122M～試9123M～試回9123M",
                MadeDate = new DateTime(2018,4,6,13,30,46),
                TargetDay = DateTime.Now,
                Trainnumbers=new List<string>
                {

                "試回9120M",
                    "試9120M",
                    "試9121M",
                    "試9122M",
                    "試9123M",
                    "試回9123M",
                }
                
            };

           //Trainnumbers<string>での列車から設定。リンクは偽リンクを発生させる。
            
            //押したときに文字で見分けないといけないのでもうすこしすすんだら再確認。Stacklayoutで

            
        }
        
    }


}

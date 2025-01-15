using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace v20.Wiev
{
    public static class KisiGönderiVeri
    {
        public static ObservableCollection<KisiGönderi> KisiGönderiler = new ObservableCollection<KisiGönderi>();
        static KisiGönderiVeri()
        {
            #region Gönderi Verileri
            KisiGönderiler.Add(
                new KisiGönderi()
                {
                    GkisiAd = "Burak",
                    GkisiSoyad = "Yapıcı",
                    Gkullaniciad= "brk11",
                    GKisipp = new BitmapImage(new Uri("/Image/kisipp/burakpp.jpeg", UriKind.Relative)),
                    //GkisiGönderi = 
                    Doktorlar="burak"
                    //Doktorlar=DoktorVerileri.Doktorlar[0]
                });
            KisiGönderiler.Add(
                new KisiGönderi()
                {
                    GkisiAd = "İsmail",
                    GkisiSoyad = "Oruç",
                    Gkullaniciad = "ismailorc",
                    GKisipp = new BitmapImage(new Uri("/Image/kisipp/isopp.jpeg", UriKind.Relative)),
                   // GkisiGönderi = 
                });
            KisiGönderiler.Add(
                new KisiGönderi()
                {
                    GkisiAd = "Alim Efe",
                    GkisiSoyad = "Uzundemir",
                    Gkullaniciad = "aefe",
                    GKisipp = new BitmapImage(new Uri("/Image/kisipp/efepp.jpeg", UriKind.Relative)),
                   // GkisiGönderi = 
                });
            KisiGönderiler.Add(
                new KisiGönderi()
                {
                    GkisiAd = "Hacı Sait",
                    GkisiSoyad = "Yavuz",
                    Gkullaniciad= "haco67",
                    GKisipp = new BitmapImage(new Uri("/Image/kisipp/hacopp.jpeg", UriKind.Relative)),
                    //GkisiGönderi = 
                });
        
            #endregion
        }
    }
}

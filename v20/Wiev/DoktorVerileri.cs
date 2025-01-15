using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace v20.Wiev
{
    public static class DoktorVerileri
    {
        public static ObservableCollection<DoktorBilgileri> Doktorlar = new ObservableCollection<DoktorBilgileri>();

        static DoktorVerileri()
        {
           
            Doktorlar.Add(
                new DoktorBilgileri()
                {
                    DoktorAdi = "Serenay",
                    DoktorSoyadi = "Sarikaya",
                    DoktorKullaniciAdi = "seren",
                  //  Doktorpp = new BitmapImage(new Uri("C://Users//burak//OneDrive//Masaüstü//v20//v20//Image//kisipp//serenaypp.png", UriKind.Relative)),
                    DoktorSifre = "123",
                });

            Doktorlar.Add(
                new DoktorBilgileri()
                {
                    DoktorAdi = "Mahmut",
                    DoktorSoyadi = "Tuncer",
                    DoktorKullaniciAdi = "mamo",
                  //  Doktorpp = new BitmapImage(new Uri("C://Users//burak//OneDrive//Masaüstü//v20//v20//Image//kisipp//mamopp.jpg", UriKind.Relative)),
                    DoktorSifre = "123",
                });
              
            Doktorlar.Add(
                new DoktorBilgileri()
                {
                    DoktorAdi = "İbrahim",
                    DoktorSoyadi = "Tatlıses",
                    DoktorKullaniciAdi = "ibrahimtat",
                 //   Doktorpp = new BitmapImage(new Uri("C://Users//burak//OneDrive//Masaüstü//v20//v20//Image//kisipp//ibopp.jpg", UriKind.Relative)),
                    DoktorSifre = "123",
                });



        }
    }
}

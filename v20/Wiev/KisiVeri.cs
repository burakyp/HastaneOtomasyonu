using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace v20.Wiev
{
    public static class KisiVeri
    {
        public static ObservableCollection<Kisi> Kisiler = new ObservableCollection<Kisi>();

        static KisiVeri()
        {
            #region Kişi verileri

            Kisiler.Add(
                new Kisi() 
                { 
                    KisiAdi = "Burak", 
                    KisiSoyadi = "Yapıcı", 
                    KisiKullaniciAdi = "brk11", 
                    KisiSifre = "123",
                   // Kisipp = new BitmapImage(new Uri("C://Users//burak//OneDrive//Masaüstü//v20//v20//Image//kisipp//burakpp.jpeg", UriKind.Relative)) ,
                   
                });
            Kisiler.Add(
                new Kisi()
                {
                    KisiAdi = "Hacı Sait",
                    KisiSoyadi = "Yavuz",
                    KisiKullaniciAdi = "haco67",
                    KisiSifre = "123",
                  // Kisipp = new BitmapImage(new Uri("C://Users//burak//OneDrive//Masaüstü//v20//v20//Image//kisipp//hacopp.jpeg", UriKind.Relative)),
                });
            Kisiler.Add(
             new Kisi()
             {
                 KisiAdi = "İsmail",
                 KisiSoyadi = "Oruç",
                 KisiKullaniciAdi = "iso",
                 KisiSifre = "1234",
               //  Kisipp = new BitmapImage(new Uri("C://Users//burak//OneDrive//Masaüstü//v20//v20//Image//kisipp//isopp.jpeg", UriKind.Relative)),
             });
            Kisiler.Add(
             new Kisi()
             {
                 KisiAdi = "Alim Efe",
                 KisiSoyadi = "Uzundemir",
                 KisiKullaniciAdi = "aefe",
                 KisiSifre = "1234",
                // Kisipp = new BitmapImage(new Uri("C://Users//burak//OneDrive//Masaüstü//v20//v20//Image//kisipp//efepp.jpeg", UriKind.Relative)),
             });
            #endregion
        }
    }
}

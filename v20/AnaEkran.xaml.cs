using Microsoft.SqlServer.Server;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using v20.Pages;
using v20.Wiev;

namespace v20
{
    /// <summary>
    /// AnaEkran.xaml etkileşim mantığı
    /// </summary>
    public partial class AnaEkran : Window
    {
        Kisi seciliKisi;
      
       
        public AnaEkran(Kisi kisi=null)
        {
            InitializeComponent();
            #region tanımlama ve atamalar
            CbBölüm.ItemsSource = new List<string>() { "Dahiliye", "Cildiye", "Beyin Cerrahi", "Genel Cerrahi", "Diş Sağlığı", "Göz Sağlığı", "Fizik Tedavi" };

            seciliKisi = kisi;
            CbDoktorlar.ItemsSource = DoktorVerileri.Doktorlar;
            TbAd.Text= seciliKisi.KisiAdi.ToString();
            TbSoyad.Text= seciliKisi.KisiSoyadi.ToString();
            TbKullaniciadi.Text= $"@{seciliKisi.KisiKullaniciAdi.ToString()}";
            ImgPP.ImageSource = seciliKisi.Kisipp;
            LbGönderiler.ItemsSource = KisiGönderiVeri.KisiGönderiler.Where(a => a.Gkullaniciad.StartsWith(seciliKisi.KisiKullaniciAdi, StringComparison.CurrentCultureIgnoreCase));
            //Frm.Content = new PgGönderiler();  
            #endregion
        }
        #region Olaylar

        #region ayarlar
        private void RbAyarlar_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion
       
       
        #region Arama Çubuğu
        //private void Tbara_TextChanged(object sender, TextChangedEventArgs e)
        //{

        //    IEnumerable<Kisi> Kisiler = KisiVeri.Kisiler.AsEnumerable();

        //    #region TextBox Ara Filtresi
        //    Kisiler = Kisiler.Where(m => m.KisiKullaniciAdi.StartsWith(Tbara.Text, StringComparison.CurrentCultureIgnoreCase)
        //        || m.KisiAdi.StartsWith(Tbara.Text, StringComparison.CurrentCultureIgnoreCase));
        //    #endregion
        //    LbListele.ItemsSource = Kisiler;
        //    if (Tbara.Text=="")
        //    {
        //        LbMusic.Visibility = Visibility.Visible;
        //        LbListele.Visibility = Visibility.Collapsed;
               
        //    }
        //    else
        //    {
        //        LbMusic.Visibility = Visibility.Collapsed;
        //        LbListele.Visibility = Visibility.Visible;
        //    }
          
        //}
        #endregion

        #region Gönderi Sayfası
        private void RbAnaSayfa_Click(object sender, RoutedEventArgs e)
        {          
                LbGönderiler.ItemsSource = KisiGönderiVeri.KisiGönderiler.Where(a => a.Gkullaniciad.StartsWith(seciliKisi.KisiKullaniciAdi, StringComparison.CurrentCultureIgnoreCase));
                Kontrol.Text = null;
        }

        #endregion

        #endregion

        

        private void BtnKaydet_Click(object sender, RoutedEventArgs e)
        {
            if (CbDoktorlar.SelectedItem != null && CbBölüm.Text != "" && DpRandevuTarihi.Text != null)
            {

                KisiGönderiVeri.KisiGönderiler.Add(
                new KisiGönderi()
                {
                    GkisiGönderi = CbBölüm.Text,
                    GkisiAd = seciliKisi.KisiAdi,
                    GkisiSoyad = seciliKisi.KisiSoyadi,
                    GKisipp = seciliKisi.Kisipp,
                   Doktorlar = CbDoktorlar.SelectedItem.ToString(),
                    Grandevutarihi = DpRandevuTarihi.SelectedDate.Value,
                    Gkullaniciad = seciliKisi.KisiKullaniciAdi

                }
                );
                Kontrol.Text = "Kayıt başarılı anasayfaya tıklayınız...";
                CbDoktorlar.SelectedItem = null;
                CbBölüm.SelectedItem = null;
                DpRandevuTarihi.SelectedDate = null;
                Kontrol.Text = "Kayıt başarılı anasayfaya tıklayınız...";

            }
            else
            {
                CbDoktorlar.SelectedItem = null;
                CbBölüm.SelectedItem = null;
                DpRandevuTarihi.SelectedDate = null;
                Kontrol.Text = "Kayıt başarısız anasayfaya tıklayınız...";

            }



            //KisiGönderiVeri.KisiGönderiler.Add(
            //        new KisiGönderi()
            //        {
            //            GkisiGönderi = TbSikayet.Text,
            //            GkisiAd = seciliKisi.KisiAdi,
            //            GkisiSoyad = seciliKisi.KisiSoyadi,
            //            GKisipp = seciliKisi.Kisipp,
            //            Gdoktor = CbDoktorlar.SelectedItem.ToString(),
            //            Grandevutarihi = DpRandevuTarihi.SelectedDate.Value,
            //            Gkullaniciad = seciliKisi.KisiKullaniciAdi

            //        }
            //        );




        }

        private void LbGönderiler_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            KisiGönderi secilirandevu = (KisiGönderi)LbGönderiler.SelectedItem;
            if (secilirandevu != null)
            {
                TxtAd.Text = secilirandevu.GkisiAd;
                TxtSoyad.Text = secilirandevu.GkisiSoyad;
                TxtRanndevuTarih.Text = secilirandevu.Grandevutarihi.ToLongDateString();
                TxtDoktor.Text = secilirandevu.Doktorlar.ToString();
                TxtŞikayet.Text = secilirandevu.GkisiGönderi;
                CbBölüm.Text = secilirandevu.GkisiGönderi;

            }
            else
            {
                TxtAd.Text = "";
                TxtSoyad.Text = "";
                TxtDoktor.Text = "";
                TxtRanndevuTarih.Text = "";
                TxtŞikayet.Text = "";
            }
        }

        //private void Tbara_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(Tbara.Text))
        //    {
        //        LbGönderiler.ItemsSource = KisiGönderiVeri.KisiGönderiler;
        //        LbGönderiler.ItemsSource = KisiGönderiVeri.KisiGönderiler.Where(a => a.Gkullaniciad.StartsWith(seciliKisi.KisiKullaniciAdi, StringComparison.CurrentCultureIgnoreCase));
        //    }
        //    else
        //    {
        //        LbGönderiler.ItemsSource = KisiGönderiVeri.KisiGönderiler.Where(a => a.Grandevutarihi.Month.ToString().StartsWith(Tbara.Text, StringComparison.CurrentCultureIgnoreCase));

        //    }
        //}
    }
}

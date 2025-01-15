using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using v20.Wiev;

namespace v20
{
    /// <summary>
    /// Kayıt.xaml etkileşim mantığı
    /// </summary>
    public partial class Kayıt : Window
    {
        public Kayıt()
        {
            InitializeComponent();
        }
        #region Kayıt butonu
        private void BtnKayıt_Click(object sender, RoutedEventArgs e)
        {
             if (TbSifre.Text== "" | TbSoyad.Text== "" | TbAd.Text == "" | TbKullaniciAdi.Text == "" | TbSoyad.Text == "" )
             {
                if (ImgResim.Source == null)
                {
                    ImgResim.Source = new BitmapImage(new Uri("Image/pp.jpeg", UriKind.Relative));
                }
                MessageBox.Show("Kayıt oluşturalamadı boş alan bırakmayınız .");
             }
            else
            {
                KisiVeri.Kisiler.Add(
                new Kisi()
                {
                    KisiAdi = TbAd.Text,
                    Kisipp = ImgResim.Source as BitmapImage,
                    KisiSoyadi = TbSoyad.Text,
                    KisiKullaniciAdi = TbKullaniciAdi.Text,
                    KisiSifre = TbSifre.Text
                });
                MessageBox.Show("Kayıt Başarıyla Oluşturuldu .");
                MainWindow ekran = new MainWindow();
                ekran.Show();
                this.Hide();
            }
            TbKullaniciAdi.Clear();
            TbSifre.Clear();
            TbAd.Clear();
            TbSoyad.Clear();
            ImgResim.Source = null;
        }
        #endregion
        #region Profil Foto Ekleme
        private void BtnPp_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Title = "Resim seç",
                Filter = "Resim Dosyaları|*.png;.jpg"
            };
            if (ofd.ShowDialog() == true)
            {
                ImgResim.Source = new BitmapImage(new Uri(ofd.FileName));
            }
        }
        #endregion
    }
}

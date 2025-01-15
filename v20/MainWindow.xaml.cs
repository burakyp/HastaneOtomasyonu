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
using v20.Wiev;

namespace v20
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        #region giriş button
        private void BtnGiris_Click(object sender, RoutedEventArgs e)
        {
            #region Giriş
            #region Kişi belirleme
            Kisi kisi = null;
            foreach (var u in KisiVeri.Kisiler)
            {
                if (u.KisiKullaniciAdi == TbPosta.Text && u.KisiSifre == TbSifre.Text)
                {
                    kisi = u;
                    break;
                }
            }
            #endregion
            #region kişi kontrol
            if (kisi != null)
            {
                AnaEkran ekran = new AnaEkran(kisi);
                ekran.Show();
                this.Hide();
                //Kisi seciliKisi = kisi;
                //if (kisi != null)
                //{
                //    NavigationService.Content = new AnaEkran(seciliKisi);
                //}
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış tekrar giriş yapmayı deneyiniz!!");
                TbPosta.Clear();
                TbSifre.Clear();
            }
            #endregion
            #endregion
            #region deneme
            //if (TbPosta.Text == "123" && TbSifre.Text == "123")
            //{
            //    //MessageBox.Show("Giriş Başarılı!");
            //    AnaEkran ekran = new AnaEkran();
            //    ekran.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Geçersiz kullanıcı adı veya şifre!");
            //    TbPosta.Clear();
            //    TbSifre.Clear();

            //}
            #endregion
        }
        #endregion
        #region kayıt ekranı
        private void BtnKayıt_Click(object sender, RoutedEventArgs e)
        {
            Kayıt ekran = new Kayıt();
            ekran.Show();
            this.Hide();
        }
        #endregion


        private void BtnDoktorGirisi_Click(object sender, RoutedEventArgs e)
        {
            DoktorGirisi ekran = new DoktorGirisi();
            ekran.Show();
            this.Hide();
        }
    }
}

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
using System.Windows.Shapes;
using v20.Wiev;

namespace v20
{
    /// <summary>
    /// DoktorGirisi.xaml etkileşim mantığı
    /// </summary>
    public partial class DoktorGirisi : Window
    {
        public DoktorGirisi()
        {
            InitializeComponent();
        }

        private void BtnDoktorGiri_Click(object sender, RoutedEventArgs e)
        {
            DoktorBilgileri doktor = null;
            foreach (var u in DoktorVerileri.Doktorlar)
            {
                if (u.DoktorKullaniciAdi == TbDoktorTc.Text && u.DoktorSifre == TbDoktorSifre.Text)
                {
                    doktor = u;
                    break;
                }
            }

           
            if (doktor != null)
            {
                DoktorAnaEkran ekran = new DoktorAnaEkran(doktor);
                ekran.Show();
                this.Hide();
         
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış tekrar giriş yapmayı deneyiniz!!");
               // TbPosta.Clear();
               // TbSifre.Clear();
            }
        }
    }
}

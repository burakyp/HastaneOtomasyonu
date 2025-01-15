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
using v20.Pages;
using v20.Wiev;

namespace v20
{
    /// <summary>
    /// DoktorAnaEkran.xaml etkileşim mantığı
    /// </summary>
    public partial class DoktorAnaEkran : Window
    {
        DoktorBilgileri secilidoktor;
        public DoktorAnaEkran(DoktorBilgileri doktor = null)
        {
            InitializeComponent();
            secilidoktor = doktor;
            TbAd.Text = secilidoktor.DoktorAdi.ToString();
            TbSoyad.Text = secilidoktor.DoktorSoyadi.ToString();
            TbKullaniciadi.Text = $"@{secilidoktor.DoktorKullaniciAdi.ToString()}";
            ImgPP.ImageSource = secilidoktor.Doktorpp;
           //LbGönderilerd.ItemsSource = DoktorVerileri.Doktorlar.Where(a => a.DoktorKullaniciAdi.StartsWith(secilidoktor.DoktorKullaniciAdi, StringComparison.CurrentCultureIgnoreCase));
         
        }

      
    }
}

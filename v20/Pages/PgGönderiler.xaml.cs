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

namespace v20.Pages
{
    /// <summary>
    /// PgGönderiler.xaml etkileşim mantığı
    /// </summary>
    public partial class PgGönderiler : Page
    {
        public PgGönderiler()
        {
            InitializeComponent();

            LbGönderiler.ItemsSource = KisiGönderiVeri.KisiGönderiler;
        }
        
    }
}

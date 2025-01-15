using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace v20.Wiev
{
    public class KisiGönderi
    {
        public string GkisiAd { get; set; }
        public string Gkullaniciad { get; set; }
        public string GkisiSoyad { get; set; }
        public BitmapImage GKisipp { get; set; }
        public string GkisiGönderi { get; set; }

        public DateTime Grandevutarihi { get; set; }

       // public override string ToString() => $"{Grandevutarihi.ToShortDateString()}";
       // public string Gdoktor { get; set; }
        public string Doktorlar { get; set; }

    }
}

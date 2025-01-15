using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace v20.Wiev
{
    public class DoktorBilgileri
    {
        public BitmapImage Doktorpp { get; set; }
        public string DoktorKullaniciAdi { get; set; }
        public string DoktorSifre { get; set; }
        public string DoktorAdi { get; set; }
        public string DoktorSoyadi { get; set; }
        public KisiGönderi KisiGönderi { get; set; }
        //public List<KisiGönderi> Doktorlar
        //{
        //    get
        //    {
        //        return KisiGönderiVeri.KisiGönderiler.Where(p => p.DoktorBilgileri == this).ToList();
        //    }
        //}
        public override string ToString() => DoktorAdi;
    }
}

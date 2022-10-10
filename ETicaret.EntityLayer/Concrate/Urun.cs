using ETicaret.EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.EntityLayer.Concrate
{
    public class Urun :IEntity
    {
       public int UrunId { get; set; }
        public int UrunAdi { get; set; }
        public int UrunKodu { get; set; }
        public int UrunAcıklama { get; set; }
        public int AltKategoriId { get; set; }

        
    }
}

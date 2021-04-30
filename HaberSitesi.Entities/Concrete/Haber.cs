using HaberSitesi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace HaberSitesi.Entities.Concrete
{
    public class Haber:IEntity
    {
        public Haber()
        {
            Yorumlar = new List<Yorum>();
        }
        public int Id { get; set; }
        public string HaberBasligi { get; set; }
        public string HaberAnaResimUrl { get; set; }
        public string HaberIcerik { get; set; }
        public DateTime HaberTarihi { get; set; }

        public int EditorId { get; set; }
        public int KategoriId { get; set; }

        public virtual Editor Editoru { get; set; }
        public virtual Kategori Kategorisi { get; set; }
        public ICollection<Yorum> Yorumlar { get; set; }
    }
}

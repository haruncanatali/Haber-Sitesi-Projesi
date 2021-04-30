using HaberSitesi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace HaberSitesi.Entities.Concrete
{
    public class Kategori:IEntity
    {
        public Kategori()
        {
            Haberleri = new List<Haber>();
        }

        public int Id { get; set; }
        public string KategoriAdi { get; set; }

        public virtual ICollection<Haber> Haberleri { get; set; }
    }
}

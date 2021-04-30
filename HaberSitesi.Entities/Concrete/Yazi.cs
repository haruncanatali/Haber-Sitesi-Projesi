using HaberSitesi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace HaberSitesi.Entities.Concrete
{
    public class Yazi:IEntity
    {
        public int Id { get; set; }
        public string YaziBasligi { get; set; }
        public string YaziIcerigi { get; set; }
        public string YaziResimUrl { get; set; }
        public DateTime YaziTarihi { get; set; }

        public int YazarId { get; set; }

        public virtual Yazar Yazari { get; set; }
    }
}

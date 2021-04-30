using HaberSitesi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace HaberSitesi.Entities.Concrete
{
    public class Yorum:IEntity
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Mesaj { get; set; }
        public DateTime YorumTarihi { get; set; }

        public int HaberId { get; set; }

        public virtual Haber Haberi { get; set; }
    }
}

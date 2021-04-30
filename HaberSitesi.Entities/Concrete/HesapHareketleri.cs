using HaberSitesi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace HaberSitesi.Entities.Concrete
{
    public class HesapHareketleri:IEntity
    {
        public int Id { get; set; }
        public DateTime IslemTarihi { get; set; }
        public int EditorId { get; set; }
        public int YazarId { get; set; }
        public int HesapId { get; set; }
    }
}

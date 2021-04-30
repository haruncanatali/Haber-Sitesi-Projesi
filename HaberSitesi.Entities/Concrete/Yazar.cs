using HaberSitesi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace HaberSitesi.Entities.Concrete
{
    public class Yazar:IEntity
    {

        public Yazar()
        {
            Yazilari = new List<Yazi>();
        }

        public int Id { get; set; }
        public string YazarAdi { get; set; }
        public string YazarSoyadi { get; set; }
        public string YazarBiyografisi { get; set; }
        public string YazarFotoUrl { get; set; }
        public int HesapId { get; set; }
        public virtual ICollection<Yazi> Yazilari { get; set; }
    }
}

using HaberSitesi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace HaberSitesi.Entities.Concrete
{
    public class Editor:IEntity
    {
        public Editor()
        {
            Haberleri = new List<Haber>();
        }

        public int Id { get; set; }
        public string EditorAdi { get; set; }
        public string EditorSoyadi { get; set; }
        public int HesapId { get; set; }

        public virtual ICollection<Haber> Haberleri { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HaberSitesi.WebUI.Models
{
    public class YaziInputModel
    {
        public string YaziBasligi { get; set; }
        public string YaziIcerigi { get; set; }
        public string YaziResimUrl { get; set; }
        public DateTime YaziTarihi { get; set; }

        public string YazarId { get; set; }
    }
}

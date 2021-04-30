using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HaberSitesi.WebUI.Models
{
    public class HaberInputModel
    {
        public string HaberBasligi { get; set; }
        public string HaberAnaResimUrl { get; set; }
        public string HaberIcerik { get; set; }

        public string EditorId { get; set; }
        public string KategoriId { get; set; }
    }
}

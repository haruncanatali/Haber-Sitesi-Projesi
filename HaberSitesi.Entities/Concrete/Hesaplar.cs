using HaberSitesi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace HaberSitesi.Entities.Concrete
{
    public class Hesaplar:IEntity
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}

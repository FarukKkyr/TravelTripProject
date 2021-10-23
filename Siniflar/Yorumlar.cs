using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Siniflar
{
    public class Yorumlar
    {
        [Key]
        public int ID { get; set; }
        public string  KullanıcıAdi { get; set; }
        public string Mail { get; set; }
        public string  yorum { get; set; }
        public int Blogid { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
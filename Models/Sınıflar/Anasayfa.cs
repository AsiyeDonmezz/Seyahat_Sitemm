using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Web;

namespace SeyahatSitem.Models.Sınıflar
{
    public class Anasayfa
    {
        [Key] //Burası benim birincil anahtarım olacak.Entity frameworkte sorun yaşamamak için yazıldı.
        public int ID { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
    }
}

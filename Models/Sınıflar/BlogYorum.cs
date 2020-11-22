using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeyahatSitem.Models.Sınıflar
{
    public class BlogYorum
    {
        //Enumerable ile view içerisinde birden fazla tablodan veri çekilebilecek.
        public IEnumerable<Blog> Deger1 { get; set; }
        public IEnumerable<Yorumlar> Deger2 { get; set; }
        public IEnumerable<Blog>Deger3 { get; set; }
    }


}
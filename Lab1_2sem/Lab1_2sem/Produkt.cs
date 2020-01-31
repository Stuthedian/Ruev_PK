using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2sem
{
    public class Produkt
    {
        public string name;
        public double? objem;
        public double? stoim;

        public List<Sostav> sostav;
        public List<Postavki> postavki;

        public int kol(int codp)
        { return sostav.Where(n => n.bludo == codp).Count(); }

        public int kolnull(int codp)
        { return sostav.Where(n => n.bludo == codp && n.ves == null).Count(); }

        public double? vol(int codp)
        { return sostav.Where(n => n.bludo == codp).Sum(n => n.ves); } 
        
    }
}

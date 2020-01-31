using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2sem
{
    public class Postavshik
    {
        public int cod;
        public string name;
        public string gorod;

        public int kol(int codp)
        { return Sppos.Where(n => n.Codp == codp).Count(); }

        public int kolnull(int codp)
        { return Sppos.Where(n => n.Codp == codp && n.Vol == null).Count(); }

        public decimal vol(int codp)
        { return Sppos.Where(n => n.Codp == codp).Sum(n => n.Vol); } 
    }
}

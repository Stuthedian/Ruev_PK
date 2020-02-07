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

        public int kol(int cod)
        {
            double aa;
            double? a = postavki.Select(n => n.objem).Sum() / sostav.Where(n => n.bludo == cod).Select(nn => nn.ves).First();
            if (a.HasValue)
                aa = a.Value;
            else aa = 0;
            return Convert.ToInt32(Math.Floor(aa));//sostav.Where(n => n.bludo == cod).Count();
        }

        public int kolnull(int cod)
        { return sostav.Where(n => n.bludo == cod).Count(); }

        public double? vol(int cod)
        { return sostav.Where(n => n.bludo == cod).Sum(n => n.ves); } 

        public double? objem_post(int postavshik)
        {
            var post = postavki.Where(p => p.postavshik == postavshik);
            return post.Any() ? post.Sum(p => p.objem) : null;
        }

        public double? objem_post(int postavshik, DateTime from, DateTime to)
        {
            var post = postavki.Where(p => p.postavshik == postavshik &&
                    p.date >= from && p.date <= to);
            return post.Any() ? post.Sum(p => p.objem) : null;
        }

        public double? max_post(int postavshik, DateTime from, DateTime to)
        {
            var post = postavki.Where(p => p.postavshik == postavshik &&
                    p.date >= from && p.date <= to);
            return post.Any() ? post.Max(p => p.objem) : null;
        }
    }
}

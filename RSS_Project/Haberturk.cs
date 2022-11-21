using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSS_Project
{
     class Haberturk:News,IFeatures
    {
        public Haberturk()
        {
            this.Name = "Habertürk";
        }

        public string Features()
        {
            return "www.haberturk.com/rss/kategori/teknoloji.xml";
        }
    }
}

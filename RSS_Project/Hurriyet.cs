using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSS_Project
{
     class Hurriyet:News,IFeatures
    {
        public Hurriyet()
        {
            this.Name = "Hürriyet ";
        }

        public string Features()
        {
            return "https://www.hurriyet.com.tr/rss/anasayfa";
        }
    }
}

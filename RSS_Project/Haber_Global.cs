using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSS_Project
{
    class Haber_Global : News, IFeatures
    {
        public Haber_Global()
        {
            this.Name = "Haber-Global";
        }
        public string Features()
        {
            return "www.haberglobal.com.tr/rss";
        }
    }
}

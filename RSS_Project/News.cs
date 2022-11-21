using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSS_Project
{
   public class News
    {
        public string Name { get; set; }

        // class içine override ettim => proje ismi combobox a gelmesin 
        public override string ToString()
        {
            return this.Name;
        }
    }

  
   
}

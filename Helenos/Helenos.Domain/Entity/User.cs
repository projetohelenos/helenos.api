using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   

namespace Helenos.Domain.Entity
{    
    class User
    {
        
        public int id { get; set; }
        
        public string name { get; set; }
        
        public string login { get; set; }

        public string password { get; set; }

        public bool status { get; set; }

    }
}

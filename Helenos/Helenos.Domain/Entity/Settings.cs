using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helenos.Domain.Entity
{
    class Settings
    {           

        public virtual User User { get; set; }

        public virtual ChooseSettings ChooseSettings { get; set; }

        public string value { get; set; }

        public bool status { get; set; }

    }
}

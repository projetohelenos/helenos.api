using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helenos.Domain.Entity
{
    class Records
    {
        public virtual User User { get; set; }

        public virtual TypeRecords TypeRecords { get; set; }

        public DateTime dateTime { get; set; }

        public string observations { get; set; }

        public bool outOfTime { get; set; }       

        public bool status { get; set; }             

    }
}

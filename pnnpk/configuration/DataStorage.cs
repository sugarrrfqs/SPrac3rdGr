using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pnnpk.configuration
{
    public class DataStorage : Memory
    {
        public DataStorage(string name, string manufacturer, string capacity)
             : base(name, manufacturer, capacity)
        {

        }
    }
}

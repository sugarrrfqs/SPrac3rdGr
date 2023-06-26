using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pnnpk.configuration
{
    public class Memory : Hardware
    {
        private string _capacity;
        public string Capacity
        {
            get
            {
                return _capacity;
            }
            set
            {
                _capacity = value;
                //OnPropertyChanged("Capacity");
            }
        }

        public Memory(string name, string manufacturer, string capacity)
            : base(name, manufacturer)
        {
            Capacity = capacity;
        }
    }
}

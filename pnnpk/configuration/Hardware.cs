using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pnnpk.configuration
{
    public class Hardware
    {
        private string _name;
        private string _manufacturer;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                //OnPropertyChanged("Name");
            }
        }
        public string Manufacturer
        {
            get
            {
                return _manufacturer;
            }
            set
            {
                _manufacturer = value;
                //OnPropertyChanged("Manufacturer");
            }
        }

        public Hardware(string name, string manufacturer)
        {
            Name = name;
            Manufacturer = manufacturer;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pnnpk.configuration
{
    public class PCAssembly
    {
        private CPU[] _listCPU;
        private RAM[] _listRAM;
        private GPU[] _listGPU;
        private DataStorage[] _listDS;

        public CPU[] ListCPU { get; private set; }
        public RAM[] ListRAM { get; private set; }
        public GPU[] ListGPU { get; private set; }
        public DataStorage[] ListDS { get; private set; }
    }
}

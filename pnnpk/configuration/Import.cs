using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace pnnpk.configuration
{
    public static class Import
    {
        public static void ImportFile()
        {
            string path = @""; // путь к файлу
            string json = File.ReadAllText(path);
            PCAssembly assembly = JsonSerializer.Deserialize<PCAssembly>(json);

            CPU cpu = assembly.ListCPU.First();
            // string cpuName = cpu.Name; типо такой строки надо в бд закинуть
            GPU gpu = assembly.ListGPU.First();
            string ram = assembly.ListRAM.Sum(r => Convert.ToInt64(r.Capacity)).ToString();
            // тут суммарный объем вывожу, так как плашек несколько обычно
            DataStorage ds = assembly.ListDS.First();
        }

    }
}

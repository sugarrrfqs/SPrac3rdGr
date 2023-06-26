using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Data.SqlClient;

namespace pnnpk.configuration
{
    public static class Import
    {
        
        public static void ImportFile(string path)
        {
            SqlCommandBuilder builder = null;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
       
            string json = File.ReadAllText(path);//@"C:\Users\Sasha\Downloads\conf.json"
            PCAssembly assembly = JsonSerializer.Deserialize<PCAssembly>(json);

            CPU cpu = assembly.ListCPU.First();
            // string cpuName = cpu.Name; типо такой строки надо в бд закинуть
            GPU gpu = assembly.ListGPU.First();
            string ram = assembly.ListRAM.Sum(r => Convert.ToInt64(r.Capacity.Replace(" GB",""))).ToString();
            // тут суммарный объем вывожу, так как плашек несколько обычно
            DataStorage ds = assembly.ListDS.First();

            string query = $"INSERT INTO [СправочникСистемныеБлоки] VALUES('{cpu.Name + " " + cpu.Manufacturer}','{gpu.Name + " " + gpu.Manufacturer}','{ram}','{ds.Name + " " + ds.Capacity}')";
            dataAdapter.InsertCommand = new SqlCommand(query, MainForm.connection);
            dataAdapter.InsertCommand.ExecuteNonQuery();

        }

    }
}

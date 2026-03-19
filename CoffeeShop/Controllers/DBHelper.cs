using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop.Controllers
{
    public static class DBHelper
    {
        private static string _connectionString = null;
        public static OleDbConnection GetConnection()
        {
            if (_connectionString == null)
            {
                string startingPath = GetStartingPath();
                string dbPath = Path.Combine(startingPath, "CoffeeShop.accdb");

                // verification of the file
                if (!File.Exists(dbPath))
                {
                    throw new Exception($"DB not found: {dbPath}");
                }
                _connectionString = $"provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};";
            }
            return new OleDbConnection(_connectionString);
        }

        private static string GetStartingPath()
        {
            string exePath = Application.StartupPath;

            string projectPath = Path.GetFullPath(Path.Combine(exePath, @"..\..\"));

            return projectPath;
        }
    }
}

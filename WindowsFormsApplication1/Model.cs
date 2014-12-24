using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Model 
    {
        Database _database = new Database();

        public void Init()
        {
            _database.Init();
        }
        public bool IsRegister(out string id)
        {
            id = "";
            bool isExist = File.Exists("profile.dat");
            if (!isExist) return false;
            StreamReader streamReader = new StreamReader("profile.dat");
            id = streamReader.ReadLine();
            streamReader.Close();

            return true;
        }
    }

    
}

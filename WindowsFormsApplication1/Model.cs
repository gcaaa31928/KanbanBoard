using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Model 
    {
        private Database _database = new Database();
        private int _id = -1;
        public Database Database
        {
            get { return _database; }
            set { _database = value; }
        }

        public void Init()
        {
            _database.Open();
        }
        public bool IsRegister(out string id,out string nickName)
        {
            id = "";
            nickName = "";

            bool isExist = File.Exists("profile.dat");
            if (!isExist)
            {
                Debug.WriteLine("profile.data is not exist");
                return false;
            }
            Debug.WriteLine("profile.data is exist");
            StreamReader streamReader = new StreamReader("profile.dat");
            id = streamReader.ReadLine();
            nickName = streamReader.ReadLine();
            streamReader.Close();
            _id = Int32.Parse(id);
            return true;
        }

        public void Register(string nickName,out int id)
        {
            int idCount = _database.GetIdCount();
            _database.InsertMember(idCount, nickName);
            id = idCount;
            StreamWriter streamWriter = new StreamWriter("profile.dat");
            streamWriter.WriteLine(id);
            streamWriter.WriteLine(nickName);
            streamWriter.Close();
            _id = id;
            //TODO(gca):write profile.dat
        }

        public void CreateProject(int uid)
        {
            int pid = _database.GetProjectNum();
            _database.InsertTask(pid, uid, 0, "", "", 0);

        }

        public void CreateTask(int uid, int pid,string taskName,string taskDepscribe)
        {
            int taskId = _database.GetTaskNum(pid);
            _database.InsertTask(pid, uid, taskId, taskName, taskDepscribe, 1);
        }

        public void AddMember(int memberId)
        {
            int projectId=_database.GetProjectId(_id);
            _database.InsertProjectMember(projectId, memberId);

        }

        public List<string> GetMembersName()
        {

        }

    }

    
}

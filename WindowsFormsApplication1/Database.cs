using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Database
    {
        private const string _dbHost = "127.0.0.1";
        private const string _dbUser = "root";
        private const string _dbPass = "";
        private const string _dbName = "kanban";
        private MySqlConnection _conn;
        public void Open()
        {
            string connStr = "Server=" + _dbHost +
                            ";Uid=" + _dbUser +
                            ";Pwd=" + _dbPass + 
                            ";database=" + _dbName;

            _conn = new MySqlConnection(connStr);
            MySqlCommand command = _conn.CreateCommand();
            try
            {
                _conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Debug.WriteLine("無法連線到資料庫.");
                        break;
                    case 1045:
                        Debug.WriteLine("使用者帳號或密碼錯誤,請再試一次.");
                        break;
                }
            } 
            
            Debug.WriteLine(_conn.Ping());

            //command.CommandText = "Update user SET nickname='Admin' WHERE id = 0 ";
            //command.ExecuteNonQuery();
        }

        public void Close()
        {
            _conn.Close();
        }
        
        public string GetNickName(string id)
        {
            Open();
            string nickName = null;
            MySqlCommand command = _conn.CreateCommand();
            command.CommandText = "Select nickname FROM user WHERE id = " + id;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                //use database to get nick name
                nickName = reader.GetString(0);
            }
            Close();
            return nickName;

        }

        public int GetIdCount()
        {
            Open();
            int idCount = 0;
            MySqlCommand command = _conn.CreateCommand();
            command.CommandText = "Select COUNT(id) FROM user";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                idCount = reader.GetInt32(0);
            }
            Close();
            return idCount;
        }

        public void InsertMember(int id, string nickName)
        {
            Open();
            MySqlCommand command = _conn.CreateCommand();
            command.CommandText = "Insert INTO user (id,nickname,pid) VALUES (" +
                id.ToString() + "," +
                "'" + nickName + "'" +
                ", 0)";
            Debug.WriteLine(command.CommandText);
            command.ExecuteNonQuery();
            Close();
        }

        public int GetProjectNum()
        {
            int count = 0;
            MySqlCommand command = _conn.CreateCommand();
            command.CommandText = "Select COUNT(pid) FROM task";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                count = reader.GetInt32(0);
            }
            return count;
        }

        public void InsertTask(int pid, int uid, int taskId, string taskName, string taskDepscribe,int taskstate)
        {
            MySqlCommand command = _conn.CreateCommand();
            command.CommandText = "Insert INTO task (pid,uid,taskid,taskname,taskdescription,taskstate) VALUES (" +
                pid.ToString() + "," +
                uid.ToString() + "," +
                taskId.ToString() + "," +
                taskName + "," +
                taskDepscribe + "," +
                taskstate.ToString() + "," + ")";
            command.ExecuteNonQuery();
        }

        public int GetTaskNum(int pid)
        {
            int taskCount = 0;
            MySqlCommand command = _conn.CreateCommand();
            command.CommandText = "Select COUNT(taskid) FROM project Where pid = "+pid.ToString();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                taskCount = reader.GetInt32(0);
            }
            return taskCount;
        }

        public int GetProjectMemberNum(int pid)
        {
            int projectMemberCount = 0;
            MySqlCommand command = _conn.CreateCommand();
            command.CommandText = "Select COUNT(uid) FROM project Where pid = " + pid.ToString();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                projectMemberCount = reader.GetInt32(0);
            }
            return projectMemberCount;
        }

        public void InsertProjectMember(int pid, int uid)
        {
            MySqlCommand command = _conn.CreateCommand();
            command.CommandText = "Insert INTO project (pid,uid) VALUES (" +
                pid.ToString() + "," +
                uid.ToString() + ")";
            command.ExecuteNonQuery();
        }

        public int GetProjectId(int uid)
        {
            int projectId = 0;
            MySqlCommand command = _conn.CreateCommand();
            command.CommandText = "Select pid FROM project Where uid = " + uid.ToString();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                projectId = reader.GetInt32(0);
            }
            return projectId;
        }
        /* 
        //不知道哪裡錯
        public List<string> GetProjectMembersName(int uid)
        {
            List<string> membersName = new List<string>();
            MySqlCommand command = _conn.CreateCommand();
            command.CommandText = "Select COUNT(uid) FROM project Where pid = " + pid.ToString();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                projectMemberCount = reader.GetInt32(0);
            }
            return projectMemberCount;
        }
        */
        public bool AddTask(Task task)
        {
            //這邊實作sql的insert，並寫入task的primeKey
            return true;
        }

        public bool EditTask(Task task, string title, string assignee, int priority, string deadline, string description)
        {
            //這邊實作sql的Edit
            return true;
        }

        public bool ChangeTaskState(Task task,TaskState newState)
        {
            //這邊實作sql的Edit
            return true;
        }
        
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanApp
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
                            ";database=" + _dbName +
                            ";Charset=utf8";
                            

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

        public void RegisterUser(int id, string nickName)
        {
            Open();
            MySqlCommand command = _conn.CreateCommand();
            command.CommandText = "Insert INTO user (id,nickname,pid,state) VALUES (" +
                id.ToString() + "," +
                "'" + nickName + "'" +
                ", -1,1)";
            Debug.WriteLine(command.CommandText);
            command.ExecuteNonQuery();
            Close();
        }

        public int GetProjectNum()
        {
            Open();
            int count = 0;
            MySqlCommand command = _conn.CreateCommand();
            command.CommandText = "Select COUNT(pid) FROM project";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                count = reader.GetInt32(0);
            }
            Close();
            return count;
        }

        public List<Task> GetProjectTask(int pid)
        {
            List<Task> tasks = new List<Task>();
            Open();
            string nickName = null;
            MySqlCommand command = _conn.CreateCommand();
            command.CommandText = "Select * FROM task WHERE pid = " + pid;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Task task = new Task();
                task.PrimeKey = reader.GetInt32(1);
                task.Assignee = reader.GetString(2);
                task.Priority = reader.GetInt32(3);
                task.Deadline = reader.GetString(4);
                task.Description = reader.GetString(5);
                task.TaskState = (TaskState)reader.GetInt32(6);
                task.Title = reader.GetString(7);
                tasks.Add(task);
                //use database to get nick name
            }
            Close();
            return tasks;
        }


        public void InsertTask(int pid, int uid, int taskId, string taskName, string taskDepscribe,int taskstate)
        {
            Open();
            MySqlCommand command = _conn.CreateCommand();
            command.CommandText = "Insert INTO task (pid,uid,taskid,taskname,taskdescription,title,taskstate) VALUES (" +
                pid.ToString() + "," +
                uid.ToString() + "," +
                taskId.ToString() + "," +
                taskName + "," +
                taskDepscribe + "," +
                taskstate.ToString() + ")";
            command.ExecuteNonQuery();
            Close();
        }

        public int GetTaskNum(int pid)
        {
            Open();
            int taskCount = 0;
            MySqlCommand command = _conn.CreateCommand();
            command.CommandText = "Select COUNT(taskid) FROM task Where pid = "+pid.ToString();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                taskCount = reader.GetInt32(0);
            }
            Close();
            return taskCount;
        }

        public int GetProjectMemberNum(int pid)
        {
            Open();
            int projectMemberCount = 0;
            MySqlCommand command = _conn.CreateCommand();
            command.CommandText = "Select COUNT(uid) FROM project Where pid = " + pid.ToString();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                projectMemberCount = reader.GetInt32(0);
            }
            Close();
            return projectMemberCount;
        }

        public void InsertProject(int pid, int uid,string name)
        {
            Open();
            MySqlCommand command = _conn.CreateCommand();
            command.CommandText = "Insert INTO project (pid,uid,name) VALUES ( " +
                pid.ToString() + " , " +
                uid.ToString() + " , " +
                "'" + name + "'" + " )";
            command.ExecuteNonQuery();

            command = _conn.CreateCommand();
            command.CommandText = "Update user Set pid = " +
                pid.ToString() + " Where id = "+uid.ToString();
            command.ExecuteNonQuery();
            Close();
        }

        public int GetProjectId(int uid)
        {
            Open();
            int projectId = 0;
            MySqlCommand command = _conn.CreateCommand();
            command.CommandText = "Select pid FROM user Where id = " + uid.ToString();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                projectId = reader.GetInt32(0);
            }
            Close();
            return projectId;
        }

        public string GetProjectName(int pid)
        {
            Open();
            string projectName = "None";
            MySqlCommand command = _conn.CreateCommand();
            command.CommandText = "Select DISTINCT name FROM project Where pid = " + pid.ToString();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                projectName = reader.GetString(0);
            }
            Close();
            return projectName;
        }

        public List<string> GetProjectMembersName(int pid)
        {
            Open();
            List<string> membersName = new List<string>();
            MySqlCommand command = _conn.CreateCommand();
            command.CommandText = "Select user.nickname FROM project,user " +
                                  "Where project.uid = user.id AND " +
                                  "project.pid = " + pid.ToString();
            
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    membersName.Add(reader.GetString(0));
                }
            }
            Close();
            return membersName;
        }

        public List<int> GetProjectMembersState(int pid)
        {
            Open();
            List<int> membersState = new List<int>();
            MySqlCommand command = _conn.CreateCommand();
            command.CommandText = "Select user.state FROM project,user " +
                                  "Where project.uid = user.id AND " +
                                  "project.pid = " + pid.ToString();

            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    membersState.Add(reader.GetInt32(0));
                }
            }
            Close();
            return membersState;
        }

        public void UpdateUserState(int uid, int state)
        {
            Open();
            MySqlCommand command = _conn.CreateCommand();
            command = _conn.CreateCommand();
            command.CommandText = "Update user Set state = " +
                state.ToString() + " Where id = " + uid.ToString();
            command.ExecuteNonQuery();
            Close();
        }

        public int GetTaskCount(int pid)
        {
            Open();
            int taskCount = 0;
            MySqlCommand command = _conn.CreateCommand();
            command.CommandText = "Select COUNT(tid) FROM task Where pid = " + pid.ToString();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                taskCount = reader.GetInt32(0);
            }
            Close();
            return taskCount;
        }

        public bool AddTask(Task task,int pid)
        {
            //這邊實作sql的insert，並寫入task的primeKey
            int taskCount = GetTaskCount(pid);

            Open();



            MySqlCommand command = _conn.CreateCommand();
            command.CommandText = "Insert INTO task (pid,tid,assignee,description,priority,deadline,title,taskstate) VALUES (" +
                pid.ToString() + "," +
                taskCount.ToString() + "," +
                "'"+task.Assignee.ToString() +"'"+ "," +
                "'" + task.Description + "'" + "," +
                task.Priority+ "," +
                "'" + task.Deadline + "'" + "," +
                "'" + task.Title + "'" + "," +
                (int)(task.TaskState)+ ")";
            command.ExecuteNonQuery();
            Close();
            task.PrimeKey = taskCount;
            return true;
        }

        public bool EditTask(Task task, int pid,string title, string assignee, int priority, string deadline, string description)
        {
            //這邊實作sql的Edit

            Open();
            MySqlCommand command = _conn.CreateCommand();

            command = _conn.CreateCommand();
            command.CommandText = "Update task Set "+
                " pid = " + pid.ToString() +
                " ,title = '" + title + "'" +
                " ,assignee = '" + assignee + "'" +
                " ,priority = " + priority +
                " ,deadline = '" + deadline + "'" +
                " ,description = '" + description.ToString() + "'"+
                
                " Where tid = " + task.PrimeKey.ToString();
            command.ExecuteNonQuery();
            Close();

            return true;
        }

        public bool ChangeTaskState(Task task, TaskState newState)
        {
            Open();
            MySqlCommand command = _conn.CreateCommand();

            command = _conn.CreateCommand();
            command.CommandText = "Update task Set " +
                "taskstate = " + ((int)newState).ToString() +

                " Where tid = " + task.PrimeKey.ToString();
            command.ExecuteNonQuery();
            Close();

            return true;
        }
        
    }
}

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
        public void Init()
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
            _conn.Close();
        }

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

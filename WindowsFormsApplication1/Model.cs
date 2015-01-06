using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanApp
{
    public class Model 
    {
        private Database _database = new Database();
        private int _id = 0;
        private int _pid = -1;
        private List<Task> _todoList = new List<Task>();
        private List<Task> _doingList = new List<Task>();
        private List<Task> _doneList = new List<Task>();
        private Task _targetTask;

        public Task TargetTask
        {
            get { return _targetTask; }
            set { _targetTask = value; }
        }

        public List<Task> TodoList
        {
            get { return _todoList; }
        }

        public List<Task> DoingList
        {
            get { return _doingList; }

        }
        public List<Task> DoneList
        {
            get { return _doneList; }
        }

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
            _database.RegisterUser(idCount, nickName);
            id = idCount;
            StreamWriter streamWriter = new StreamWriter("profile.dat");
            streamWriter.WriteLine(id);
            streamWriter.WriteLine(nickName);
            streamWriter.Close();
            _id = id;
            //TODO(gca):write profile.dat
        }

        public void CreateProject(int uid,string name)
        {
            int pid = _database.GetProjectNum();
            _database.InsertProject(pid, uid, name);

        }

        public void CreateTask(int uid, int pid,string taskName,string taskDepscribe)
        {
            int taskId = _database.GetTaskNum(pid);
            _database.InsertTask(pid, uid, taskId, taskName, taskDepscribe, 1);
        }

        public void AddMember(int memberId)
        {
            string projectName = "None";
            int projectId=_database.GetProjectId(_id);
            projectName = _database.GetProjectName(projectId);

            _database.InsertProject(projectId, memberId, projectName);
            
        }

        public List<string> GetMembersName()
        {
            int pid = _database.GetProjectId(_id);
            return _database.GetProjectMembersName(pid);
        }

        public List<int> GetMembersState()
        {
            int pid = _database.GetProjectId(_id);
            return _database.GetProjectMembersState(pid);
        }

        public string GetProjectName()
        {
            int pid = -1;
            string name = "None";
            pid=_database.GetProjectId(_id);
            name = _database.GetProjectName(pid);
            _pid = pid;
            return name;
        }

        public void ChangeUserState(bool state)
        {
            if (state) _database.UpdateUserState(_id, 1);
            else _database.UpdateUserState(_id, 0);

        }
        public bool AddTask(string title, string assignee, int priority, string deadline, string description)
        {
            Task newtask = new Task();
            newtask.Title = title;
            newtask.Deadline = deadline;
            newtask.Assignee = assignee;
            newtask.Priority = priority;
            newtask.Description = description;
            newtask.TaskState = TaskState.ToDo;
            bool isSuccess = _database.AddTask(newtask,_pid);
            if (isSuccess)
            {
                _todoList.Add(newtask);
                RefreshTaskList();
            }
            return isSuccess;
        }

        public bool EditTask( string title, string assignee, int priority, string deadline, string description)
        {

            bool isSuccess = _database.EditTask(_targetTask, _pid, title, assignee, priority, deadline, description);
            if (isSuccess)
            {
                _targetTask.Title = title;
                _targetTask.Deadline = deadline;
                _targetTask.Assignee = assignee;
                _targetTask.Priority = priority;
                _targetTask.Description = description;
                RefreshTaskList();
            }
            return isSuccess;
        }



        public bool ChangeTaskState(TaskState destinationState)
        {
            bool isSuccess = _database.ChangeTaskState(_targetTask, destinationState);
            if (isSuccess)
            {
                RefreshTaskList();

            }
            return isSuccess;
        }

        //更新todo doing done 並依照priority排序 priory越小越前面
        public void RefreshTaskList()
        {

            List<Task> tasks = _database.GetProjectTask(_pid);

            _todoList.Clear();
            _doingList.Clear();
            _doneList.Clear();

            foreach (Task task in tasks)
            {
                if (_targetTask != null)
                {
                    if (task.PrimeKey == _targetTask.PrimeKey) _targetTask = task;
                }
                if (task.TaskState == TaskState.ToDo)
                {
                    _todoList.Add(task);
                }
                else if (task.TaskState == TaskState.Doing)
                {
                    _doingList.Add(task);
                }
                else if (task.TaskState == TaskState.Done)
                {
                    _doneList.Add(task);
                }
            }

            _todoList.Sort(Comparison);
            _doingList.Sort(Comparison);
            _doneList.Sort(Comparison);

        }
        public int Comparison(Task x, Task y)
        {
            if (x.Priority > y.Priority)
            {
                return 1;
            }
            else if (x.Priority < y.Priority)
            {
                return -1;
            }
            return 0;
        }

    }

    
}

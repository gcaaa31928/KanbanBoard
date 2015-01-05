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
        private List<Task> _todoList = new List<Task>();
        private List<Task> _doingList = new List<Task>();
        private List<Task> _doneList = new List<Task>();


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

        public bool AddTask(string title, string assignee, int priority, string deadline, string description)
        {
            Task newtask = new Task();
            newtask.Title = title;
            newtask.Deadline = deadline;
            newtask.Assignee = assignee;
            newtask.Priority = priority;
            newtask.Description = description;
            newtask.TaskState = TaskState.ToDo;
            bool isSuccess =  _database.AddTask(newtask);
            if (isSuccess)
            {
                _todoList.Add(newtask);
                RefreshTaskList();
            }
            return isSuccess;
        }

        public bool EditTask(Task task, string title, string assignee, int priority, string deadline, string description)
        {

            bool isSuccess = _database.EditTask(task, title, assignee, priority, deadline, description);
            if (isSuccess)
            {
                task.Title = title;
                task.Deadline = deadline;
                task.Assignee = assignee;
                task.Priority = priority;
                task.Description = description;
                RefreshTaskList();
            }
            return isSuccess;
        }



        public bool ChangeTaskState(Task task, TaskState destinationState)
        {
            bool isSuccess = _database.ChangeTaskState(task, destinationState);
            if (isSuccess)
            {
                if (task.TaskState == TaskState.ToDo)
                {
                    _todoList.Remove(task);
                }
                else if (task.TaskState == TaskState.Doing)
                {
                    _doingList.Remove(task);
                }
                else if (task.TaskState == TaskState.Done)
                {
                    _doneList.Remove(task);
                }
                task.TaskState = destinationState;
                if (destinationState == TaskState.ToDo)
                {
                    _todoList.Add(task);
                }
                else if (destinationState == TaskState.Doing)
                {
                    _doingList.Add(task);
                }
                else if (destinationState == TaskState.Done)
                {
                    _doneList.Add(task);
                }
                RefreshTaskList();
                
            }
            return isSuccess;
        }

        //更新todo doing done 並依照priority排序 priory越小越前面
        private void RefreshTaskList()
        {
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
            else if(x.Priority < y.Priority)
            {
                return -1;
            }
            return 0;
        }


    }

    
}

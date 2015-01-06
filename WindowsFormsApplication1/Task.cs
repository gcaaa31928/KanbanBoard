using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanApp
{
    public enum TaskState
    { 
        ToDo,
        Doing,
        Done
    }

    public class Task
    {
        private int _primeKey;

        public int PrimeKey
        {
            set { _primeKey = value; }
            get { return _primeKey; }
        }
        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private string _assignee;

        public string Assignee
        {
            get { return _assignee; }
            set { _assignee = value; }
        }


        private int _priority;

        public int Priority
        {
            get { return _priority; }
            set { _priority = value; }
        }
        private string _deadline;

        public string Deadline
        {
            get { return _deadline; }
            set { _deadline = value; }
        }
        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private TaskState _taskState;

        public TaskState TaskState
        {
            get { return _taskState; }
            set { _taskState = value; }
        }
    }
}

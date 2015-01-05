using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Sticky : UserControl
    {
        private Task _task = new Task();
        private bool _isMoving = false;

        private MouseEventArgs _lastMouseLocation = null;

        public bool IsMoving
        {
            get { return _isMoving; }
        }

        internal Task Task
        {
            get { return _task; }
            set { 
                _task = value;
                RefreshData();
            }
        }

        public Sticky()
        {
            InitializeComponent();
             
            //AllowDrop = true;
            this.Focus();
        }

        public Sticky(Task task)
        {
            InitializeComponent();
            _task = task;
            RefreshData();
            //AllowDrop = true;
            this.Focus();
        }

        public void RefreshData()
        {
            _titleLabel.Text = _task.Title;
            _assigneeLabel.Text = _task.Assignee;
            _deadlineLabel.Text = _task.Deadline;      
        }

        private void Sticky_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.Capture && e.Button == MouseButtons.Right)
            {
                //DoDragDrop(ctrl, DragDropEffects.Move);//定義拖曳圖示
                this.Top = e.Y + this.Location.Y - _lastMouseLocation.Y;
                this.Left = e.X + this.Location.X - _lastMouseLocation.X;
            }
        }

        private void Sticky_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                _lastMouseLocation = e;//按下時記錄位置
            }
        }

        private void Sticky_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
            }

        }



    }
}

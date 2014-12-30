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

        public string Title
        {
            get {
                return _titleLabel.Text; 
            }
            set {
                _titleLabel.Text = value; 
            }
        }

        public string DeadLine
        {
            get {
                return _deadlineLabel.Text; 
            }
            set {
                _deadlineLabel.Text = value;
            }
        }

        public string Assignee
        {
            get { 
                return _assigneeLabel.Text; 
            }
            set {
                _assigneeLabel.Text = value; 
            }
        }
        
        private bool _isDrop = false;
        private Point _lastMouseLocation = new Point(0,0);

        public Sticky()
        {
            InitializeComponent();
             
            //AllowDrop = true;
            this.Focus();
        }



        private void Sticky_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDrop)
            {
                if (Math.Abs(_lastMouseLocation.X - e.Location.X) >= 3 && Math.Abs(_lastMouseLocation.Y - e.Location.Y) >= 3)
                {
                    this.Location = new Point(Location.X + e.Location.X - _lastMouseLocation.X, Location.Y + e.Location.Y - _lastMouseLocation.Y);
                }

            }
        }

        private void Sticky_MouseDown(object sender, MouseEventArgs e)
        {
            _isDrop = true;
            _lastMouseLocation = e.Location;
        }

        private void Sticky_MouseUp(object sender, MouseEventArgs e)
        {
            _isDrop = false;

        }

        private void _textlable_Click(object sender, EventArgs e)
        {

        }

        private void _deadlineLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

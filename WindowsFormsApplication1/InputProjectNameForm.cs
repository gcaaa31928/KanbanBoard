using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanbanApp
{
    public partial class InputProjectNameForm : Form
    {
        public InputProjectNameForm()
        {
            InitializeComponent();
        }

        public string ProjectName
        {
            get { return _projectNameTextBox.Text; }

            set { }
        }

        private void _createButton_Click(object sender, EventArgs e)
        {

        }
    }
}

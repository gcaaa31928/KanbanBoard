using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class NewTaskForm : Form
    {


        private PresentationModel _presentationModel;


        public NewTaskForm(PresentationModel presentationModel)
        {
            _presentationModel = presentationModel;
            InitializeComponent();

        }

        //如果此為修改表格，則應先填入原本資料
        private void RefreshData()
        {
            if (_presentationModel.IsEdit())
            {
                Task task = _presentationModel.GetTargetTask();
                _titleBox.Text = task.Title;
                _assigneeComboBox.SelectedText = task.Assignee;
                _priorityComboBox.SelectedIndex = task.Priority;
                _descriptionTextBox.Text = task.Description;
                _deadline.Value = Convert.ToDateTime(task.Deadline);

            }
        }


        private void _editButton_Click(object sender, EventArgs e)
        {
            bool isSuccess = _presentationModel.AddorEditTask(_titleBox.Text, _assigneeComboBox.Text, _priorityComboBox.SelectedIndex+1, _deadline.Value.ToString(), _descriptionTextBox.Text);

            if (!isSuccess)
            {
                MessageBox.Show(_presentationModel.ErrorString);
            }
            else
            {
                Close();
            }
        }
    }
}

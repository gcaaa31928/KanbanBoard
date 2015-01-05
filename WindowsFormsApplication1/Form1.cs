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
    public partial class KanBanBoard : Form
    {
        private PresentationModel _presentationModel;



        public KanBanBoard(PresentationModel presentationModel)
        {
            _presentationModel = presentationModel;
            _presentationModel.RefreshStickies += RefreshStickies;
            InitializeComponent();
        }

        private void KanBanBoard_Load(object sender, EventArgs e)
        {
            _presentationModel.Init();
            RefreshControls();
        }

        private void RefreshControls()
        {
            _registerToolStripButton.Enabled = _presentationModel.IsRegisterButtonEnable;
            _idToolStripTextBox.Text = _presentationModel.IdText;
            _nickNameToolStripTextBox.Text = _presentationModel.NickNameText;
        }

        private void _menuToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        /// <summary>
        /// 按下register按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterToolStripButtonClick(object sender, EventArgs e)
        {
            _presentationModel.Register();
            RefreshControls();
        }

        private void NewProjectToolStripButtonClick(object sender, EventArgs e)
        {
            _presentationModel.CreateProject();
            RefreshControls();
        }

        private void AddButtonClick(object sender, EventArgs e)
        {

        }

        private void NickNameToolStripTextBoxClick(object sender, EventArgs e)
        {
            _presentationModel.NickNameText = _nickNameToolStripTextBox.Text;
        }

        private void NickNameToolStripTextBoxTextChanged(object sender, EventArgs e)
        {
            _presentationModel.NickNameText = _nickNameToolStripTextBox.Text;
        }

        private void _todoLabel_DoubleClick(object sender, EventArgs e)
        {

            _presentationModel.ConcelEditState();
            NewTaskForm newTaskForm = new NewTaskForm(_presentationModel);
            newTaskForm.Show();
            
            //this.Controls.Add(sticky);
            
            
            //RefreshSticky 必須更新所有sticky
        }

        private void Sticky_DoubleClick(object sender, EventArgs e)
        {
            Sticky sticky = (Sticky)sender;
            _presentationModel.SetEditState(sticky.Task);
            NewTaskForm newTaskForm = new NewTaskForm(_presentationModel);
            newTaskForm.Show();
            //RefreshSticky 必須更新所有sticky
        }

        private void Sticky_Click(object sender, EventArgs e)
        {
            Sticky sticky = (Sticky)sender;
            _presentationModel.SetEditState(sticky.Task);

            //RefreshSticky 必須更新所有sticky
        }

        private void Sticky_MouseDown(object sender, MouseEventArgs e)
        {
             Sticky sticky = ((Sticky)sender);
             if (e.Button == MouseButtons.Right)
             {
                 _presentationModel.SetEditState(sticky.Task);
                 /*
                 if (sticky.Task.TaskState == TaskState.ToDo)
                 {
                     _todoGroupBox.Controls.Remove(sticky);
                 }
                 else if (sticky.Task.TaskState == TaskState.Doing)
                 {
                     _doingGroupBox.Controls.Remove(sticky);
                 }
                 else if (sticky.Task.TaskState == TaskState.Done)
                 {
                     _doneGroupBox.Controls.Remove(sticky);
                 }
                  * */
                 this.Controls.Add(sticky);
                 sticky.BringToFront();
             }
            //RefreshSticky 必須更新所有sticky

        }

        private void Sticky_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                Sticky sticky = ((Sticky)sender);
                this.Controls.Remove(sticky);
                bool isSuccess = false;

                if (GroupBoxRectangle(_todoGroupBox).Contains(sticky.Left + sticky.Width / 2, sticky.Top + sticky.Height / 2))
                {
                    isSuccess = _presentationModel.ChangeTaskState(sticky.Task, TaskState.ToDo);
                }
                else if (GroupBoxRectangle(_doingGroupBox).Contains(sticky.Left + sticky.Width / 2, sticky.Top + sticky.Height / 2))
                {
                    isSuccess = _presentationModel.ChangeTaskState(sticky.Task, TaskState.Doing);
                }
                else if (GroupBoxRectangle(_doneGroupBox).Contains(sticky.Left + sticky.Width / 2, sticky.Top + sticky.Height / 2))
                {
                    isSuccess = _presentationModel.ChangeTaskState(sticky.Task, TaskState.Done);
                }
                else
                {
                    //如果都不再以上區域當作沒發生
                    return;

                }
                if (!isSuccess)
                {
                    MessageBox.Show(_presentationModel.ErrorString);
                }
                
                //RefreshSticky 必須更新所有sticky
            }
        }

        private Rectangle GroupBoxRectangle(GroupBox gb)
        {
            return new Rectangle(gb.Location,gb.Size);
        }

        private void RefreshStickies(List<Task> todo, List<Task> doing, List<Task> done)
        {
            RefreshGroupBox(_todoGroupBox,todo);
            RefreshGroupBox(_doingGroupBox, doing);
            RefreshGroupBox(_doneGroupBox, done);
            
        }

        private void RefreshGroupBox(GroupBox gb, List<Task> tasklist)
        {
            int i = 0;
            foreach (Sticky sticky in gb.Controls)
            {
                if (i < tasklist.Count)
                {
                    sticky.Task = tasklist[i];
                    sticky.Top = i * sticky.Height;
                    if (tasklist[i] == _presentationModel.GetTargetTask())
                    {
                        sticky.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        sticky.BorderStyle = BorderStyle.FixedSingle;
                    }
                }
                else {
                    sticky.Dispose();
                }
                i++;
            }
            //如果有未加完的Task，需要New新的Sticky去承接剩下的
            while (i < tasklist.Count)
            {
                //新增sticky須新增事件
                Sticky sticky = new Sticky(tasklist[i]);            
                sticky.DoubleClick += new System.EventHandler(this.Sticky_DoubleClick);
                sticky.Click += new System.EventHandler(this.Sticky_Click);
                sticky.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Sticky_MouseDown);
                sticky.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sticky_MouseUp);
                sticky.BringToFront();
                gb.Controls.Add(sticky);
                if (tasklist[i] == _presentationModel.GetTargetTask())
                {
                    sticky.BorderStyle = BorderStyle.Fixed3D;
                }
                else
                {
                    sticky.BorderStyle = BorderStyle.FixedSingle;
                }
                sticky.Top = i * sticky.Height;
                i++;
            }
        }
    }
}

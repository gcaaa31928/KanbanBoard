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
    }
}

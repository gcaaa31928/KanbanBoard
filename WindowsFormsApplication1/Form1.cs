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
        }

        private void _menuToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void _registerToolStripButton_Click(object sender, EventArgs e)
        {

        }
    }
}

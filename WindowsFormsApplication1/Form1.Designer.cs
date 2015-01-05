using System.Collections.Generic;
using System.Drawing;
namespace WindowsFormsApplication1
{
    partial class KanBanBoard
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KanBanBoard));
            this._menuToolStrip = new System.Windows.Forms.ToolStrip();
            this._newProjectToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._nickNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this._nickNameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this._registerToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this._iDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this._idToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this._memberGroupBox = new System.Windows.Forms.GroupBox();
            this._iDLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this._addButton = new System.Windows.Forms.Button();
            this._onlineGroupBox = new System.Windows.Forms.GroupBox();
            this._onlineListView = new System.Windows.Forms.ListView();
            this._todoGroupBox = new System.Windows.Forms.GroupBox();
            this._doingGroupBox = new System.Windows.Forms.GroupBox();
            this._doneGroupBox = new System.Windows.Forms.GroupBox();
            this._todoLabel = new System.Windows.Forms.Label();
            this._doingLabel = new System.Windows.Forms.Label();
            this._doneLabel = new System.Windows.Forms.Label();
            this._menuToolStrip.SuspendLayout();
            this._memberGroupBox.SuspendLayout();
            this._onlineGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // _menuToolStrip
            // 
            this._menuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._newProjectToolStripButton,
            this.toolStripSeparator1,
            this._nickNameToolStripLabel,
            this._nickNameToolStripTextBox,
            this._registerToolStripButton,
            this.toolStripSeparator2,
            this._iDToolStripLabel,
            this._idToolStripTextBox});
            this._menuToolStrip.Location = new System.Drawing.Point(0, 0);
            this._menuToolStrip.Name = "_menuToolStrip";
            this._menuToolStrip.Size = new System.Drawing.Size(1268, 27);
            this._menuToolStrip.TabIndex = 0;
            this._menuToolStrip.Text = "toolStrip1";
            this._menuToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this._menuToolStrip_ItemClicked);
            // 
            // _newProjectToolStripButton
            // 
            this._newProjectToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._newProjectToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._newProjectToolStripButton.Name = "_newProjectToolStripButton";
            this._newProjectToolStripButton.Size = new System.Drawing.Size(97, 24);
            this._newProjectToolStripButton.Text = "New Project";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // _nickNameToolStripLabel
            // 
            this._nickNameToolStripLabel.Name = "_nickNameToolStripLabel";
            this._nickNameToolStripLabel.Size = new System.Drawing.Size(82, 24);
            this._nickNameToolStripLabel.Text = "NickName";
            // 
            // _nickNameToolStripTextBox
            // 
            this._nickNameToolStripTextBox.Name = "_nickNameToolStripTextBox";
            this._nickNameToolStripTextBox.Size = new System.Drawing.Size(132, 27);
            // 
            // _registerToolStripButton
            // 
            this._registerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._registerToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("_registerToolStripButton.Image")));
            this._registerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._registerToolStripButton.Name = "_registerToolStripButton";
            this._registerToolStripButton.Size = new System.Drawing.Size(71, 24);
            this._registerToolStripButton.Text = "Register";
            this._registerToolStripButton.Click += new System.EventHandler(this._registerToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // _iDToolStripLabel
            // 
            this._iDToolStripLabel.Name = "_iDToolStripLabel";
            this._iDToolStripLabel.Size = new System.Drawing.Size(24, 24);
            this._iDToolStripLabel.Text = "ID";
            // 
            // _idToolStripTextBox
            // 
            this._idToolStripTextBox.Name = "_idToolStripTextBox";
            this._idToolStripTextBox.ReadOnly = true;
            this._idToolStripTextBox.Size = new System.Drawing.Size(132, 27);
            // 
            // _memberGroupBox
            // 
            this._memberGroupBox.Controls.Add(this._iDLabel);
            this._memberGroupBox.Controls.Add(this.textBox1);
            this._memberGroupBox.Controls.Add(this._addButton);
            this._memberGroupBox.Location = new System.Drawing.Point(16, 35);
            this._memberGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this._memberGroupBox.Name = "_memberGroupBox";
            this._memberGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this._memberGroupBox.Size = new System.Drawing.Size(219, 109);
            this._memberGroupBox.TabIndex = 1;
            this._memberGroupBox.TabStop = false;
            this._memberGroupBox.Text = "Member";
            // 
            // _iDLabel
            // 
            this._iDLabel.AutoSize = true;
            this._iDLabel.Location = new System.Drawing.Point(25, 30);
            this._iDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._iDLabel.Name = "_iDLabel";
            this._iDLabel.Size = new System.Drawing.Size(22, 15);
            this._iDLabel.TabIndex = 2;
            this._iDLabel.Text = "ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 26);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 25);
            this.textBox1.TabIndex = 2;
            // 
            // _addButton
            // 
            this._addButton.Location = new System.Drawing.Point(28, 61);
            this._addButton.Margin = new System.Windows.Forms.Padding(4);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(100, 29);
            this._addButton.TabIndex = 2;
            this._addButton.Text = "Add Member";
            this._addButton.UseVisualStyleBackColor = true;
            // 
            // _onlineGroupBox
            // 
            this._onlineGroupBox.Controls.Add(this._onlineListView);
            this._onlineGroupBox.Location = new System.Drawing.Point(16, 151);
            this._onlineGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this._onlineGroupBox.Name = "_onlineGroupBox";
            this._onlineGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this._onlineGroupBox.Size = new System.Drawing.Size(219, 338);
            this._onlineGroupBox.TabIndex = 2;
            this._onlineGroupBox.TabStop = false;
            this._onlineGroupBox.Text = "Online";
            // 
            // _onlineListView
            // 
            this._onlineListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this._onlineListView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this._onlineListView.Location = new System.Drawing.Point(8, 26);
            this._onlineListView.Margin = new System.Windows.Forms.Padding(4);
            this._onlineListView.Name = "_onlineListView";
            this._onlineListView.Size = new System.Drawing.Size(201, 262);
            this._onlineListView.TabIndex = 3;
            this._onlineListView.UseCompatibleStateImageBehavior = false;
            // 
            // _todoGroupBox
            // 
            this._todoGroupBox.Location = new System.Drawing.Point(264, 65);
            this._todoGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this._todoGroupBox.Name = "_todoGroupBox";
            this._todoGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this._todoGroupBox.Size = new System.Drawing.Size(287, 438);
            this._todoGroupBox.TabIndex = 3;
            this._todoGroupBox.TabStop = false;
                        // 
            // _doingGroupBox
            // 
            this._doingGroupBox.Location = new System.Drawing.Point(593, 65);
            this._doingGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this._doingGroupBox.Name = "_doingGroupBox";
            this._doingGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this._doingGroupBox.Size = new System.Drawing.Size(287, 438);
            this._doingGroupBox.TabIndex = 4;
            this._doingGroupBox.TabStop = false;
            // 
            // _doneGroupBox
            // 
            this._doneGroupBox.Location = new System.Drawing.Point(916, 65);
            this._doneGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this._doneGroupBox.Name = "_doneGroupBox";
            this._doneGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this._doneGroupBox.Size = new System.Drawing.Size(287, 438);
            this._doneGroupBox.TabIndex = 4;
            this._doneGroupBox.TabStop = false;
                        // 
            // _todoLabel
            // 
            this._todoLabel.AutoSize = true;
            this._todoLabel.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._todoLabel.Location = new System.Drawing.Point(348, 31);
            this._todoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._todoLabel.Name = "_todoLabel";
            this._todoLabel.Size = new System.Drawing.Size(90, 30);
            this._todoLabel.TabIndex = 5;
            this._todoLabel.Text = "TODO";
            this._todoLabel.DoubleClick += new System.EventHandler(this._todoLabel_DoubleClick);
            // 
            // _doingLabel
            // 
            this._doingLabel.AutoSize = true;
            this._doingLabel.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._doingLabel.Location = new System.Drawing.Point(676, 31);
            this._doingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._doingLabel.Name = "_doingLabel";
            this._doingLabel.Size = new System.Drawing.Size(102, 30);
            this._doingLabel.TabIndex = 6;
            this._doingLabel.Text = "DOING";
            // 
            // _doneLabel
            // 
            this._doneLabel.AutoSize = true;
            this._doneLabel.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._doneLabel.Location = new System.Drawing.Point(1020, 31);
            this._doneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._doneLabel.Name = "_doneLabel";
            this._doneLabel.Size = new System.Drawing.Size(90, 30);
            this._doneLabel.TabIndex = 7;
            this._doneLabel.Text = "DONE";
            // 
            // KanBanBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 518);
            this.Controls.Add(this._todoGroupBox);
            this.Controls.Add(this._doneLabel);
            this.Controls.Add(this._doingLabel);
            this.Controls.Add(this._todoLabel);
            this.Controls.Add(this._doneGroupBox);
            this.Controls.Add(this._doingGroupBox);
            this.Controls.Add(this._onlineGroupBox);
            this.Controls.Add(this._memberGroupBox);
            this.Controls.Add(this._menuToolStrip);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KanBanBoard";
            this.Text = "KanBanBoard";
            this.Load += new System.EventHandler(this.KanBanBoard_Load);
            this._menuToolStrip.ResumeLayout(false);
            this._menuToolStrip.PerformLayout();
            this._memberGroupBox.ResumeLayout(false);
            this._memberGroupBox.PerformLayout();
            this._onlineGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip _menuToolStrip;
        private System.Windows.Forms.ToolStripButton _newProjectToolStripButton;
        private System.Windows.Forms.GroupBox _memberGroupBox;
        private System.Windows.Forms.Label _iDLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button _addButton;
        private System.Windows.Forms.GroupBox _onlineGroupBox;
        private System.Windows.Forms.ListView _onlineListView;
        private System.Windows.Forms.GroupBox _todoGroupBox;
        private System.Windows.Forms.GroupBox _doingGroupBox;
        private System.Windows.Forms.GroupBox _doneGroupBox;
        private System.Windows.Forms.Label _todoLabel;
        private System.Windows.Forms.Label _doingLabel;
        private System.Windows.Forms.Label _doneLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel _nickNameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox _nickNameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton _registerToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel _iDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox _idToolStripTextBox;
        //private List<Sticky> _stickies = new List<Sticky>();



    }
}


namespace KanbanApp
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
            this.components = new System.ComponentModel.Container();
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
            this.memberTextBox = new System.Windows.Forms.TextBox();
            this._addButton = new System.Windows.Forms.Button();
            this._projectMembersGroupBox = new System.Windows.Forms.GroupBox();
            this._onlineListView = new System.Windows.Forms.ListView();
            this._todoGroupBox = new System.Windows.Forms.GroupBox();
            this._doingGroupBox = new System.Windows.Forms.GroupBox();
            this._doneGroupBox = new System.Windows.Forms.GroupBox();
            this._todoLabel = new System.Windows.Forms.Label();
            this._doingLabel = new System.Windows.Forms.Label();
            this._doneLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._projectNameLabel = new System.Windows.Forms.Label();
            this._timer = new System.Windows.Forms.Timer(this.components);
            this._menuToolStrip.SuspendLayout();
            this._memberGroupBox.SuspendLayout();
            this._projectMembersGroupBox.SuspendLayout();
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
            this._menuToolStrip.Size = new System.Drawing.Size(951, 25);
            this._menuToolStrip.TabIndex = 0;
            this._menuToolStrip.Text = "toolStrip1";
            this._menuToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this._menuToolStrip_ItemClicked);
            // 
            // _newProjectToolStripButton
            // 
            this._newProjectToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._newProjectToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._newProjectToolStripButton.Name = "_newProjectToolStripButton";
            this._newProjectToolStripButton.Size = new System.Drawing.Size(74, 22);
            this._newProjectToolStripButton.Text = "New Project";
            this._newProjectToolStripButton.Click += new System.EventHandler(this.NewProjectToolStripButtonClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // _nickNameToolStripLabel
            // 
            this._nickNameToolStripLabel.Name = "_nickNameToolStripLabel";
            this._nickNameToolStripLabel.Size = new System.Drawing.Size(62, 22);
            this._nickNameToolStripLabel.Text = "NickName";
            // 
            // _nickNameToolStripTextBox
            // 
            this._nickNameToolStripTextBox.Name = "_nickNameToolStripTextBox";
            this._nickNameToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this._nickNameToolStripTextBox.Click += new System.EventHandler(this.NickNameToolStripTextBoxClick);
            this._nickNameToolStripTextBox.TextChanged += new System.EventHandler(this.NickNameToolStripTextBoxTextChanged);
            // 
            // _registerToolStripButton
            // 
            this._registerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._registerToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("_registerToolStripButton.Image")));
            this._registerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._registerToolStripButton.Name = "_registerToolStripButton";
            this._registerToolStripButton.Size = new System.Drawing.Size(56, 22);
            this._registerToolStripButton.Text = "Register";
            this._registerToolStripButton.Click += new System.EventHandler(this.RegisterToolStripButtonClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // _iDToolStripLabel
            // 
            this._iDToolStripLabel.Name = "_iDToolStripLabel";
            this._iDToolStripLabel.Size = new System.Drawing.Size(19, 22);
            this._iDToolStripLabel.Text = "ID";
            // 
            // _idToolStripTextBox
            // 
            this._idToolStripTextBox.Name = "_idToolStripTextBox";
            this._idToolStripTextBox.ReadOnly = true;
            this._idToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // _memberGroupBox
            // 
            this._memberGroupBox.Controls.Add(this._iDLabel);
            this._memberGroupBox.Controls.Add(this.memberTextBox);
            this._memberGroupBox.Controls.Add(this._addButton);
            this._memberGroupBox.Location = new System.Drawing.Point(12, 28);
            this._memberGroupBox.Name = "_memberGroupBox";
            this._memberGroupBox.Size = new System.Drawing.Size(164, 87);
            this._memberGroupBox.TabIndex = 1;
            this._memberGroupBox.TabStop = false;
            this._memberGroupBox.Text = "Member";
            // 
            // _iDLabel
            // 
            this._iDLabel.AutoSize = true;
            this._iDLabel.Location = new System.Drawing.Point(19, 24);
            this._iDLabel.Name = "_iDLabel";
            this._iDLabel.Size = new System.Drawing.Size(17, 12);
            this._iDLabel.TabIndex = 2;
            this._iDLabel.Text = "ID";
            // 
            // memberTextBox
            // 
            this.memberTextBox.Location = new System.Drawing.Point(58, 21);
            this.memberTextBox.Name = "memberTextBox";
            this.memberTextBox.Size = new System.Drawing.Size(100, 22);
            this.memberTextBox.TabIndex = 2;
            // 
            // _addButton
            // 
            this._addButton.Location = new System.Drawing.Point(21, 49);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(75, 23);
            this._addButton.TabIndex = 2;
            this._addButton.Text = "Add Member";
            this._addButton.UseVisualStyleBackColor = true;
            this._addButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // _projectMembersGroupBox
            // 
            this._projectMembersGroupBox.Controls.Add(this._onlineListView);
            this._projectMembersGroupBox.Location = new System.Drawing.Point(12, 121);
            this._projectMembersGroupBox.Name = "_projectMembersGroupBox";
            this._projectMembersGroupBox.Size = new System.Drawing.Size(164, 270);
            this._projectMembersGroupBox.TabIndex = 2;
            this._projectMembersGroupBox.TabStop = false;
            this._projectMembersGroupBox.Text = "ProjectMembers";
            // 
            // _onlineListView
            // 
            this._onlineListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this._onlineListView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this._onlineListView.Location = new System.Drawing.Point(6, 21);
            this._onlineListView.Name = "_onlineListView";
            this._onlineListView.Size = new System.Drawing.Size(152, 210);
            this._onlineListView.TabIndex = 3;
            this._onlineListView.UseCompatibleStateImageBehavior = false;
            // 
            // _todoGroupBox
            // 
            this._todoGroupBox.Location = new System.Drawing.Point(198, 52);
            this._todoGroupBox.Name = "_todoGroupBox";
            this._todoGroupBox.Size = new System.Drawing.Size(215, 350);
            this._todoGroupBox.TabIndex = 3;
            this._todoGroupBox.TabStop = false;
            // 
            // _doingGroupBox
            // 
            this._doingGroupBox.Location = new System.Drawing.Point(445, 52);
            this._doingGroupBox.Name = "_doingGroupBox";
            this._doingGroupBox.Size = new System.Drawing.Size(215, 350);
            this._doingGroupBox.TabIndex = 4;
            this._doingGroupBox.TabStop = false;
            // 
            // _doneGroupBox
            // 
            this._doneGroupBox.Location = new System.Drawing.Point(687, 52);
            this._doneGroupBox.Name = "_doneGroupBox";
            this._doneGroupBox.Size = new System.Drawing.Size(215, 350);
            this._doneGroupBox.TabIndex = 4;
            this._doneGroupBox.TabStop = false;
            // 
            // _todoLabel
            // 
            this._todoLabel.AutoSize = true;
            this._todoLabel.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._todoLabel.Location = new System.Drawing.Point(261, 25);
            this._todoLabel.Name = "_todoLabel";
            this._todoLabel.Size = new System.Drawing.Size(72, 24);
            this._todoLabel.TabIndex = 5;
            this._todoLabel.Text = "TODO";
            this._todoLabel.Click += new System.EventHandler(this._todoLabel_Click);
            this._todoLabel.DoubleClick += new System.EventHandler(this._todoLabel_DoubleClick);
            // 
            // _doingLabel
            // 
            this._doingLabel.AutoSize = true;
            this._doingLabel.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._doingLabel.Location = new System.Drawing.Point(507, 25);
            this._doingLabel.Name = "_doingLabel";
            this._doingLabel.Size = new System.Drawing.Size(82, 24);
            this._doingLabel.TabIndex = 6;
            this._doingLabel.Text = "DOING";
            // 
            // _doneLabel
            // 
            this._doneLabel.AutoSize = true;
            this._doneLabel.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._doneLabel.Location = new System.Drawing.Point(765, 25);
            this._doneLabel.Name = "_doneLabel";
            this._doneLabel.Size = new System.Drawing.Size(72, 24);
            this._doneLabel.TabIndex = 7;
            this._doneLabel.Text = "DONE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "NowProject : ";
            // 
            // _projectNameLabel
            // 
            this._projectNameLabel.AutoSize = true;
            this._projectNameLabel.Location = new System.Drawing.Point(519, 6);
            this._projectNameLabel.Name = "_projectNameLabel";
            this._projectNameLabel.Size = new System.Drawing.Size(30, 12);
            this._projectNameLabel.TabIndex = 9;
            this._projectNameLabel.Text = "None";
            // 
            // _timer
            // 
            this._timer.Interval = 3000;
            this._timer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // KanBanBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 414);
            this.Controls.Add(this._projectNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._doneLabel);
            this.Controls.Add(this._doingLabel);
            this.Controls.Add(this._todoLabel);
            this.Controls.Add(this._doneGroupBox);
            this.Controls.Add(this._doingGroupBox);
            this.Controls.Add(this._todoGroupBox);
            this.Controls.Add(this._projectMembersGroupBox);
            this.Controls.Add(this._memberGroupBox);
            this.Controls.Add(this._menuToolStrip);
            this.Name = "KanBanBoard";
            this.Text = "KanBanBoard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KanBanBoardClosing);
            this.Load += new System.EventHandler(this.KanBanBoardLoad);
            this._menuToolStrip.ResumeLayout(false);
            this._menuToolStrip.PerformLayout();
            this._memberGroupBox.ResumeLayout(false);
            this._memberGroupBox.PerformLayout();
            this._projectMembersGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip _menuToolStrip;
        private System.Windows.Forms.ToolStripButton _newProjectToolStripButton;
        private System.Windows.Forms.GroupBox _memberGroupBox;
        private System.Windows.Forms.Label _iDLabel;
        private System.Windows.Forms.TextBox memberTextBox;
        private System.Windows.Forms.Button _addButton;
        private System.Windows.Forms.GroupBox _projectMembersGroupBox;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _projectNameLabel;
        private System.Windows.Forms.Timer _timer;




    }
}


namespace KanbanApp
{
    partial class Sticky
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

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this._assigneeLabel = new System.Windows.Forms.Label();
            this._titleLabel = new System.Windows.Forms.Label();
            this._textlable = new System.Windows.Forms.Label();
            this._deadlineLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _assigneeLabel
            // 
            this._assigneeLabel.BackColor = System.Drawing.Color.Transparent;
            this._assigneeLabel.Location = new System.Drawing.Point(3, 0);
            this._assigneeLabel.Name = "_assigneeLabel";
            this._assigneeLabel.Size = new System.Drawing.Size(100, 23);
            this._assigneeLabel.TabIndex = 3;
            this._assigneeLabel.Text = "Assignee";
            // 
            // _titleLabel
            // 
            this._titleLabel.BackColor = System.Drawing.Color.Transparent;
            this._titleLabel.Location = new System.Drawing.Point(3, 31);
            this._titleLabel.Name = "_titleLabel";
            this._titleLabel.Size = new System.Drawing.Size(31, 24);
            this._titleLabel.TabIndex = 2;
            this._titleLabel.Text = "Title";
            // 
            // _textlable
            // 
            this._textlable.BackColor = System.Drawing.Color.Transparent;
            this._textlable.Cursor = System.Windows.Forms.Cursors.Default;
            this._textlable.Location = new System.Drawing.Point(3, 67);
            this._textlable.Name = "_textlable";
            this._textlable.Size = new System.Drawing.Size(63, 20);
            this._textlable.TabIndex = 1;
            this._textlable.Text = "DeadLine:";
            // 
            // _deadlineLabel
            // 
            this._deadlineLabel.BackColor = System.Drawing.Color.Transparent;
            this._deadlineLabel.Location = new System.Drawing.Point(56, 67);
            this._deadlineLabel.Name = "_deadlineLabel";
            this._deadlineLabel.Size = new System.Drawing.Size(89, 20);
            this._deadlineLabel.TabIndex = 0;
            this._deadlineLabel.Text = "1/1";
            this._deadlineLabel.Click += new System.EventHandler(this._deadlineLabel_Click);
            // 
            // Sticky
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this._deadlineLabel);
            this.Controls.Add(this._textlable);
            this.Controls.Add(this._titleLabel);
            this.Controls.Add(this._assigneeLabel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.Name = "Sticky";
            this.Size = new System.Drawing.Size(197, 98);
            this.Load += new System.EventHandler(this.Sticky_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Sticky_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Sticky_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sticky_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _assigneeLabel;
        private System.Windows.Forms.Label _titleLabel;
        private System.Windows.Forms.Label _textlable;
        private System.Windows.Forms.Label _deadlineLabel;
    }
}

namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sticky));
            this._assigneeLabel = new System.Windows.Forms.Label();
            this._titleLabel = new System.Windows.Forms.Label();
            this._textlable = new System.Windows.Forms.Label();
            this._deadlineLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _assigneeLabel
            // 
            resources.ApplyResources(this._assigneeLabel, "_assigneeLabel");
            this._assigneeLabel.BackColor = System.Drawing.Color.Transparent;
            this._assigneeLabel.Name = "_assigneeLabel";
            // 
            // _titleLabel
            // 
            resources.ApplyResources(this._titleLabel, "_titleLabel");
            this._titleLabel.BackColor = System.Drawing.Color.Transparent;
            this._titleLabel.Name = "_titleLabel";
            // 
            // _textlable
            // 
            resources.ApplyResources(this._textlable, "_textlable");
            this._textlable.BackColor = System.Drawing.Color.Transparent;
            this._textlable.Name = "_textlable";
            this._textlable.Click += new System.EventHandler(this._textlable_Click);
            // 
            // _deadlineLabel
            // 
            resources.ApplyResources(this._deadlineLabel, "_deadlineLabel");
            this._deadlineLabel.BackColor = System.Drawing.Color.Transparent;
            this._deadlineLabel.Name = "_deadlineLabel";
            this._deadlineLabel.Click += new System.EventHandler(this._deadlineLabel_Click);
            // 
            // Sticky
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this._deadlineLabel);
            this.Controls.Add(this._textlable);
            this.Controls.Add(this._titleLabel);
            this.Controls.Add(this._assigneeLabel);
            this.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.DoubleBuffered = true;
            this.Name = "Sticky";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Sticky_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Sticky_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sticky_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _assigneeLabel;
        private System.Windows.Forms.Label _titleLabel;
        private System.Windows.Forms.Label _textlable;
        private System.Windows.Forms.Label _deadlineLabel;
    }
}

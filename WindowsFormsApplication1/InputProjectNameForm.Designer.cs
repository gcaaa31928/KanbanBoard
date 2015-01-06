namespace KanbanApp
{
    partial class InputProjectNameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._projectNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._createButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _projectNameTextBox
            // 
            this._projectNameTextBox.Location = new System.Drawing.Point(82, 17);
            this._projectNameTextBox.Name = "_projectNameTextBox";
            this._projectNameTextBox.Size = new System.Drawing.Size(100, 22);
            this._projectNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "ProjectName";
            // 
            // _createButton
            // 
            this._createButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._createButton.Location = new System.Drawing.Point(62, 54);
            this._createButton.Name = "_createButton";
            this._createButton.Size = new System.Drawing.Size(75, 23);
            this._createButton.TabIndex = 2;
            this._createButton.Text = "Create";
            this._createButton.UseVisualStyleBackColor = true;
            this._createButton.Click += new System.EventHandler(this._createButton_Click);
            // 
            // InputProjectNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 89);
            this.Controls.Add(this._createButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._projectNameTextBox);
            this.Name = "InputProjectNameForm";
            this.Text = "InputProjectName";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _projectNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _createButton;
    }
}
namespace WindowsFormsApplication1
{
    partial class NewTaskForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._titleBox = new System.Windows.Forms.TextBox();
            this._assigneeComboBox = new System.Windows.Forms.ComboBox();
            this._deadline = new System.Windows.Forms.DateTimePicker();
            this._priorityComboBox = new System.Windows.Forms.ComboBox();
            this._descriptionTextBox = new System.Windows.Forms.TextBox();
            this._editButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Assignee:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Deadline:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Priority:";
            // 
            // _titleBox
            // 
            this._titleBox.Location = new System.Drawing.Point(86, 13);
            this._titleBox.Name = "_titleBox";
            this._titleBox.Size = new System.Drawing.Size(195, 25);
            this._titleBox.TabIndex = 5;
            // 
            // _assigneeComboBox
            // 
            this._assigneeComboBox.FormattingEnabled = true;
            this._assigneeComboBox.Items.AddRange(new object[] {
            "小名"});
            this._assigneeComboBox.Location = new System.Drawing.Point(86, 54);
            this._assigneeComboBox.Name = "_assigneeComboBox";
            this._assigneeComboBox.Size = new System.Drawing.Size(121, 23);
            this._assigneeComboBox.TabIndex = 6;
            // 
            // _deadline
            // 
            this._deadline.Location = new System.Drawing.Point(86, 91);
            this._deadline.Name = "_deadline";
            this._deadline.Size = new System.Drawing.Size(200, 25);
            this._deadline.TabIndex = 7;
            // 
            // _priorityComboBox
            // 
            this._priorityComboBox.FormattingEnabled = true;
            this._priorityComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this._priorityComboBox.Location = new System.Drawing.Point(86, 142);
            this._priorityComboBox.Name = "_priorityComboBox";
            this._priorityComboBox.Size = new System.Drawing.Size(121, 23);
            this._priorityComboBox.TabIndex = 8;
            // 
            // _descriptionTextBox
            // 
            this._descriptionTextBox.Location = new System.Drawing.Point(16, 218);
            this._descriptionTextBox.Multiline = true;
            this._descriptionTextBox.Name = "_descriptionTextBox";
            this._descriptionTextBox.Size = new System.Drawing.Size(453, 115);
            this._descriptionTextBox.TabIndex = 9;
            // 
            // _editButton
            // 
            this._editButton.Location = new System.Drawing.Point(339, 339);
            this._editButton.Name = "_editButton";
            this._editButton.Size = new System.Drawing.Size(130, 26);
            this._editButton.TabIndex = 10;
            this._editButton.Text = "Ok";
            this._editButton.UseVisualStyleBackColor = true;
            this._editButton.Click += new System.EventHandler(this._editButton_Click);
            // 
            // NewTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 378);
            this.Controls.Add(this._editButton);
            this.Controls.Add(this._descriptionTextBox);
            this.Controls.Add(this._priorityComboBox);
            this.Controls.Add(this._deadline);
            this.Controls.Add(this._assigneeComboBox);
            this.Controls.Add(this._titleBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewTaskForm";
            this.Text = "TaskForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _titleBox;
        private System.Windows.Forms.ComboBox _assigneeComboBox;
        private System.Windows.Forms.DateTimePicker _deadline;
        private System.Windows.Forms.ComboBox _priorityComboBox;
        private System.Windows.Forms.TextBox _descriptionTextBox;
        private System.Windows.Forms.Button _editButton;
    }
}
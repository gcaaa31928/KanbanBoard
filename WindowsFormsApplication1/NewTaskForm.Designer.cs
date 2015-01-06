namespace KanbanApp
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
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Assignee:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Deadline:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "Priority:";
            // 
            // _titleBox
            // 
            this._titleBox.Location = new System.Drawing.Point(64, 10);
            this._titleBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._titleBox.Name = "_titleBox";
            this._titleBox.Size = new System.Drawing.Size(147, 22);
            this._titleBox.TabIndex = 5;
            // 
            // _assigneeComboBox
            // 
            this._assigneeComboBox.FormattingEnabled = true;
            this._assigneeComboBox.Items.AddRange(new object[] {
            "小名"});
            this._assigneeComboBox.Location = new System.Drawing.Point(64, 43);
            this._assigneeComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._assigneeComboBox.Name = "_assigneeComboBox";
            this._assigneeComboBox.Size = new System.Drawing.Size(92, 20);
            this._assigneeComboBox.TabIndex = 6;
            // 
            // _deadline
            // 
            this._deadline.Location = new System.Drawing.Point(64, 73);
            this._deadline.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._deadline.Name = "_deadline";
            this._deadline.Size = new System.Drawing.Size(151, 22);
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
            this._priorityComboBox.Location = new System.Drawing.Point(64, 114);
            this._priorityComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._priorityComboBox.Name = "_priorityComboBox";
            this._priorityComboBox.Size = new System.Drawing.Size(92, 20);
            this._priorityComboBox.TabIndex = 8;
            // 
            // _descriptionTextBox
            // 
            this._descriptionTextBox.Location = new System.Drawing.Point(12, 174);
            this._descriptionTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._descriptionTextBox.Multiline = true;
            this._descriptionTextBox.Name = "_descriptionTextBox";
            this._descriptionTextBox.Size = new System.Drawing.Size(341, 93);
            this._descriptionTextBox.TabIndex = 9;
            // 
            // _editButton
            // 
            this._editButton.Location = new System.Drawing.Point(254, 271);
            this._editButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._editButton.Name = "_editButton";
            this._editButton.Size = new System.Drawing.Size(98, 21);
            this._editButton.TabIndex = 10;
            this._editButton.Text = "Ok";
            this._editButton.UseVisualStyleBackColor = true;
            this._editButton.Click += new System.EventHandler(this._editButton_Click);
            // 
            // NewTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 302);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
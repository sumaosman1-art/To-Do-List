namespace WindowsFormsApp10
{
    partial class Form1
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
            this.chbl = new System.Windows.Forms.CheckedListBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.tbAddTask = new System.Windows.Forms.TextBox();
            this.btnRemoveCheckedTasks = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCompleted = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPending = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(534, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "ToDo List";
            // 
            // chbl
            // 
            this.chbl.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.chbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.chbl.FormattingEnabled = true;
            this.chbl.Items.AddRange(new object[] {
            "Excersize for 20 m",
            "Read For 30 m",
            "Study for 2 h"});
            this.chbl.Location = new System.Drawing.Point(675, 197);
            this.chbl.Name = "chbl";
            this.chbl.Size = new System.Drawing.Size(640, 328);
            this.chbl.TabIndex = 1;
            this.chbl.SelectedIndexChanged += new System.EventHandler(this.chbl_SelectedIndexChanged);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddTask.Location = new System.Drawing.Point(12, 197);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(179, 76);
            this.btnAddTask.TabIndex = 2;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // tbAddTask
            // 
            this.tbAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddTask.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tbAddTask.Location = new System.Drawing.Point(254, 223);
            this.tbAddTask.Name = "tbAddTask";
            this.tbAddTask.Size = new System.Drawing.Size(280, 39);
            this.tbAddTask.TabIndex = 3;
            // 
            // btnRemoveCheckedTasks
            // 
            this.btnRemoveCheckedTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCheckedTasks.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnRemoveCheckedTasks.Location = new System.Drawing.Point(12, 476);
            this.btnRemoveCheckedTasks.Name = "btnRemoveCheckedTasks";
            this.btnRemoveCheckedTasks.Size = new System.Drawing.Size(179, 119);
            this.btnRemoveCheckedTasks.TabIndex = 4;
            this.btnRemoveCheckedTasks.Text = "Remove Checked Tasks";
            this.btnRemoveCheckedTasks.UseVisualStyleBackColor = true;
            this.btnRemoveCheckedTasks.Click += new System.EventHandler(this.btnRemoveCheckedTasks_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAll.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnRemoveAll.Location = new System.Drawing.Point(344, 476);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(179, 119);
            this.btnRemoveAll.TabIndex = 5;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(6, 746);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Completed";
            // 
            // tbCompleted
            // 
            this.tbCompleted.Location = new System.Drawing.Point(204, 749);
            this.tbCompleted.Name = "tbCompleted";
            this.tbCompleted.Size = new System.Drawing.Size(97, 29);
            this.tbCompleted.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(416, 749);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pending";
            // 
            // tbPending
            // 
            this.tbPending.Location = new System.Drawing.Point(602, 752);
            this.tbPending.Name = "tbPending";
            this.tbPending.Size = new System.Drawing.Size(97, 29);
            this.tbPending.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1510, 1022);
            this.Controls.Add(this.tbPending);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCompleted);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnRemoveCheckedTasks);
            this.Controls.Add(this.tbAddTask);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.chbl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chbl;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.TextBox tbAddTask;
        private System.Windows.Forms.Button btnRemoveCheckedTasks;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCompleted;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPending;
    }
}


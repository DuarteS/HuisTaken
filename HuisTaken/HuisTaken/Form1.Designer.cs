
namespace HuisTaken
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbPeople = new System.Windows.Forms.GroupBox();
            this.lbPeople = new System.Windows.Forms.ListBox();
            this.tbPerson = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnRemovePerson = new System.Windows.Forms.Button();
            this.gbTasks = new System.Windows.Forms.GroupBox();
            this.btnRemoveTask = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTask = new System.Windows.Forms.TextBox();
            this.lbTasks = new System.Windows.Forms.ListBox();
            this.gbDate = new System.Windows.Forms.GroupBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbPeople.SuspendLayout();
            this.gbTasks.SuspendLayout();
            this.gbDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(339, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(936, 603);
            this.dataGridView1.TabIndex = 0;
            // 
            // gbPeople
            // 
            this.gbPeople.Controls.Add(this.btnRemovePerson);
            this.gbPeople.Controls.Add(this.btnAddPerson);
            this.gbPeople.Controls.Add(this.label1);
            this.gbPeople.Controls.Add(this.tbPerson);
            this.gbPeople.Controls.Add(this.lbPeople);
            this.gbPeople.Location = new System.Drawing.Point(12, 350);
            this.gbPeople.Name = "gbPeople";
            this.gbPeople.Size = new System.Drawing.Size(254, 265);
            this.gbPeople.TabIndex = 1;
            this.gbPeople.TabStop = false;
            this.gbPeople.Text = "Add/Remove People";
            // 
            // lbPeople
            // 
            this.lbPeople.FormattingEnabled = true;
            this.lbPeople.Location = new System.Drawing.Point(21, 29);
            this.lbPeople.Name = "lbPeople";
            this.lbPeople.Size = new System.Drawing.Size(205, 134);
            this.lbPeople.TabIndex = 3;
            // 
            // tbPerson
            // 
            this.tbPerson.Location = new System.Drawing.Point(21, 197);
            this.tbPerson.Name = "tbPerson";
            this.tbPerson.Size = new System.Drawing.Size(118, 20);
            this.tbPerson.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add Name :";
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(151, 195);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(75, 23);
            this.btnAddPerson.TabIndex = 3;
            this.btnAddPerson.Text = "Add";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnRemovePerson
            // 
            this.btnRemovePerson.Location = new System.Drawing.Point(151, 224);
            this.btnRemovePerson.Name = "btnRemovePerson";
            this.btnRemovePerson.Size = new System.Drawing.Size(75, 23);
            this.btnRemovePerson.TabIndex = 4;
            this.btnRemovePerson.Text = "Remove";
            this.btnRemovePerson.UseVisualStyleBackColor = true;
            // 
            // gbTasks
            // 
            this.gbTasks.Controls.Add(this.btnRemoveTask);
            this.gbTasks.Controls.Add(this.btnAddTask);
            this.gbTasks.Controls.Add(this.label2);
            this.gbTasks.Controls.Add(this.tbTask);
            this.gbTasks.Controls.Add(this.lbTasks);
            this.gbTasks.Location = new System.Drawing.Point(12, 79);
            this.gbTasks.Name = "gbTasks";
            this.gbTasks.Size = new System.Drawing.Size(254, 265);
            this.gbTasks.TabIndex = 5;
            this.gbTasks.TabStop = false;
            this.gbTasks.Text = "Add/Remove Tasks";
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.Location = new System.Drawing.Point(151, 224);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveTask.TabIndex = 4;
            this.btnRemoveTask.Text = "Remove";
            this.btnRemoveTask.UseVisualStyleBackColor = true;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(151, 195);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(75, 23);
            this.btnAddTask.TabIndex = 3;
            this.btnAddTask.Text = "Add";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Add Task :";
            // 
            // tbTask
            // 
            this.tbTask.Location = new System.Drawing.Point(21, 197);
            this.tbTask.Name = "tbTask";
            this.tbTask.Size = new System.Drawing.Size(118, 20);
            this.tbTask.TabIndex = 3;
            // 
            // lbTasks
            // 
            this.lbTasks.FormattingEnabled = true;
            this.lbTasks.Location = new System.Drawing.Point(21, 29);
            this.lbTasks.Name = "lbTasks";
            this.lbTasks.Size = new System.Drawing.Size(205, 134);
            this.lbTasks.TabIndex = 3;
            // 
            // gbDate
            // 
            this.gbDate.Controls.Add(this.dtpDate);
            this.gbDate.Location = new System.Drawing.Point(12, 12);
            this.gbDate.Name = "gbDate";
            this.gbDate.Size = new System.Drawing.Size(254, 51);
            this.gbDate.TabIndex = 6;
            this.gbDate.TabStop = false;
            this.gbDate.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(26, 19);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 7;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 644);
            this.Controls.Add(this.gbDate);
            this.Controls.Add(this.gbTasks);
            this.Controls.Add(this.gbPeople);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbPeople.ResumeLayout(false);
            this.gbPeople.PerformLayout();
            this.gbTasks.ResumeLayout(false);
            this.gbTasks.PerformLayout();
            this.gbDate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbPeople;
        private System.Windows.Forms.Button btnRemovePerson;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPerson;
        private System.Windows.Forms.ListBox lbPeople;
        private System.Windows.Forms.GroupBox gbTasks;
        private System.Windows.Forms.Button btnRemoveTask;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTask;
        private System.Windows.Forms.ListBox lbTasks;
        private System.Windows.Forms.GroupBox gbDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}


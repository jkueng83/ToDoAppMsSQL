
namespace ToDoAppWithMsSQL
{
    partial class ShowToDos
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
            this.lBoxTodos = new System.Windows.Forms.ListBox();
            this.btShowAllTodos = new System.Windows.Forms.Button();
            this.btShowActualTodos = new System.Windows.Forms.Button();
            this.btShowOpenTodos = new System.Windows.Forms.Button();
            this.btShowClosedToDos = new System.Windows.Forms.Button();
            this.cBoxAutoUpdateActualTodos = new System.Windows.Forms.CheckBox();
            this.tbToDoName = new System.Windows.Forms.TextBox();
            this.selectedToDo = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbCreationDate = new System.Windows.Forms.Label();
            this.lbDeadline = new System.Windows.Forms.Label();
            this.lbIsDone = new System.Windows.Forms.Label();
            this.tbCreationDate = new System.Windows.Forms.TextBox();
            this.cBoxIsDone = new System.Windows.Forms.CheckBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.dateTimePickerDeadlineDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDeadlineTime = new System.Windows.Forms.DateTimePicker();
            this.btDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lBoxTodos
            // 
            this.lBoxTodos.FormattingEnabled = true;
            this.lBoxTodos.Location = new System.Drawing.Point(41, 110);
            this.lBoxTodos.Name = "lBoxTodos";
            this.lBoxTodos.Size = new System.Drawing.Size(442, 95);
            this.lBoxTodos.TabIndex = 0;
            this.lBoxTodos.SelectedIndexChanged += new System.EventHandler(this.lBoxTodos_SelectedIndexChanged);
            // 
            // btShowAllTodos
            // 
            this.btShowAllTodos.Location = new System.Drawing.Point(41, 39);
            this.btShowAllTodos.Name = "btShowAllTodos";
            this.btShowAllTodos.Size = new System.Drawing.Size(98, 23);
            this.btShowAllTodos.TabIndex = 2;
            this.btShowAllTodos.Text = "All Todos";
            this.btShowAllTodos.UseVisualStyleBackColor = true;
            this.btShowAllTodos.Click += new System.EventHandler(this.btShowAllTodos_Click);
            // 
            // btShowActualTodos
            // 
            this.btShowActualTodos.Location = new System.Drawing.Point(145, 39);
            this.btShowActualTodos.Name = "btShowActualTodos";
            this.btShowActualTodos.Size = new System.Drawing.Size(119, 23);
            this.btShowActualTodos.TabIndex = 3;
            this.btShowActualTodos.Text = "Actual ToDos";
            this.btShowActualTodos.UseVisualStyleBackColor = true;
            this.btShowActualTodos.Click += new System.EventHandler(this.btShowActualTodos_Click);
            // 
            // btShowOpenTodos
            // 
            this.btShowOpenTodos.Location = new System.Drawing.Point(270, 39);
            this.btShowOpenTodos.Name = "btShowOpenTodos";
            this.btShowOpenTodos.Size = new System.Drawing.Size(99, 23);
            this.btShowOpenTodos.TabIndex = 4;
            this.btShowOpenTodos.Text = "Open ToDos";
            this.btShowOpenTodos.UseVisualStyleBackColor = true;
            this.btShowOpenTodos.Click += new System.EventHandler(this.btShowOpenTodos_Click);
            // 
            // btShowClosedToDos
            // 
            this.btShowClosedToDos.Location = new System.Drawing.Point(375, 39);
            this.btShowClosedToDos.Name = "btShowClosedToDos";
            this.btShowClosedToDos.Size = new System.Drawing.Size(108, 23);
            this.btShowClosedToDos.TabIndex = 5;
            this.btShowClosedToDos.Text = "Closed ToDos";
            this.btShowClosedToDos.UseVisualStyleBackColor = true;
            this.btShowClosedToDos.Click += new System.EventHandler(this.btShowClosedToDos_Click);
            // 
            // cBoxAutoUpdateActualTodos
            // 
            this.cBoxAutoUpdateActualTodos.AutoSize = true;
            this.cBoxAutoUpdateActualTodos.Location = new System.Drawing.Point(145, 78);
            this.cBoxAutoUpdateActualTodos.Name = "cBoxAutoUpdateActualTodos";
            this.cBoxAutoUpdateActualTodos.Size = new System.Drawing.Size(154, 17);
            this.cBoxAutoUpdateActualTodos.TabIndex = 6;
            this.cBoxAutoUpdateActualTodos.Text = "Auto Update Actual ToDos";
            this.cBoxAutoUpdateActualTodos.UseVisualStyleBackColor = true;
            // 
            // tbToDoName
            // 
            this.tbToDoName.Location = new System.Drawing.Point(132, 285);
            this.tbToDoName.Name = "tbToDoName";
            this.tbToDoName.Size = new System.Drawing.Size(196, 20);
            this.tbToDoName.TabIndex = 7;
            // 
            // selectedToDo
            // 
            this.selectedToDo.AutoSize = true;
            this.selectedToDo.Location = new System.Drawing.Point(38, 229);
            this.selectedToDo.Name = "selectedToDo";
            this.selectedToDo.Size = new System.Drawing.Size(79, 13);
            this.selectedToDo.TabIndex = 8;
            this.selectedToDo.Text = "Selected ToDo";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(38, 288);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 9;
            this.lbName.Text = "Name";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(38, 259);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(16, 13);
            this.lbId.TabIndex = 10;
            this.lbId.Text = "Id";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(38, 315);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(60, 13);
            this.lbDescription.TabIndex = 11;
            this.lbDescription.Text = "Description";
            // 
            // lbCreationDate
            // 
            this.lbCreationDate.AutoSize = true;
            this.lbCreationDate.Location = new System.Drawing.Point(38, 391);
            this.lbCreationDate.Name = "lbCreationDate";
            this.lbCreationDate.Size = new System.Drawing.Size(72, 13);
            this.lbCreationDate.TabIndex = 12;
            this.lbCreationDate.Text = "Creation Date";
            // 
            // lbDeadline
            // 
            this.lbDeadline.AutoSize = true;
            this.lbDeadline.Location = new System.Drawing.Point(47, 418);
            this.lbDeadline.Name = "lbDeadline";
            this.lbDeadline.Size = new System.Drawing.Size(49, 13);
            this.lbDeadline.TabIndex = 13;
            this.lbDeadline.Text = "Deadline";
            // 
            // lbIsDone
            // 
            this.lbIsDone.AutoSize = true;
            this.lbIsDone.Location = new System.Drawing.Point(50, 450);
            this.lbIsDone.Name = "lbIsDone";
            this.lbIsDone.Size = new System.Drawing.Size(44, 13);
            this.lbIsDone.TabIndex = 14;
            this.lbIsDone.Text = "Is Done";
            // 
            // tbCreationDate
            // 
            this.tbCreationDate.Location = new System.Drawing.Point(132, 388);
            this.tbCreationDate.Name = "tbCreationDate";
            this.tbCreationDate.Size = new System.Drawing.Size(196, 20);
            this.tbCreationDate.TabIndex = 15;
            // 
            // cBoxIsDone
            // 
            this.cBoxIsDone.AutoSize = true;
            this.cBoxIsDone.Location = new System.Drawing.Point(128, 450);
            this.cBoxIsDone.Name = "cBoxIsDone";
            this.cBoxIsDone.Size = new System.Drawing.Size(15, 14);
            this.cBoxIsDone.TabIndex = 17;
            this.cBoxIsDone.UseVisualStyleBackColor = true;
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(132, 259);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(196, 20);
            this.tbId.TabIndex = 19;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(132, 312);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescription.Size = new System.Drawing.Size(196, 70);
            this.tbDescription.TabIndex = 20;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(132, 480);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(80, 23);
            this.btSave.TabIndex = 21;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // dateTimePickerDeadlineDate
            // 
            this.dateTimePickerDeadlineDate.Location = new System.Drawing.Point(132, 418);
            this.dateTimePickerDeadlineDate.Name = "dateTimePickerDeadlineDate";
            this.dateTimePickerDeadlineDate.Size = new System.Drawing.Size(196, 20);
            this.dateTimePickerDeadlineDate.TabIndex = 22;
            // 
            // dateTimePickerDeadlineTime
            // 
            this.dateTimePickerDeadlineTime.CausesValidation = false;
            this.dateTimePickerDeadlineTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerDeadlineTime.Location = new System.Drawing.Point(345, 418);
            this.dateTimePickerDeadlineTime.Name = "dateTimePickerDeadlineTime";
            this.dateTimePickerDeadlineTime.ShowUpDown = true;
            this.dateTimePickerDeadlineTime.Size = new System.Drawing.Size(95, 20);
            this.dateTimePickerDeadlineTime.TabIndex = 23;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(248, 480);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(80, 23);
            this.btDelete.TabIndex = 24;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // ShowToDos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 577);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.dateTimePickerDeadlineTime);
            this.Controls.Add(this.dateTimePickerDeadlineDate);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.cBoxIsDone);
            this.Controls.Add(this.tbCreationDate);
            this.Controls.Add(this.lbIsDone);
            this.Controls.Add(this.lbDeadline);
            this.Controls.Add(this.lbCreationDate);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.selectedToDo);
            this.Controls.Add(this.tbToDoName);
            this.Controls.Add(this.cBoxAutoUpdateActualTodos);
            this.Controls.Add(this.btShowClosedToDos);
            this.Controls.Add(this.btShowOpenTodos);
            this.Controls.Add(this.btShowActualTodos);
            this.Controls.Add(this.btShowAllTodos);
            this.Controls.Add(this.lBoxTodos);
            this.Name = "ShowToDos";
            this.Text = "ToDos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBoxTodos;
        private System.Windows.Forms.Button btShowAllTodos;
        private System.Windows.Forms.Button btShowActualTodos;
        private System.Windows.Forms.Button btShowOpenTodos;
        private System.Windows.Forms.Button btShowClosedToDos;
        private System.Windows.Forms.CheckBox cBoxAutoUpdateActualTodos;
        private System.Windows.Forms.TextBox tbToDoName;
        private System.Windows.Forms.Label selectedToDo;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbCreationDate;
        private System.Windows.Forms.Label lbDeadline;
        private System.Windows.Forms.Label lbIsDone;
        private System.Windows.Forms.TextBox tbCreationDate;
        private System.Windows.Forms.CheckBox cBoxIsDone;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeadlineDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeadlineTime;
        private System.Windows.Forms.Button btDelete;
    }
}
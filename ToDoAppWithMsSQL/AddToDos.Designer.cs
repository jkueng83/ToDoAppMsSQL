
namespace ToDoAppWithMsSQL
{
    partial class AddToDos
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
            this.dateTimePickerDeadlineHour = new System.Windows.Forms.DateTimePicker();
            this.lbDeadline = new System.Windows.Forms.Label();
            this.rTBoxDescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxToDo = new System.Windows.Forms.TextBox();
            this.lbTodo = new System.Windows.Forms.Label();
            this.dateTimePickerDeadlineDate = new System.Windows.Forms.DateTimePicker();
            this.btAddToDo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePickerDeadlineHour
            // 
            this.dateTimePickerDeadlineHour.CausesValidation = false;
            this.dateTimePickerDeadlineHour.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerDeadlineHour.Location = new System.Drawing.Point(257, 55);
            this.dateTimePickerDeadlineHour.Name = "dateTimePickerDeadlineHour";
            this.dateTimePickerDeadlineHour.ShowUpDown = true;
            this.dateTimePickerDeadlineHour.Size = new System.Drawing.Size(95, 20);
            this.dateTimePickerDeadlineHour.TabIndex = 16;
            // 
            // lbDeadline
            // 
            this.lbDeadline.AutoSize = true;
            this.lbDeadline.Location = new System.Drawing.Point(30, 30);
            this.lbDeadline.Name = "lbDeadline";
            this.lbDeadline.Size = new System.Drawing.Size(49, 13);
            this.lbDeadline.TabIndex = 15;
            this.lbDeadline.Text = "Deadline";
            // 
            // rTBoxDescription
            // 
            this.rTBoxDescription.Location = new System.Drawing.Point(30, 171);
            this.rTBoxDescription.Name = "rTBoxDescription";
            this.rTBoxDescription.Size = new System.Drawing.Size(197, 132);
            this.rTBoxDescription.TabIndex = 14;
            this.rTBoxDescription.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Description";
            // 
            // tBoxToDo
            // 
            this.tBoxToDo.Location = new System.Drawing.Point(30, 107);
            this.tBoxToDo.Name = "tBoxToDo";
            this.tBoxToDo.Size = new System.Drawing.Size(197, 20);
            this.tBoxToDo.TabIndex = 12;
            // 
            // lbTodo
            // 
            this.lbTodo.AutoSize = true;
            this.lbTodo.Location = new System.Drawing.Point(30, 82);
            this.lbTodo.Name = "lbTodo";
            this.lbTodo.Size = new System.Drawing.Size(34, 13);
            this.lbTodo.TabIndex = 11;
            this.lbTodo.Text = "ToDo";
            // 
            // dateTimePickerDeadlineDate
            // 
            this.dateTimePickerDeadlineDate.Location = new System.Drawing.Point(30, 55);
            this.dateTimePickerDeadlineDate.Name = "dateTimePickerDeadlineDate";
            this.dateTimePickerDeadlineDate.Size = new System.Drawing.Size(197, 20);
            this.dateTimePickerDeadlineDate.TabIndex = 10;
            // 
            // btAddToDo
            // 
            this.btAddToDo.Location = new System.Drawing.Point(30, 339);
            this.btAddToDo.Name = "btAddToDo";
            this.btAddToDo.Size = new System.Drawing.Size(75, 23);
            this.btAddToDo.TabIndex = 9;
            this.btAddToDo.Text = "Add ToDo";
            this.btAddToDo.UseVisualStyleBackColor = true;
            this.btAddToDo.Click += new System.EventHandler(this.btAddToDo_Click);
            // 
            // AddToDos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 414);
            this.Controls.Add(this.dateTimePickerDeadlineHour);
            this.Controls.Add(this.lbDeadline);
            this.Controls.Add(this.rTBoxDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBoxToDo);
            this.Controls.Add(this.lbTodo);
            this.Controls.Add(this.dateTimePickerDeadlineDate);
            this.Controls.Add(this.btAddToDo);
            this.Name = "AddToDos";
            this.Text = "AddToDo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerDeadlineHour;
        private System.Windows.Forms.Label lbDeadline;
        private System.Windows.Forms.RichTextBox rTBoxDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxToDo;
        private System.Windows.Forms.Label lbTodo;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeadlineDate;
        private System.Windows.Forms.Button btAddToDo;
    }
}
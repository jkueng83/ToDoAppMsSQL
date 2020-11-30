
namespace ToDoAppWithMsSQL
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btAddTodoes = new System.Windows.Forms.Button();
            this.btShowTodos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btAddTodoes
            // 
            this.btAddTodoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddTodoes.Location = new System.Drawing.Point(245, 97);
            this.btAddTodoes.Name = "btAddTodoes";
            this.btAddTodoes.Size = new System.Drawing.Size(97, 23);
            this.btAddTodoes.TabIndex = 10;
            this.btAddTodoes.Text = "Add ToDos";
            this.btAddTodoes.UseVisualStyleBackColor = true;
            this.btAddTodoes.Click += new System.EventHandler(this.btAddTodoes_Click);
            // 
            // btShowTodos
            // 
            this.btShowTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShowTodos.Location = new System.Drawing.Point(245, 149);
            this.btShowTodos.Name = "btShowTodos";
            this.btShowTodos.Size = new System.Drawing.Size(97, 23);
            this.btShowTodos.TabIndex = 9;
            this.btShowTodos.Text = "Show ToDos";
            this.btShowTodos.UseVisualStyleBackColor = true;
            this.btShowTodos.Click += new System.EventHandler(this.btShowAllTodos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Klick to add new ToDos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Klick to show and Edit ToDos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "ToDo App";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(412, 215);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAddTodoes);
            this.Controls.Add(this.btShowTodos);
            this.Name = "Form1";
            this.Text = "ToDo App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btAddTodoes;
        private System.Windows.Forms.Button btShowTodos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


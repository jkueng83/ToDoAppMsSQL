
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
            this.SuspendLayout();
            // 
            // btAddTodoes
            // 
            this.btAddTodoes.Location = new System.Drawing.Point(39, 113);
            this.btAddTodoes.Name = "btAddTodoes";
            this.btAddTodoes.Size = new System.Drawing.Size(75, 23);
            this.btAddTodoes.TabIndex = 10;
            this.btAddTodoes.Text = "Add ToDos";
            this.btAddTodoes.UseVisualStyleBackColor = true;
            this.btAddTodoes.Click += new System.EventHandler(this.btAddTodoes_Click);
            // 
            // btShowTodos
            // 
            this.btShowTodos.Location = new System.Drawing.Point(39, 64);
            this.btShowTodos.Name = "btShowTodos";
            this.btShowTodos.Size = new System.Drawing.Size(97, 23);
            this.btShowTodos.TabIndex = 9;
            this.btShowTodos.Text = "Show ToDos";
            this.btShowTodos.UseVisualStyleBackColor = true;
            this.btShowTodos.Click += new System.EventHandler(this.btShowAllTodos_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(436, 687);
            this.Controls.Add(this.btAddTodoes);
            this.Controls.Add(this.btShowTodos);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

       
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btAddTodoes;
        private System.Windows.Forms.Button btShowTodos;
    }
}


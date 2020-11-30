using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoAppData;
using TodoLogic;

namespace ToDoAppWithMsSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btShowAllTodos_Click(object sender, EventArgs e)
        {
            var ToDos = new ShowToDos();
            ToDos.Show();
        }

        private void btAddTodoes_Click(object sender, EventArgs e)
        {
            var addTodos = new AddToDos();
            addTodos.Show();
        }

    }
}

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
        TodoLogicController _logicController;
        public Form1()
        {
            InitializeComponent();

           _logicController = new TodoLogicController();

            
        }

        private void btAddToDo_Click(object sender, EventArgs e)
        {
            _logicController.AddNewToDo(tBoxToDo.Text, 
                rTBoxDescription.Text , 
                (dateTimePickerDeadlineDate.Value.Date + dateTimePickerDeadlineHour.Value.TimeOfDay));
        }

       
    }
}

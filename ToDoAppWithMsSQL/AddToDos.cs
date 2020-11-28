using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoLogic;

namespace ToDoAppWithMsSQL
{
    public partial class AddToDos : Form
    {
        TodoLogicController _logicController;
        public AddToDos()
        {
            InitializeComponent();
            _logicController = new TodoLogicController();
            dateTimePickerDeadlineHour.Value = new DateTime(2020, 11, 28, 12, 00, 00);
        }

        private void btAddToDo_Click(object sender, EventArgs e)
        {
            _logicController.AddNewToDo(tBoxToDo.Text,
               rTBoxDescription.Text,
               (dateTimePickerDeadlineDate.Value.Date + dateTimePickerDeadlineHour.Value.TimeOfDay));
        }
    }
}

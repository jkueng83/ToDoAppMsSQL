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
    public partial class ShowToDos : Form
    {
        TodoLogicController _todoLogicController;
        Timer _timerUpdateActualTodos;
        List<todo> _lBoxTodosContent;
        todo _selectedTodo;
        public ShowToDos()
        {
            InitializeComponent();

            _todoLogicController = new TodoLogicController();
            _lBoxTodosContent = new List<todo>();


            UpdateTodoList(_todoLogicController.GetAllToDos());

            _timerUpdateActualTodos = new Timer();
            _timerUpdateActualTodos.Interval =5000;
            _timerUpdateActualTodos.Tick += Time_Tick;
            _timerUpdateActualTodos.Start();
                     
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            if (cBoxAutoUpdateActualTodos.Checked)
            {
                LoadActualTodos();
            }   
        }

        private void UpdateTodoList(List<todo> todos)
        {
            _lBoxTodosContent = todos;

            lBoxTodos.DataSource = todos.Select(x => x.name +
            " - Deadline: " + x.deadline +
            " - is Done: " + x.isdone).ToList();
        }

        private void btShowClosedToDos_Click(object sender, EventArgs e)
        {
            DeactivateAutoUpdateActualTodos();
            UpdateTodoList(_todoLogicController.GetTodos(true));
        }

        

        private void btShowAllTodos_Click(object sender, EventArgs e)
        {
            DeactivateAutoUpdateActualTodos();
            UpdateTodoList(_todoLogicController.GetAllToDos());
        }

        private void btShowOpenTodos_Click(object sender, EventArgs e)
        {
            DeactivateAutoUpdateActualTodos();
            UpdateTodoList(_todoLogicController.GetTodos(false));
        }

        private void btShowActualTodos_Click(object sender, EventArgs e)
        {
            LoadActualTodos();// UpdateTodoList(_todoLogicController.GetTodos(System.DateTime.Now.AddHours(2), false));
        }

        private void LoadActualTodos()
        {
            UpdateTodoList(_todoLogicController.GetTodos(System.DateTime.Now.AddHours(2), false));
        }

        private void DeactivateAutoUpdateActualTodos()
        {
            cBoxAutoUpdateActualTodos.Checked = false;
        }

        private void lBoxTodos_MouseClick(object sender, MouseEventArgs e)
        {
            var a = lBoxTodos;
            var selectedToDo = _lBoxTodosContent.ElementAt(a.SelectedIndex);
            WriteDataToSelectedToDo(selectedToDo);
        }

        private void WriteDataToSelectedToDo(todo todo )
        {
            _selectedTodo = todo;

            tbId.Text = _selectedTodo.id.ToString();
            tbToDoName.Text = _selectedTodo.name;    
            tbDescription.Text = _selectedTodo.description;
            tbCreationDate.Text = _selectedTodo.creationdate.ToString();
            tbDeadline.Text = _selectedTodo.deadline.ToString();
            dateTimePickerDeadlineDate.Value = (DateTime)_selectedTodo.deadline;
            dateTimePickerDeadlineTime.Value = (DateTime)_selectedTodo.deadline;
            cBoxIsDone.Checked = _selectedTodo.isdone == true;            
        }

        private void SaveToDoCahanges()
        {

            _selectedTodo.name = tbToDoName.Text;
            _selectedTodo.description = tbDescription.Text;
            _selectedTodo.deadline = dateTimePickerDeadlineDate.Value.Date 
                + dateTimePickerDeadlineTime.Value.TimeOfDay;
            _selectedTodo.isdone = cBoxIsDone.Checked;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            SaveToDoCahanges();
        }
    }
    
}

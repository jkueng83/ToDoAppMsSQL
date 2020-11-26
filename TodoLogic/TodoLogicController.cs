using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAppData;

namespace TodoLogic
{
    public class TodoLogicController
    {

        public void AddNewToDo(string name, string description, DateTime deadline)
        {
            // für die ersten Tests
            ToDoEntities toDoEntities = new ToDoEntities();
            todo todo = new todo()
            {
                name = name,
                description = description,
                creationdate = DateTime.Now,
                deadline = deadline,
                isdone = false
            };

            toDoEntities.todo.Add(todo);
            toDoEntities.SaveChanges();
        }


    }
}

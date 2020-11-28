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
        private ToDoEntities _toDoEntities;
        public TodoLogicController()
        {
            _toDoEntities = new ToDoEntities();
            GetAllToDos();
        }
        public void AddNewToDo(string name, string description, DateTime deadline)
        {
            // für die ersten Tests
           
            todo todo = new todo()
            {
                name = name,
                description = description,
                creationdate = DateTime.Now,
                deadline = deadline,
                isdone = false
            };

            _toDoEntities.todo.Add(todo);
            _toDoEntities.SaveChanges();
        }

        public List<todo> GetAllToDos()
        {          
            List<todo> allToDos = _toDoEntities.todo.Select(x => x).ToList();
            return allToDos;          
        }

        public List<todo> GetTodos (bool isDone)
        {
           return _toDoEntities.todo.Select(x => x).Where(x => x.isdone == isDone).ToList();
        }

        public List<todo> GetTodos (DateTime deadlineBefore , bool isDone)
        {
            return _toDoEntities.todo.Select(x => x).
                Where(x => x.isdone == isDone && x.deadline < deadlineBefore).ToList();

        }


        



    }
}

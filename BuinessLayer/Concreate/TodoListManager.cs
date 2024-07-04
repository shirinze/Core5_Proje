using BuinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuinessLayer.Concreate
{
    public class TodoListManager : ITodoListService
    {
        ITodoListDal _todolistdal;
        public TodoListManager(ITodoListDal todolistdal)
        {
            _todolistdal = todolistdal;
        }

        public void TAdd(ToDoList t)
        {
            _todolistdal.Insert(t);
        }

        public void TDelete(ToDoList t)
        {
            _todolistdal.Delete(t);
        }

        public List<ToDoList> TGetbyFilter()
        {
            throw new NotImplementedException();
        }

        public ToDoList TGetById(int id)
        {
            return _todolistdal.GetById(id);
        }

        public List<ToDoList> TGetByList()
        {
            return _todolistdal.GetList();
        }

        public void TUpdate(ToDoList t)
        {
            _todolistdal.Update(t);
        }
    }
}

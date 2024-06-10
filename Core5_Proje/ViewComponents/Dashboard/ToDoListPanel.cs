using BuinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core5_Proje.ViewComponents.Dashboard
{
    public class ToDoListPanel:ViewComponent
    {
        TodoListManager todolistmanager = new TodoListManager(new EfTodoListDal());
        public IViewComponentResult Invoke()
        {
            return View(todolistmanager.TGetByList());
        }
    }
}


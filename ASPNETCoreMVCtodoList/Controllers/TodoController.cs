using ASPNETCoreMVCtodoList.Models;
using ASPNETCoreMVCtodoList.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCoreMVCtodoList.Controllers
{
    public class TodoController:Controller
    {
        private readonly ITodoRepository _todoRepository;

        public TodoController(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }
        [Route("")]
        [Route("Todo")]
        [Route("Todo/Index")]
        [Route("Todo/Index/{id?}")]
        public ViewResult Index()
        {
            TodoIndexViewModel viewModel = new TodoIndexViewModel()
            {
                todo = _todoRepository.GetAll()
            };
            return View(viewModel);
        }
    }
}

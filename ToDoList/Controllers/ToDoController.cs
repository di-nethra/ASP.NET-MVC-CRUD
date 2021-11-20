using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Data;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class ToDoController : Controller
    {
        private readonly ToDoDbContext _db;

        public ToDoController(ToDoDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<ToDo> objList = _db.todo;
          
            return View(objList);
        }

        public IActionResult CreateToDo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ToDo obj)
        {
            _db.todo.Add(obj);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }


    }

}

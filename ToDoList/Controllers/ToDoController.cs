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

        
        public IActionResult Delete(int id)
        {
            var obj = _db.todo.Find(id);
            _db.todo.Remove(obj);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var obj = _db.todo.Find(id);

            return View(obj);
        }

        [HttpPost]
        public IActionResult PostEdit(ToDo obj)
        {
            _db.todo.Update(obj);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }

}

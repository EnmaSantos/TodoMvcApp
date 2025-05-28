using Microsoft.AspNetCore.Mvc;
using TodoMvcApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace TodoMvcApp.Controllers
{
    public class TodoController : Controller
    {
        // Simulated in-memory database
        private static List<TodoItem> _items = new List<TodoItem>
        {
            new TodoItem { Id = 1, Title = "Buy groceries", Description = "Milk, eggs, bread", IsDone = false },
            new TodoItem { Id = 2, Title = "Finish homework", Description = "Math and Science", IsDone = true }
        };

        // GET: /Todo
        public IActionResult Index()
        {
            return View(_items);
        }

        // GET: /Todo/Create
        public IActionResult Create()
        {
            var vm = new TodoFormViewModel
            {
                PageTitle = "Create New Task"
            };
            return View(vm);
        }

        // POST: /Todo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TodoFormViewModel form)
        { // <--- ENSURE BREAKPOINT IS HERE
            if (ModelState.IsValid)
            {
                var item = new TodoItem
                {
                    Id = _items.Count + 1,
                    Title = form.Title,
                    Description = form.Description,
                    IsDone = form.IsDone
                };
                _items.Add(item);
                TempData["Success"] = "Task created using a ViewModel!";
                return RedirectToAction("Index");
            }
            form.PageTitle = "Create New Task"; 
            return View(form);
        }

        public IActionResult Details(int id)
        {
            var item = _items.FirstOrDefault(t => t.Id == id);
            if (item == null) return NotFound();
            return View(item);
        }

        // GET: /Todo/Edit/1
        public IActionResult Edit(int id)
        {
            var item = _items.FirstOrDefault(t => t.Id == id);
            if (item == null) return NotFound();
            return View(item);
        }

        // POST: /Todo/Edit/1
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, TodoItem updatedItem)
        {
            if (!ModelState.IsValid) return View(updatedItem);

            var item = _items.FirstOrDefault(t => t.Id == id);
            if (item == null) return NotFound();

            item.Title = updatedItem.Title;
            item.Description = updatedItem.Description;
            item.IsDone = updatedItem.IsDone;

            return RedirectToAction("Index");
        }

        // GET: /Todo/Delete/1
        public IActionResult Delete(int id)
        {
            var item = _items.FirstOrDefault(t => t.Id == id);
            if (item == null) return NotFound();
            return View(item);
        }

        // POST: /Todo/Delete/1
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var item = _items.FirstOrDefault(t => t.Id == id);
            if (item != null)
            {
                _items.Remove(item);
            }
            return RedirectToAction("Index");
        }
    }
}

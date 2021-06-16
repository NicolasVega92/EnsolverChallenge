using ToDoMVC.Data;
using ToDoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoMVC.Controllers
{
    public class FolderController : Controller
    {
        private readonly ToDoDbContext _db;
        public FolderController(ToDoDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Folder> folderList = _db.Folders;
            return View(folderList);
        }
        //Get-Create
        public IActionResult Create()
        {
            return View();
        }
        //POST-Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Folder obj)
        {
            _db.Folders.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

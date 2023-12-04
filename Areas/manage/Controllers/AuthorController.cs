using Microsoft.AspNetCore.Mvc;
using MVC_project_crud_fileupload.DAL;
using MVC_project_crud_fileupload.Models;

namespace MVC_project_crud_fileupload.Areas.manage.Controllers
{
    [Area("manage")]
    public class AuthorController : Controller
    {
        private readonly AppDbContext _context;
        public AuthorController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Author>Authors=_context.Authors.ToList();
            return View(Authors);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Author author)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            if(_context.Authors.Any(x=>x.FullName==author.FullName)) {
                ModelState.AddModelError("FullName", "Author already exist");
                return View();
            
            }
            _context.Authors.Add(author);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult Update(int id)
        {
            var existauthor = _context.Authors.FirstOrDefault(x=>x.Id==id);
            if(existauthor == null)
            {
                return View();
            }
            return View(existauthor);
        }
        [HttpPost]
        public IActionResult Update(Author author)
        {
            var existauthor = _context.Authors.FirstOrDefault(x=>x.Id==author.Id);  
            if(existauthor == null)
            {
                return View();
            }
            if (_context.Authors.Any(x => x.FullName == author.FullName&&x.Id!=author.Id))
            {
                ModelState.AddModelError("FullName", "Author already exist");
                return View();

            }
            existauthor.FullName = author.FullName;
            _context.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult Delete(int id)
        {
            var existauthor = _context.Authors.FirstOrDefault(x => x.Id ==id);
            if(existauthor == null)
            {
                return View();
            }
            return View(existauthor);

        }
        [HttpPost]
        public IActionResult delete(Author author)
        {
            var existauthor = _context.Authors.FirstOrDefault(x=>x.Id==author.Id);
            _context.Authors.Remove(existauthor);
            _context.SaveChanges();
            return RedirectToAction("index");
        }

    }
}

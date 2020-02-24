using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MediaTracker.Models;
using MediaTracker.Models.ViewModels.Authors;
using MediaTracker.Data;

namespace MediaTracker.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AuthorsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /Authors/
        public async Task<IActionResult> Index()
        {
            IndexViewModel viewModel = new IndexViewModel(_context.Authors.ToList());
            return View(viewModel);
        }

        public async Task<ActionResult> Details(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var author = await _context.Authors.FindAsync(id);

            if (author == null)
            {
                return NotFound();
            }

            return View(author);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View("AuthorForm", new Author(0));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(Author author)
        {
            if(author == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return View("AuthorForm", author);
            }
            else
            {
                try
                {
                    if(author.IsNew())
                    {
                        _context.Authors.Add(author);
                    }
                    else
                    {
                        _context.Authors.Update(author);
                    }
                    
                    await _context.SaveChangesAsync();

                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return RedirectToAction("Index", "Authors");
            }
        }
    }
}
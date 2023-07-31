using BlogApp.Data.Abstract;
using BlogApp.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private IBlogRepository _blogReposiyory;
        private ICategoryRepository _categoryReposiyory;

        public BlogController(IBlogRepository blogRepo, ICategoryRepository categoryRepo)
        {
            _blogReposiyory = blogRepo;
            _categoryReposiyory = categoryRepo;
        }

        public IActionResult Details( int id)
        {
            return View(_blogReposiyory.GetById(id));
        }


        public IActionResult Index(int? id, string q)
        {var query = _blogReposiyory.GetAll()
                         .Where(i => i.IsApproved);

            if (id != null)
            {
                query = query
                    .Where(i => i.CategoryId == id);                    
            }
            if (!string.IsNullOrEmpty(q))
            {
                query = query.Where(i => EF.Functions.Like(i.Title, "%" + q + "%") || EF.Functions.Like(i.Description, "%" + q + "%") || EF.Functions.Like(i.Body, "%" + q + "%"));
            }

            return View(query.OrderByDescending(i => i.Date));
           
        }

        public IActionResult List()
        {
            return View(_blogReposiyory.GetAll());
        }
       
        [HttpGet]
        public IActionResult AddOrUpdate(int? id)
        {
            ViewBag.Categories = new SelectList(_categoryReposiyory.GetAll(), "CategoryId", "Name");
            if (id == null)
            {
                //kayit yapılacak
                return View(new Blog());
            }
            else
            {
                return View(_blogReposiyory.GetById((int)id));
                //güncelleme yapılacak
            }

        }

        [HttpPost]
        public IActionResult AddOrUpdate( Blog entity)
        {//formdan gönderilen bilgileri kayıt eder.
            if (ModelState.IsValid)
            {
                _blogReposiyory.SaveBlog(entity);
                TempData["message"] = $"{entity.Title} Kayit Edildi";
                return RedirectToAction("List");
            }
            ViewBag.Categories = new SelectList(_categoryReposiyory.GetAll(), "CategoryId", "Name");
            return View(entity);

        }

        [HttpGet]
        public IActionResult Delete( int id)
        {
            return View(_blogReposiyory.GetById(id));

        }

        [HttpGet, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int  BlogId)
        {
            _blogReposiyory.DeleteBlog(BlogId);
            TempData["message"] = $"{BlogId} Numarali Kayit Silindi";
            return RedirectToAction("List");

        }
    }
}

using MBS.Infrastructure.Entities;
using MBS.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using DO = MBS.Infrastructure.Entities.Blog;
using BO = MBS.Web.Areas.Admin.Models.Blog;
using MBS.Infrastructure.Repositories;
using MBS.Web.Controllers;

namespace MBS.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private BlogRepository _blogRepository;
        public HomeController(BlogRepository br)
        {
            _blogRepository = br;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult WriteBlog()
        {
            var article = new BO();
            return View();
        }
        [HttpPost,ValidateAntiForgeryToken]
        public IActionResult WriteBlog(BO blog)
        {
            DO bl = new DO();
            bl.Title = blog.Title;
            bl.Article = blog.Article;
            _blogRepository.Insert(bl);
            _blogRepository.Save();
            return View();
        }
        public IActionResult ShowBlogs()
        {
            return View();
        }
        public IActionResult EditBlog(Guid id)
        {
            var blog = _blogRepository.GetById(id);
            BO bo = new BO();
            bo.Title = blog.Title;
            bo.Article = blog.Article;
            return View(bo);
        }
        [HttpPost,ValidateAntiForgeryToken]
        public IActionResult EditBlog(BO blogModel)
        {
            var blEntity = new DO();
            blEntity.Id = blogModel.Id;
            blEntity.Title = blogModel.Title;
            blEntity.Article = blogModel.Article;

            _blogRepository.Update(blEntity);
            _blogRepository.Save();
            return RedirectToAction("showblogs", "home");
        }
        public IActionResult DeleteBlog(Guid id)
        {
            _blogRepository.Delete(id);
            _blogRepository.Save();
            return RedirectToAction("showblogs", "home");
        }
        public IActionResult GetBlog(Guid id)
        {
            var blog = _blogRepository.GetById(id);
            BO bo = new BO();
            bo.Title = blog.Title;
            bo.Article = blog.Article;
            return View(bo);
        }
        public JsonResult GetBlogs()
        {
            var d = _blogRepository.GetBlogs();
            return Json(new { data = d });
        }
    }
}

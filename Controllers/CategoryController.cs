using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.DAL.Interfaces;
using Shop.DAL.Models;

namespace Shop.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryDb _daoCategory;

        public CategoryController(ICategoryDb daoCategory)
        {
            _daoCategory = daoCategory;
        }

        // GET: CategoryController
        public ActionResult Index()
        {
            var category = _daoCategory.GetCategories();
            return View(category);
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            var category = _daoCategory.GetCategoryId(id);
            return View(category);
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoryCreateUpdateModel createModel)
        {
            try
            {
                createModel.ModifyUser = 1;
                createModel.ModifyDate = DateTime.Now;
                _daoCategory.CreateCategory(createModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            var category = _daoCategory.GetCategoryId(id);
            return View(category);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CategoryCreateUpdateModel updateModel)
        {
            try
            {
                updateModel.ModifyUser = 1;
                updateModel.ModifyDate = DateTime.Now;
                _daoCategory.ModifyCategory(updateModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }

}
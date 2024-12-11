using Microsoft.Extensions.Logging;
using Shop.DAL.Context;
using Shop.DAL.Entities;
using Shop.DAL.Exceptions;
using Shop.DAL.Interfaces;
using Shop.DAL.Models;

namespace Shop.DAL.Daos
{
    public class DaoCategory : ICategoryDb
    {
        private readonly ShopContext _context;
        private readonly ILogger<DaoCategory> _logger;

        public DaoCategory(ShopContext context, ILogger<DaoCategory> logger )
        {
            _context = context;
            _logger = logger;
        }

        public void CreateCategory(CategoryCreateUpdateModel categoryCreateUpdate)
        {
            try
            {
                if(categoryCreateUpdate is null) 
                {
                    throw new CategoryDaoException("Debe suministrar el parámetro.");
                }

                Category category = new Category()
                {
                    CategoryId = categoryCreateUpdate.Categoryid,
                    CategoryName = categoryCreateUpdate.Categoryname,
                    Description = categoryCreateUpdate.Description,
                    Creation_User = categoryCreateUpdate.CreationUser,
                    Creation_Date = categoryCreateUpdate.CreationDate,
                    Modify_User = categoryCreateUpdate.ModifyUser,
                    Modify_Date = categoryCreateUpdate.ModifyDate

                };

                _context.Categories.Add(category);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                _logger.LogError("Ocurrió un error creando la categoria", ex.ToString());
            }
        }

        public List<GetCategoryModel> GetCategories()
        {
            List<GetCategoryModel> getCategoriesList = new List<GetCategoryModel>();
            try
            {
                getCategoriesList = (from category in _context.Categories
                                     where category.Deleted == false
                                     select new GetCategoryModel()
                                     {
                                         Categoryid = category.CategoryId,
                                         Categoryname = category.CategoryName,
                                         Description = category.Description,
                                         CreationUser = category.Creation_User,
                                         CreationDate = category.Creation_Date
                                     }).ToList();
            }
            catch (Exception ex)
            {

                _logger.LogError("Ocurrió un obteniendo las categorias", ex.ToString());
            }
            return getCategoriesList;
        }

        public GetCategoryModel GetCategoryId(int CategoryId)
        {
            GetCategoryModel categoryFound = new GetCategoryModel();

            try
            {
                Category? category = _context.Categories.Find(CategoryId);

                categoryFound.Categoryid = category.CategoryId;
                categoryFound.Categoryname = category.CategoryName;
                categoryFound.Description = category.Description;
                categoryFound.CreationUser = category.Creation_User;
                categoryFound.CreationDate = category.Creation_Date;
            }
            catch (Exception ex)
            {

                _logger.LogError("Ocurrió un obteniendo la categoria", ex.ToString());
            }

            return categoryFound;
        }

        public void ModifyCategory(CategoryCreateUpdateModel categoryCreateUpdate)
        {
            try
            {
                Category? categoryToUpdate = _context.Categories.Find(categoryCreateUpdate.Categoryid);

                categoryToUpdate.CategoryName = categoryCreateUpdate.Categoryname;
                categoryToUpdate.Description = categoryCreateUpdate.Description;
                categoryToUpdate.Modify_User = categoryCreateUpdate.ModifyUser;
                categoryToUpdate.Modify_Date = categoryCreateUpdate.ModifyDate;
                categoryToUpdate.Creation_User = categoryCreateUpdate.CreationUser;
                categoryToUpdate.Creation_Date = categoryCreateUpdate.CreationDate;

                _context.Categories.Update(categoryToUpdate);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                _logger.LogError("Ocurrió un modificando la categoria", ex.ToString());
            }
        }

        public void RemoveCategory(CategoryRemoveModel categoryRemove)
        {
            try
            {
                Category? categoryToRemove = _context.Categories.Find(categoryRemove.Categoryid);

                categoryToRemove.Deleted = true;
                categoryToRemove.Delete_User = categoryRemove.DeleteUser;
                categoryToRemove.Delete_Date = categoryRemove.DeleteDate;

                _context.Categories.Update(categoryToRemove);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                _logger.LogError("Ocurrió un obteniendo creando o actualizando la categoria", ex.ToString());
            }
        }
    }
}

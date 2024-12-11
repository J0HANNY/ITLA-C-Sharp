
using Shop.DAL.Entities;
using Shop.DAL.Models;

namespace Shop.DAL.Interfaces
{
    public interface ICategoryDb
    {
        void CreateCategory(Models.CategoryCreateUpdateModel categoryCreateUpdate);
        void ModifyCategory(Models.CategoryCreateUpdateModel categoryCreateUpdate);
        void RemoveCategory(CategoryRemoveModel categoryRemove);
        GetCategoryModel GetCategoryId(int CategoryId);
        List<GetCategoryModel> GetCategories();   
    }
}

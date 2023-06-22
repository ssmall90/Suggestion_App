namespace Suggestion_App_Library.DataAccess
{
    public interface ICategoryData
    {
        Task CreateCategory(CategoryModel category);
        Task<List<CategoryModel>> GetAllCategories();
    }
}
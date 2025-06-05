using BusinessObjects.Models;

namespace DataAccessObjects
{
    public class CategoryDAO
    {
        public static List<Category> GetCategories()
        {
            using var context = new MyStoreContext();
            return context.Categories.ToList();
        }

        public static Category? GetCategoryById(int id)
        {
            using var context = new MyStoreContext();
            return context.Categories.FirstOrDefault(c => c.CategoryId == id);
        }

        public static void SaveCategory(Category category)
        {
            using var context = new MyStoreContext();
            context.Categories.Add(category);
            context.SaveChanges();
        }

        public static void UpdateCategory(Category category)
        {
            using var context = new MyStoreContext();
            context.Categories.Update(category);
            context.SaveChanges();
        }

        public static void DeleteCategory(Category category)
        {
            using var context = new MyStoreContext();
            context.Categories.Remove(category);
            context.SaveChanges();
        }
    }
}

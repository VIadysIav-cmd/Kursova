using AdminService.Interfaces;

namespace AdminService.Services
{
    public class ProductQueryBuiler : IGetQueryBuilder, ISearchQueryBuilder
    {
        public string GetPublicQuery()   =>
        "SELECT Parts.Name as Товар, Quantity as Кількість, Price as Ціна, Location as Відділ, Barcode as Штрих, Categories.Name as Категорія FROM Parts join Categories on Parts.CategoryID = Categories.CategoryID";

        public string GetAllCateroryNamesQuery() =>
            "SELECT Name FROM Categories";

        public string SearchNameQuery(string search)
        {
            string like = $"WHERE Parts.Name LIKE '%{search}%'";

            return $"{GetPublicQuery()} {like}";
        }

        public string SearchCategoryQuery(string search)
        {
            string like = $"WHERE Categories.Name LIKE '%{search.Trim()}%'";

            return $"{GetPublicQuery()} {like}";
        }

        public string ProductSearchLocationQuery(string search)
        {
            string like = $"WHERE Location LIKE '%{search.Trim()}%'";
            return $"{GetPublicQuery()} {like}";
        }

        public string InsertProductQuery()
        {
            return "INSERT INTO Parts (Name, CategoryID, Quantity, Price, Location, Barcode) VALUES (@Productname, @CategoryName, 0, @Price, @Location, @Barcode)";
        }

        public string DeleteProductQuery()
        {
            return "DELETE FROM Parts WHERE Name = @name and Barcode = @barcode";
        }

        public string CategoryIdByNameQuery()
        {
            return "SELECT CategoryID FROM Categories WHERE Name = @CategoryName";
        }
    }
}

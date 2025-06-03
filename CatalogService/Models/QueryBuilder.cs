

namespace CatalogService.Models
{
    public class QueryBuilder
    {
        public static string GetPublicPartsQuery() =>
        "SELECT Name as Товар, Price as Ціна, Location as [На складі], " +
        "CASE WHEN Quantity > 10 THEN 'Є в наявності' " +
        "WHEN Quantity > 0 THEN 'Скоро закінчиться' " +
        "ELSE 'Нема в наявності' END as Наявність FROM Parts";

        public static string GetAdminPartsQuery() =>
            "SELECT Name as Товар, Price as Ціна, Location as [На складі], Quantity as Кількість FROM Parts";

        public static string GetSearchNameQuery(string search, bool isAdmin)
        {
            string like = $"WHERE Name LIKE '%{search}%'";
            return isAdmin ? $"{GetAdminPartsQuery()} {like}" : $"{GetPublicPartsQuery()} {like}";
        }
    }
}

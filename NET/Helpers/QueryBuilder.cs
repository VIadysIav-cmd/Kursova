

namespace NET.Helpers
{
    public class QueryBuilder
    {
        public static string GetPublicPartsQuery() =>
        "SELECT Name as Название, Price as Цена, Location as [На складе], " +
        "CASE WHEN Quantity > 10 THEN 'Есть в наличии' " +
        "WHEN Quantity > 0 THEN 'Скоро закончится' " +
        "ELSE 'Нет в наличии' END as Наличие FROM Parts";

        public static string GetAdminPartsQuery() =>
            "SELECT Name as Название, Price as Цена, Location as [На складе], Quantity as Количество FROM Parts";

        public static string GetSearchQuery(string search, bool isAdmin)
        {
            string like = $"WHERE Name LIKE '%{search.Trim()}%'";
            return isAdmin ? $"{GetAdminPartsQuery()} {like}" : $"{GetPublicPartsQuery()} {like}";
        }
    }
}

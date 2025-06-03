

namespace AdminService.Services
{
    public class MainQueryBuilder 
    {
        public string UpdateQuantityQuery() =>
        "UPDATE Parts SET Quantity = Quantity + @Quantity WHERE Name = @Name";
        
    }
}

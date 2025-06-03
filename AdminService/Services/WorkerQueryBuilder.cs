using AdminService.Interfaces;

namespace AdminService.Services
{
    public class WorkerQueryBuilder : IGetQueryBuilder, ISearchQueryBuilder
    {
        public string GetPublicQuery() =>
        "SELECT Username as [Ім'я], PasswordHash as Пароль, RoleName as Посада FROM Roles join Users on Roles.RoleID = Users.RoleID";

        public string GetAllCateroryNamesQuery() =>
        "SELECT RoleName FROM Roles";

        public string SearchNameQuery(string search)
        {
            string like = $"WHERE Username LIKE '%{search.Trim()}%'";
            return $"{GetPublicQuery()} {like}";
        }

        public string SearchCategoryQuery(string search)
        {
            string like = $"WHERE RoleName LIKE '%{search.Trim()}%'";
            return $"{GetPublicQuery()} {like}";
        }



        public string RoleIdByNameQuery() =>
        "SELECT RoleID FROM Roles WHERE RoleName = @RoleName";

        public string InsertUserQuery() =>
        "INSERT INTO Users (Username, PasswordHash, RoleID) VALUES (@Username, @PasswordHash, @RoleID)";

        public string DeleteUserQuery() =>
        "DELETE FROM Users WHERE Username = @Username and PasswordHash = @Password";
        
    }
}



namespace AdminService.Interfaces
{
    public interface ISearchQueryBuilder
    {
        string SearchNameQuery(string search);

        string SearchCategoryQuery(string search);
    }
}

using ETicaret.Application.Repositories.Category;
using ETicaret.Persistence.Contexts;

namespace ETicaret.Persistence.Repositories.Category
{
    public class CategoryReadRepository : ReadRepository<Domain.Entities.Category>, ICategoryReadRepository
    {
        public CategoryReadRepository(ETicaretDbContext context) : base(context)
        {
        }
    }

}

using ETicaret.Application.Repositories.Category;
using ETicaret.Persistence.Contexts;

namespace ETicaret.Persistence.Repositories.Category
{
    public class CategoryWriteRepository : WriteRepository<Domain.Entities.Category>, ICategoryWriteRepository
    {
        public CategoryWriteRepository(ETicaretDbContext context) : base(context)
        {
        }
    }
}

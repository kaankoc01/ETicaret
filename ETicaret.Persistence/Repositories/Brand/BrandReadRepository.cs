using ETicaret.Application.Repositories.Brand;
using ETicaret.Persistence.Contexts;

namespace ETicaret.Persistence.Repositories.Brand
{
    public class BrandReadRepository : ReadRepository<Domain.Entities.Brand>, IBrandReadRepository
    {
        public BrandReadRepository(ETicaretDbContext context) : base(context)
        {
        }
    }
}

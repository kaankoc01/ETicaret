using ETicaret.Application.Repositories.Brand;
using ETicaret.Persistence.Contexts;

namespace ETicaret.Persistence.Repositories.Brand
{
    public class BrandWriteRepository : WriteRepository<Domain.Entities.Brand>, IBrandWriteRepository
    {
        public BrandWriteRepository(ETicaretDbContext context) : base(context)
        {
        }
    }

}

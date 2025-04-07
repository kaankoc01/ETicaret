using ETicaret.Application.Repositories.Product;
using ETicaret.Persistence.Contexts;

namespace ETicaret.Persistence.Repositories.Product
{
    public class ProductReadRepository : ReadRepository<Domain.Entities.Product>, IProductReadRepository
    {
        public ProductReadRepository(ETicaretDbContext context) : base(context)
        {
        }
    }

}

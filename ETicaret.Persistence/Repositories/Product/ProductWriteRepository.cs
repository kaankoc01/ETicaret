using ETicaret.Application.Repositories.Product;
using ETicaret.Persistence.Contexts;

namespace ETicaret.Persistence.Repositories.Product
{
    public class ProductWriteRepository : WriteRepository<Domain.Entities.Product>, IProductWriteRepository
    {
        public ProductWriteRepository(ETicaretDbContext context) : base(context)
        {
        }
    }
}

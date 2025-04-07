using ETicaret.Domain.Entities.Common;

namespace ETicaret.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public string? Description { get; set; }

        public bool IsActive { get; set; }

        public int Stock { get; set; }

        public Guid? CategoryId { get; set; }
        public virtual Category? Category { get; set; }

        public Guid? BrandId { get; set; }
        public virtual Brand? Brand { get; set; }
    }
}

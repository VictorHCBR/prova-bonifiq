using ProvaPub.Models;
using ProvaPub.Repository;

namespace ProvaPub.Services
{
    public class ProductService
    {
        TestDbContext _ctx;

        public ProductService(TestDbContext ctx)
        {
            _ctx = ctx;
        }

        public ProductList ListProducts(int page)
        {
            var products = new List<Product>();

            int idx, bound;
            idx = page == 1 ? 0 : (page - 1) * 10;
            bound = page * 10;

            for (int i = idx; i < bound; i++)
            {
                products.Add(_ctx.Products.ToList()[i]);
            }

            return new ProductList()
            {
                HasNext = false,
                TotalCount = 10,
                Products = products
            };
        }
    }
}

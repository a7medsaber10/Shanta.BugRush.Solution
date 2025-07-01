using Shanta.Core.Entities.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Shanta.Repository.Data
{
    public class StoreContextSeed
    {
        public async static Task SeedAsync(StoreContext dbContext)
        {
            var brandData = File.ReadAllText("../Shanta.Repository/Data/DataSeeding/brands.json");

            var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandData);

            if (brands.Count() > 0)
            {
                if (dbContext.ProductBrands.Count() == 0)
                {
                    foreach (var brand in brands)
                    {
                        dbContext.Set<ProductBrand>().Add(brand);

                    }
                    await dbContext.SaveChangesAsync();
                }
            }

            // **************************************************************************************************

            var categoryData = File.ReadAllText("../Shanta.Repository/Data/DataSeeding/categories.json");

            var categories = JsonSerializer.Deserialize<List<ProductCategory>>(categoryData);

            if (categories.Count() > 0)
            {
                if (dbContext.ProductCategories.Count() == 0)
                {
                    foreach (var category in categories)
                    {
                        dbContext.Set<ProductCategory>().Add(category);

                    }
                    await dbContext.SaveChangesAsync();
                }
            }

            // **************************************************************************************************

            var productData = File.ReadAllText("../Shanta.Repository/Data/DataSeeding/products.json");

            var products = JsonSerializer.Deserialize<List<Product>>(productData);

            if (products.Count() > 0)
            {
                if (dbContext.Products.Count() == 0)
                {
                    foreach (var product in products)
                    {
                        dbContext.Set<Product>().Add(product);

                    }
                    await dbContext.SaveChangesAsync();
                }
            }
        }
    }
}

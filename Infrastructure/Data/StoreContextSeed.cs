using Core.Entities;

namespace Infrastructure.Data
{
    public static class StoreContextSeed
    {
        public async static Task SeedAsync(StoreContext context)
        {
            if (!context.ProductBrands.Any())
            {
                context.ProductBrands.Add(new ProductBrand { Name = "Brand 1" });
                context.ProductBrands.Add(new ProductBrand { Name = "Brand 2" });
                context.ProductBrands.Add(new ProductBrand { Name = "Brand 3" });
                context.ProductBrands.Add(new ProductBrand { Name = "Brand 4" });
                context.ProductBrands.Add(new ProductBrand { Name = "Brand 5" });

                await context.SaveChangesAsync();
            }


            if (!context.ProductTypes.Any())
            {
                context.ProductTypes.Add(new ProductType { Name = "Type 1" });
                context.ProductTypes.Add(new ProductType { Name = "Type 2" });
                context.ProductTypes.Add(new ProductType { Name = "Type 3" });
                context.ProductTypes.Add(new ProductType { Name = "Type 4" });
                context.ProductTypes.Add(new ProductType { Name = "Type 5" });

                await context.SaveChangesAsync();
            }

            if (!context.Products.Any())
            {
                var pro = new Product
                {
                    Name = "product 1",
                    Price = 5,
                    Description = "there is a little",
                    ProductBrandId = 1,
                    ProductTypeId = 1,
                    PictureUrl = "url"
                };
                context.Products.Add(pro);

                pro = new Product
                {
                    Name = "product 2",
                    Price = 8,
                    Description = "there is a little",
                    ProductBrandId = 2,
                    ProductTypeId = 2,
                    PictureUrl = "url"
                };
                context.Products.Add(pro);

                pro = new Product
                {
                    Name = "product 3",
                    Price = 78,
                    Description = "there is a little",
                    ProductBrandId = 3,
                    ProductTypeId = 3,
                    PictureUrl = "url"
                };
                context.Products.Add(pro);
                await context.SaveChangesAsync();
            }

            await context.SaveChangesAsync();
        }
    }
}
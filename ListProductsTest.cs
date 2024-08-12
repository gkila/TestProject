using NUnit.Framework;
using NUnit.Framework.Interfaces;

public class ListProductsTest
    {
        private Program p;


        [SetUp]
        public void Setup()
        {
            p = new Program();

        }

        [TearDown]
        public void Teardown()
        {
            
        }
    
        [Test]
         public void TestSortByPriceDescending()
        {
        var products = new List<Product>
            {
            new Product { Name = "Product A", Price = 100, Stock = 5 },
            new Product { Name = "Product B", Price = 200, Stock = 3 },
            new Product { Name = "Product C", Price = 50, Stock = 10 }
            };

        var sortedProducts = p.ListProducts(products, "price", false);

        Assert.That(sortedProducts[0].Name, Is.EqualTo("Product B"));
        Assert.That(sortedProducts[1].Name, Is.EqualTo("Product A"));
        Assert.That(sortedProducts[2].Name, Is.EqualTo("Product C"));
        }

        [Test]
         public void TestSortByPriceAscending()
        {
        var products = new List<Product>
            {
            new Product { Name = "Product A", Price = 100, Stock = 5 },
            new Product { Name = "Product B", Price = 200, Stock = 3 },
            new Product { Name = "Product C", Price = 50, Stock = 10 }
            };

        var sortedProducts = p.ListProducts(products, "price", true);

        Assert.That(sortedProducts[0].Name, Is.EqualTo("Product C"));
        Assert.That(sortedProducts[1].Name, Is.EqualTo("Product A"));
        Assert.That(sortedProducts[2].Name, Is.EqualTo("Product B"));
        }
    }
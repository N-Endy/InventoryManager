public class ProductRepository : IProductRepository
{
    private readonly List<Product> _products = new();

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void RemoveProduct(int productId)
    {
        var productToRemove = _products.FirstOrDefault(p => p.ProductId == productId);
        if (productToRemove != null)
            _products.Remove(productToRemove);
        // else
        //     Console.WriteLine("Product does not exist.");
    }

    public void UpdateProduct(Product product)
    {
        var productToUpdate = _products.FirstOrDefault(p => p.ProductId == product.ProductId);

        if (productToUpdate != null)
        {
            productToUpdate.Name = product.Name;
            productToUpdate.Description = product.Description;
            productToUpdate.Price = product.Price;
            productToUpdate.Quantity = product.Quantity;
        }
        // else
        // {
        //     Console.WriteLine("Product does not exist.");
        // }
    }

    public Product GetProductById(int productId)
    {
        return _products.FirstOrDefault(p => p.ProductId == productId);
    }

    public IEnumerable<Product> GetAllProducts()
    {
        return _products;
    }

    public Product CreateProduct()
    {
        Product newProduct = new();
        Console.Write("Enter ID for Product");
        newProduct.ProductId = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Product Name: ");
        newProduct.Name = Console.ReadLine();
        Console.Write("Enter Product Description: ");
        newProduct.Description = Console.ReadLine();
        Console.Write("Enter Product Price: ");
        newProduct.Price = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Enter Product Quantity: ");
        newProduct.Quantity = Convert.ToInt32(Console.ReadLine());
        return newProduct;
    }
}
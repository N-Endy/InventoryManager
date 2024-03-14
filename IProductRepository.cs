public interface IProductRepository
{
    void AddProduct(Product product);
    void RemoveProduct(string productId);
    void UpdateProduct(Product product);
    Product GetProductById(string productId);
    void GetAllProducts();
    Product CreateProduct();
}
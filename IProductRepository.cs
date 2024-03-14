public interface IProductRepository
{
    void AddProduct(Product product);
    void RemoveProduct(string productId);
    void UpdateProduct(Product product);
    void GetProductById(string productId);
    void GetAllProducts();
}
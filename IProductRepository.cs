public interface IProductRepository
{
    void AddProduct(Product product);
    void RemoveProduct(int productId);
    void UpdateProduct(Product product);
    Product GetProductById(int productId);
    void GetAllProducts();
    Product CreateProduct();
}
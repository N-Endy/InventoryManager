public interface IProductUserInteraction
{
    void ShowMessage(string message);
    void Exit();
    void PrintAllProducts(List<Product> allProducts);
    void PrintSingleProduct(Product product);
    void PromptToSelectOption();
    Product CreateProduct();
}
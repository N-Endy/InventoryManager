public interface IProductUserInteractions
{
    void ShowMessage(string message);
    void Exit();
    void PrintAllProducts(List<Product> allProducts);
    void PromptToSelectOption();
}
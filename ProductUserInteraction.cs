
public class ProductUserInteraction : IProductUserInteraction
{
    public void Exit()
    {
        Console.WriteLine("Exiting...");
        Thread.Sleep(1000);
        Environment.Exit(0);
    }

    public void PrintAllProducts(List<Product> allProducts)
    {
        if (allProducts.Any())
        {
            Console.WriteLine("Available products are:" + Environment.NewLine);

            var counter = 1;
            foreach (var product in allProducts)
            {
                Console.WriteLine($"*****{counter}*****");
                Console.WriteLine(product);
                Console.WriteLine();
                ++counter;
            }
        }
        else
        {
            Console.WriteLine("No products available.");
        }
    }

    public void PromptToSelectOption()
    {
        Console.WriteLine("\nInventory Management System");
        Console.WriteLine("1. Add Product");
        Console.WriteLine("2. Remove Product");
        Console.WriteLine("3. Update Product");
        Console.WriteLine("4. Display All Products");
        Console.WriteLine("5. Display Single Products");
        Console.WriteLine("6. Exit");

        Console.Write("\nEnter your choice: ");
    }

    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
        Thread.Sleep(1000);
    }
}
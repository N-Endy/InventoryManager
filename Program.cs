IProductRepository productRepository = new ProductRepository(new ProductUserInteraction());
IProductUserInteraction userInteraction = new ProductUserInteraction();
var inventoryManager = new InventoryManager(productRepository, userInteraction);

while (true)
{
    userInteraction.PromptToSelectOption();
    var choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            // Add Product
            Product newProduct = productRepository.CreateProduct();
            inventoryManager.AddProduct(newProduct);
            break;
        case "2":
            // Remove Product
            userInteraction.ShowMessage("\nEnter Product ID to remove: ");
            var removeProductID = Console.ReadLine();
            inventoryManager.RemoveProduct(removeProductID);
            break;
        case "3":
            // Update Product
            Product updatedProduct = productRepository.CreateProduct();
            inventoryManager.UpdateProduct(updatedProduct);
            break;
        case "4":
            // Display All Products
            inventoryManager.GetAllProducts();
            break;
        case "5":
            // Display Single Product
            Console.WriteLine("Exiting...");
            Environment.Exit(0);
            break;
        case "6":
            // Exit program
            Console.WriteLine("Exiting...");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}

// Read
// Prompt message
// Read input from user
    // Add Products and show message.
    // Remove Products by id and show message
    // Update Product
    // Display.
// Exit
IProductRepository productRepository = new ProductRepository(new ProductUserInteraction());
IProductUserInteraction userInteraction = new ProductUserInteraction();
var inventoryManager = new InventoryManager(productRepository, userInteraction);

while (true)
{
    Console.WriteLine("\nInventory Management System");
    Console.WriteLine("1. Add Product");
    Console.WriteLine("2. Remove Product");
    Console.WriteLine("3. Update Product");
    Console.WriteLine("4. Display All Products");
    Console.WriteLine("5. Exit");

    Console.Write("Enter your choice: ");
    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            // Add Product
            Product newProduct = productRepository.CreateProduct();
            inventoryManager.AddProduct(newProduct);
            break;
        case 2:
            // Remove Product
            Console.Write("Enter Product ID to remove: ");
            int removeProductID = Convert.ToInt32(Console.ReadLine());
            inventoryManager.RemoveProduct(removeProductID);
            break;
        case 3:
            // Update Product
            Product updatedProduct = productRepository.CreateProduct();
            inventoryManager.UpdateProduct(updatedProduct);
            break;
        case 4:
            // Display All Products
            inventoryManager.GetAllProducts();
            break;
        case 5:
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
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
            Product newProduct = userInteraction.CreateProduct();
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
            Product updatedProduct = userInteraction.CreateProduct();
            inventoryManager.UpdateProduct(updatedProduct);
            break;
        case "4":
            // Display All Products
            inventoryManager.GetAllProducts();
            break;
        case "5":
            // Display Single Product
            userInteraction.ShowMessage("\nEnter Product ID to be displayed: ");
            var productIdToBeDisplayed = Console.ReadLine();
            inventoryManager.GetProductById(productIdToBeDisplayed);
            Environment.Exit(0);
            break;
        case "6":
            // Exit program
            userInteraction.Exit();
            break;
        default:
            userInteraction.ShowMessage("\nInvalid choice. Please try again.");
            break;
    }
}
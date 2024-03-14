Console.WriteLine("\nInventory Management System");
Console.WriteLine("\nChoose an option from the below options");
Console.WriteLine("1. Add Product");
Console.WriteLine("2. Remove Product");
Console.WriteLine("3. Update Product");
Console.WriteLine("4. Display All Products");
Console.WriteLine("5. Exit");

int productOption;
int.TryParse(Console.ReadLine(), out productOption);


// while (true)
//         {
//             Console.WriteLine("\nInventory Management System");
//             Console.WriteLine("1. Add Product");
//             Console.WriteLine("2. Remove Product");
//             Console.WriteLine("3. Update Product");
//             Console.WriteLine("4. Display All Products");
//             Console.WriteLine("5. Exit");

//             Console.Write("Enter your choice: ");
//             int choice = Convert.ToInt32(Console.ReadLine());

//             switch (choice)
//             {
//                 case 1:
//                     // Add Product
//                     Product newProduct = CreateProduct();
//                     inventoryManager.AddProduct(newProduct);
//                     break;
//                 case 2:
//                     // Remove Product
//                     Console.Write("Enter Product ID to remove: ");
//                     int removeProductID = Convert.ToInt32(Console.ReadLine());
//                     inventoryManager.RemoveProduct(removeProductID);
//                     break;
//                 case 3:
//                     // Update Product
//                     Product updatedProduct = CreateProduct();
//                     inventoryManager.UpdateProduct(updatedProduct);
//                     break;
//                 case 4:
//                     // Display All Products
//                     inventoryManager.DisplayAllProducts();
//                     break;
//                 case 5:
//                     // Exit program
//                     Console.WriteLine("Exiting...");
//                     Environment.Exit(0);
//                     break;
//                 default:
//                     Console.WriteLine("Invalid choice. Please try again.");
//                     break;
//             }
//         }
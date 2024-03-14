public class Product
{
    const string currency = "NGN";
    public string ProductId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public override string ToString() => $"{Name}\n{Description}\n{currency}{Price}\n{Quantity}";
}

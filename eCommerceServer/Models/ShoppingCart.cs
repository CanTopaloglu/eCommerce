namespace eCommerceServer.Models;

public sealed class ShoppingCart
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public Product? Product { get; set; } //null check yapmak en mantıklısı newleyip instance türetmektense.
    public int Quantity { get; set; }
    public int UserId { get; set; }
    public AppUser? User { get; set; }

}

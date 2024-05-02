namespace eCommerceServer.Models;

public sealed class Product
{
    public int Id { get; set; } /*0*/
    public string Name { get; set; } = string.Empty; /*null*/
    public decimal Price { get; set; }
    public string CoverImageUrl { get; set; }  = string.Empty;
}

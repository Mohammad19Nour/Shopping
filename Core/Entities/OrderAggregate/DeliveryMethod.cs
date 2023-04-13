namespace Core.Entities.OrderAggregate;

public class DeliveryMethod : BaseEntity
{
    public string ShorName { get; set; }
    public string DeliveryTime { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
}
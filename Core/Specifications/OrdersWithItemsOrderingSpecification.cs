using System.Linq.Expressions;
using Core.Entities.OrderAggregate;

namespace Core.Specifications;

public class OrdersWithItemsOrderingSpecification : BaseSpecification<Order>
{
    public OrdersWithItemsOrderingSpecification(int id, string email)
        : base(o => o.BuyerEmail == email && o.Id == id)
    {
        AddInclude(o => o.OrderItems);
        AddInclude(o => o.DeliveryMethod);
        AddOrderByDesc(o => o.OrderDate);
    }

    public OrdersWithItemsOrderingSpecification(string email)
        : base(o => o.BuyerEmail == email)
    {
        AddInclude(o => o.OrderItems);
        AddInclude(o => o.DeliveryMethod);
        AddOrderByDesc(o => o.OrderDate);
    }
}
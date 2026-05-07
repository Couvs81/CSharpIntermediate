namespace Testability
{
    public interface IShippingCalculator
    {
        decimal CalculateShipping(Order order);
    }

    public class ShippingCalculator : IShippingCalculator
    {
        public decimal CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30.00m)
                return order.TotalPrice * 0.1m;
            return 0;
        }
    }
}

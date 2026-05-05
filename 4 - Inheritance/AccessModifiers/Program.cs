using Amazon;

namespace AccessModifiers
{

    public class GoldCustomer : Customer
    {
        public void OfferVoucher()
        {
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
            {
                var customer = new Customer();
                //  customer.CalculateRating(); // cannot access private member


            }
        }
}

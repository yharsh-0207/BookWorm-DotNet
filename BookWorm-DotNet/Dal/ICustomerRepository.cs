using BookWorm_DotNet.Models;

namespace BookWorm_DotNet.Dal
{
    public interface ICustomerRepository
    {
        Customer LoginUser(String email, String password);
        long AddCustomer(Customer customer);
    }
}

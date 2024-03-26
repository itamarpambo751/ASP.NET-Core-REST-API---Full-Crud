using REST_API___APS.NET_Core.Models;

namespace REST_API___APS.NET_Core.Repositories
{
    public interface ICustomerRepository
    {
        Customer Create(Customer customer);
        Customer ReadOne(int id);
        Customer ReadByEmail(string email);
        Boolean ReadByEmailBool(string email);
        List<Customer> ReadMany();
        Customer UpdateOne(Customer customer);
        List<Customer> DeleteOne(int id);
    }
}

using REST_API___APS.NET_Core.Models;
using REST_API___APS.NET_Core.Repositories;

namespace REST_API___APS.NET_Core.Services
{
    public class ReadAllCustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public ReadAllCustomerService()
        {
            this._customerRepository = new CustomerRepository();
        }

        public List<Customer> Execute() {
            return this._customerRepository.ReadMany();
        }
    }
}

using REST_API___APS.NET_Core.Models;
using REST_API___APS.NET_Core.Repositories;

namespace REST_API___APS.NET_Core.Services
{
    public class ReadOneCustomerService
    {
        private readonly CustomerRepository _customerRepository;
        public ReadOneCustomerService() {
            this._customerRepository = new CustomerRepository();
        }
        public Customer Execute(int id)
        {
            var customer = this._customerRepository.ReadOne(id);

            return customer ?? throw new Exception("User not found!");
        }
    }
}

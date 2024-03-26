using REST_API___APS.NET_Core.Models;
using REST_API___APS.NET_Core.Repositories;

namespace REST_API___APS.NET_Core.Services
{
    public class DeleteCustomerService
    {
        private readonly CustomerRepository _services;
        public DeleteCustomerService() {
            this._services = new CustomerRepository();
        }

        public List<Customer> Execute(int id)  {
             return _services.DeleteOne(id);
        }
    }
}

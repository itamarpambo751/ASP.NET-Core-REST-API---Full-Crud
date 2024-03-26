using REST_API___APS.NET_Core.Models;
using REST_API___APS.NET_Core.Repositories;

namespace REST_API___APS.NET_Core.Services
{
    public class UpdateCustomerService
    {
        private readonly CustomerRepository _customerRepository;
        public UpdateCustomerService() {
            this._customerRepository = new CustomerRepository();
        }
        public Customer Execute(Customer customer) {
            try
            {
                _customerRepository.ReadOne(customer.Id);

                return _customerRepository.UpdateOne(customer);

            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

using REST_API___APS.NET_Core.Models;
using REST_API___APS.NET_Core.Repositories;

namespace REST_API___APS.NET_Core.Services
{
    public class CreateCustomerService
    {
        private readonly CustomerRepository _customerRepository;
        public CreateCustomerService() {
            this._customerRepository = new CustomerRepository();
        }
        public Customer Execute(Customer data)
        {
            try { 
                _customerRepository.ReadByEmailBool(data.Address);

                return _customerRepository.Create(data);
                
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
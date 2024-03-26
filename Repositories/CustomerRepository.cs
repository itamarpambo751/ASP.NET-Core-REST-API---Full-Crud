using REST_API___APS.NET_Core.Models;

namespace REST_API___APS.NET_Core.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly List<Customer> TbCustomer = [
            new() { Id = 1, Address = "itamarpambo.dev@gmail.com", City = "Luanda", Name = "Itamar Mateus Pedro Pambo"},
            new() { Id = 2, Address = "aureoargelpambo@gmail.com", City = "Luanda", Name = "Áureo Algel Pedro Pambo"},
            new() { Id = 3, Address = "airespambo@gmail.com", City = "Luanda", Name = "Aires Sealtiel Pedro Pambo"},
            new() { Id = 4, Address = "florianajoao@gmail.com", City = "Luanda", Name = "Floriana Diogo João"}    
        ];
        public Customer Create(Customer customer)
        {
            customer.Id = this.TbCustomer.Count + 1;

            this.TbCustomer.Add(customer);

            return this.TbCustomer[TbCustomer.Count - 1];
        }
        public List<Customer> DeleteOne(int id)
        {
            this.TbCustomer.Remove(ReadOne(id));

            return this.TbCustomer;
        }
        public Boolean ReadByEmailBool(string email)
        {
            var customer = this.TbCustomer.SingleOrDefault(customer => customer.Address == email);

            if (customer == null)
            {
                return false;
            }

            throw new Exception("User not found!");
        }
        public Customer ReadByEmail(string email)
        {
            var customer = this.TbCustomer.Single(customer => customer.Address == email);

            return customer;
        }
        public List<Customer> ReadMany()
        {
            return this.TbCustomer;
        }
        public Customer ReadOne(int id)
        {
            var customer = this.TbCustomer.SingleOrDefault(customer => customer.Id == id);

            return customer ?? throw new Exception("Customer was not found!");
        }
        public Customer UpdateOne(Customer customer)
        {
            var foundedCustomer = this.TbCustomer.Single(cust => cust.Id == customer.Id);

            var index = this.TbCustomer.IndexOf(foundedCustomer);

            if (index == -1) throw new Exception("Customer was not found!");

            this.TbCustomer.Insert(index, customer);
            
            return this.TbCustomer[index];
        }
    }
}

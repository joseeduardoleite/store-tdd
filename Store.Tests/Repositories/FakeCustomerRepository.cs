using Store.Domain.Entities;
using Store.Domain.Repositories;

namespace Store.Tests.Repositories
{
    public class FakeCustomerRepository : ICustomerRepository
    {
        public Customer Get(string document)
        {
            if (document == "13245678910")
                return new Customer("José Eduardo", "eduardo@gft.com");

            return null;
        }
    }
}
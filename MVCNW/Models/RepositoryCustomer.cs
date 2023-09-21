using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace MVCNW.Models
{
    public class RepositoryCustomer
    {
        

        private readonly NorthwindContext _context;


        public RepositoryCustomer(NorthwindContext context)

        {

            _context = context;

        }

        public List<string> GetAllCustomerID()

        {

            List<string> result = new List<string>();

            foreach (var customer in _context.Orders)
            {

                result.Add(customer.CustomerId);

            }

            return result;

        }

        public Customer GetCustomer(string id)

        {

            Customer customer = _context.Customers.Find(id);

            return customer;

        }

        public List<Order> GetOrders(string id)

        {

            List<Customer> customers = _context.Customers.Include(o => o.Orders).ToList();

            Customer customer = customers.FirstOrDefault(x => x.CustomerId == id);



            return customer.Orders.ToList();



        }
    }
}

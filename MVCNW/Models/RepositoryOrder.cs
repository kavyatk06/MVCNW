using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace MVCNW.Models
{
    
        public class RepositoryOrder

    {

        private readonly NorthwindContext _context;

        public RepositoryOrder(NorthwindContext context)

        {

            _context = context;

        }

        public Order FindOrderById(int id)

        {

            var order = _context.Orders.Find(id);

            return order;

        }

        public List<OrderDetail> GetOrderDetails(int id)

        {

            List<Order> ordersWithOrderDetails = _context.Orders.Include(o => o.OrderDetails).ToList();

            Order order = ordersWithOrderDetails.FirstOrDefault(x => x.OrderId == id);



            //Order order = _context.Orders.Find(id);

            return order.OrderDetails.ToList();

        }

        public List<int> GetAllOrderId()

        {

            List<int> orderIds = new List<int>();

            foreach (var order in _context.Orders)

            {

                orderIds.Add(order.OrderId);

            }

            return orderIds;

        }



        public List<Order> Orders()

        {

            return _context.Orders.ToList();

        }

    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCNW.Models;


namespace MVCNW.Controllers
{
    public class OrderController : Controller
    {
        private readonly RepositoryOrder _repositoryOrders;
        public OrderController(RepositoryOrder orders)
        {
            _repositoryOrders = orders;
        }
        // GET: OrderController
        //public ActionResult Index()
        //{
        //    order.OrderSelectView = new List<SelectListItem>();
        //    foreach (var list in order.Orders())
        //    {
        //        order.OrderSelectView.Add(new SelectListItem(list.OrderId.ToString(), list.OrderId.ToString()));
        //    }
        //    return View(order);
        //}
        public ActionResult Index()
        {
            List<int> orderIds = _repositoryOrders.GetAllOrderId();
            OrderIdsViewModel idsViewModel = new OrderIdsViewModel(orderIds);
            return View(idsViewModel);
        }
        // GET: OrderController/Details/5
        [HttpPost]
        //public ActionResult Details(RepositoryOrder orderRep)
        //{
        //    Order orders = order.FindOrderById(orderRep.SelectedId);
        //    return View(orders);
        //}



        public ActionResult Details(int id)
        {
            Order order = _repositoryOrders.FindOrderById(id);
            List<OrderDetail> detail = _repositoryOrders.GetOrderDetails(id);
            ViewData["OrderDetail"] = detail;
            return View(order);



        }
        // GET: OrderController/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: OrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        // GET: OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }
        // POST: OrderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        // GET: OrderController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }
        // POST: OrderController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

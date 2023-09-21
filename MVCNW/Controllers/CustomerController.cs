using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCNW.Models;
using NuGet.Protocol.Core.Types;
using System.Runtime.InteropServices;
using System.Security.Policy;

namespace MVCNW.Controllers
{
    public class CustomerController : Controller
    {
        

private RepositoryCustomer repository;



        public CustomerController(RepositoryCustomer repository)

        {

            this.repository = repository;

        }

        // GET: CustomerController

        public ActionResult Index()

        {

            List<string> customerId = repository.GetAllCustomerID();

            CustomerViewModel customerViewModel = new CustomerViewModel(customerId);

            return View(customerViewModel);

        }



        // GET: CustomerController/Details/5

        public ActionResult Details(string id)

        {

            Customer customer = repository.GetCustomer(id);

            List<Order> orders = repository.GetOrders(id);

            ViewData["order"] = orders;

            return View(customer);

        }



        // GET: CustomerController/Create

        public ActionResult Create()

        {

            return View();

        }



        // POST: CustomerController/Create

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



        // GET: CustomerController/Edit/5

        public ActionResult Edit(int id)

        {

            return View();

        }



        // POST: CustomerController/Edit/5

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



        // GET: CustomerController/Delete/5

        public ActionResult Delete(int id)

        {

            return View();

        }



        // POST: CustomerController/Delete/5

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

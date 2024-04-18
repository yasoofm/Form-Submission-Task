using Form_Submission_Task.Models;
using Microsoft.AspNetCore.Mvc;

namespace Form_Submission_Task.Controllers
{
    public class CustomerController : Controller
    {
        static List<Customer> Customers = new List<Customer>();
        public IActionResult Index()
        {
            return View(Customers);
        }

        public IActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            if(ModelState.IsValid)
            {
                Customers.Add(customer);
                return RedirectToAction("Index");
            }
            return View(customer);
        }
    }
}

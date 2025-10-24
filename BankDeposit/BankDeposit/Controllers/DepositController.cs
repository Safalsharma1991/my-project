using Microsoft.AspNetCore.Mvc;

namespace BankDeposit.Controllers
{
    public class DepositController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Models.Deposit deposit)
                {
            ViewBag.Tbalance = deposit.Cbal + deposit.Amount;

            return View();
        }
    }
}

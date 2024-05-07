using FormValidation.Models;
using Microsoft.AspNetCore.Mvc;

namespace FormValidation.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult GetAccount()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PostAccount(AccountModel account)
        {
            if(ModelState.IsValid)
            {
                return View("success");
            }
            return RedirectToAction("GetAccount");
        }
    }
}

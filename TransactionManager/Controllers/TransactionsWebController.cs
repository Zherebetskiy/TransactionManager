using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TransactionManager.Controllers
{
    [Route("transactions-web")]
    public class TransactionsWebController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
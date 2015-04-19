namespace Poc.Deploy.FrontEndApp.Controllers
{
    using System;
    using System.Web.Mvc;

    using Poc.Deploy.FrontEndApp.DataAccess;

    public class HomeController : Controller
    {
        private readonly IEmployersOperations employersOperations;

        private readonly IEmployersRepository employersRepository;

        public HomeController(IEmployersOperations employersOperations, IEmployersRepository employersRepository)
        {
            this.employersOperations = employersOperations;
            this.employersRepository = employersRepository;
        }

        public ActionResult Index()
        {
            var data = employersRepository.GetEmployerSummary(1);
            return View(data);
        }

        public ActionResult HireEmployee()
        {
            employersOperations.HireEmployee(1, DateTime.UtcNow.ToLongTimeString(), 100);
            
            return RedirectToAction("Index");
        }
    }
}
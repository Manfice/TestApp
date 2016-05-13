using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestApp.Repos;

namespace TestApp.Controllers
{
    public class StartController : Controller
    {
        private IRepository _repository;

        public StartController()
        {
            _repository = new DbPersonRepo();
        }
        // GET: Start
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PersonsDetails()
        {
            return View(_repository.GetPersons);
        }
    }
}
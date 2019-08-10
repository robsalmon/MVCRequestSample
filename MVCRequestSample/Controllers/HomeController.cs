using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCRequestSample.Calculator;
using MVCRequestSample.Models;

namespace MVCRequestSample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            AdditionViewModel viewModel = new AdditionViewModel();

            return View(viewModel);
        }
      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(AdditionViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
         
           
            try
            {
                CalculatorSoapClient CalculatorService = new CalculatorSoapClient();
                model.Result = CalculatorService.Add(model.FirstNumber, model.SecondNumber);
                return View(model);
            }
            catch (Exception ex)
            {
                return View(model);
            }
        }

       
    }
}
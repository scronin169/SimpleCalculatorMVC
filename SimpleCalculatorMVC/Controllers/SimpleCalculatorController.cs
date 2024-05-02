

using Microsoft.AspNetCore.Mvc;
using SimpleCalculatorMVC.Models;


namespace SimpleCalculatorMVC.Controllers
{
    public class SimpleCalculatorController : Controller
    {
        public IActionResult Index()
        {
            SimpleCalculatorViewModel viewModel = new SimpleCalculatorViewModel();

            return View(viewModel);
        }


        public IActionResult Add(SimpleCalculatorViewModel viewModel)
        {
            double sum = viewModel.FirstNumber + viewModel.SecondNumber;

            
            viewModel.Result = sum.ToString();


            return View("Index", viewModel);
        }


        public IActionResult Subtract(SimpleCalculatorViewModel viewModel)
        {
            double difference = viewModel.FirstNumber - viewModel.SecondNumber;

            viewModel.Result = difference.ToString();


            return View("Index", viewModel);
        }


        public IActionResult Multiply(SimpleCalculatorViewModel viewModel)
        {
            double product = viewModel.FirstNumber * viewModel.SecondNumber;

            viewModel.Result = product.ToString();

            return View("Index", viewModel);
        }


        public IActionResult Divide(SimpleCalculatorViewModel viewModel)
        {

            if (viewModel.SecondNumber != 0)
            {

                double quotient = viewModel.FirstNumber / viewModel.SecondNumber;

                viewModel.Result = quotient.ToString();
            }

            else
            {
                viewModel.Result = "Division by zero is undefined";
            }

            return View("Index", viewModel);
        }
    }
}



using DatePicker.Models;
using Microsoft.AspNetCore.Mvc;

namespace DatePicker.Controllers
{
    public class DatePickerController : Controller
    {
        
        public IActionResult Index()
        {
            Datepickermodel objPicker = new Datepickermodel();
            return View();
        }

       
        public IActionResult PostData(Datepickermodel objPicker)
        {
            //Datepickermodel objPicker = new Datepickermodel();
            return View();
        }
    }
}

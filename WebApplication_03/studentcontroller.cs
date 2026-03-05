using Microsoft.AspNetCore.Mvc;

namespace routing.Controllers
/*{
    public class studentcontroller : Controller
    {
        [Route ("Details/{id}")]

        public IActionResult Index(int id)
        {
            return Content("Student ID is:"+ id);
        }
        [Route("Marks/{id}/{subject}")]
        public IActionResult Marks(int id, string subject)
        {
            return Content($"Student ID is: {id} Subjects are:{subject}");
        }
    }
}*/
{
    [Route("Student")]
    public class studentcontroller : Controller
    {
        [Route("Input/{id}")]

        public IActionResult Input(int id, string name)
        {
            string message = $"Student ID is: {id} Name are:{name}";
            return Content(message);
        }
    }
}
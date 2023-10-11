using Microsoft.AspNetCore.Mvc;
using MockObjectTesting.Core;

namespace MockObjectTesting.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IGetDataRepository _dataRepository;

        public EmployeeController(IGetDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public string GetNameById(int id)
        {
            return _dataRepository.GetNameById(id);
        }
    }
}

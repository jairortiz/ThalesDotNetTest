using System.Web;
using Microsoft.AspNetCore.Mvc;
using ThalesDotNetTest.Models;
using ThalesDotNetTest.Models.DAL;
using System.Threading.Tasks;

namespace ThalesDotNetTest.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IRepository<Employee> _employeeRepository;

        public EmployeeController(IRepository<Employee> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        //[OutputCache(Duration = 60, VaryByParam = "Id", , Location = OutputCacheLocation.Client)]
        [Route("employees")]
        public async Task<IActionResult> Index(int searchId)
        {
            try
            {
                return searchId <= 0 ? View(await _employeeRepository.GetAll()) : View(await _employeeRepository.GetByIdAsync(searchId));
            }
            catch (System.Exception ex)            {

                throw;
            }
            
        }

        // GET: Employee/5
        [Route("employee/{id}")]
        public async Task<ViewResult> GetEmployeeById(int id)
        {
            try
            {
                return View(await _employeeRepository.Get(id));
            }
            catch (System.Exception ex)
            {
                throw;
            }
            
        }
 
    }
}

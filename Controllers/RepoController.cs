using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebRepo.Repos;
using WebRepo.Models;

namespace WebRepo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepoController : ControllerBase
    {
        public readonly IEmpRepo _cont;

        public RepoController(IEmpRepo cont) {
            _cont = cont;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomer()
        {
            return await _cont.GetCustomer();
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using WebRepo.Models;

namespace WebRepo.Repos
{
    public interface IEmpRepo
    {
        public Task<ActionResult<IEnumerable<Customer>>> GetCustomer();
    }
}

using Microsoft.AspNetCore.Mvc;
using WebRepo.Models;
using Microsoft.EntityFrameworkCore;

namespace WebRepo.Repos
{
    public class EmpRepo : IEmpRepo
    {
            private readonly HuronDbContext _context;

            public EmpRepo(HuronDbContext context)
            {
                _context = context;
            }
            public async Task<ActionResult<IEnumerable<Customer>>> GetCustomer()
            {

                return await _context.Customers.ToListAsync();

            }
        }
    }

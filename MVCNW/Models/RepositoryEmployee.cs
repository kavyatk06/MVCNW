using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;

namespace MVCNW.Models
{
    public class RepositoryEmployee
    {

        private NorthwindContext _context;
         
            public RepositoryEmployee(NorthwindContext context)
            {
                   _context = context;
            }
            public List<Employee> AllEmployees() { 
        

            return _context.Employees.ToList();
            }
        
    }
}


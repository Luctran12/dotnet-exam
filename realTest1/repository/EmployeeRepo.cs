using realTest1.Models;

namespace realTest1.repository
{
    public class EmployeeRepo : IEmployeeRepo
    {
        public ThuchanhContext Context;

        public EmployeeRepo(ThuchanhContext context) {
            this.Context = context;
        }

        public async Task<IEnumerable<Employee>> GetAllStaffs()
        {
            return Context.Employees;
        }

        public async Task<Employee> GetStaffById(int id)
        {
            return (from employee in Context.Employees
                    where employee.Id == id
                    select employee
                    ).First();
        }
    }
}

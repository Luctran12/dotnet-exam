using realTest1.Models;

namespace realTest1.repository
{
    public interface IEmployeeRepo
    {
        Task<IEnumerable<Employee>> GetAllStaffs();
        Task<Employee> GetStaffById(int id);
    }
}

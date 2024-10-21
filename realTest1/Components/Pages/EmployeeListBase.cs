using Microsoft.AspNetCore.Components;
using realTest1.Models;
using realTest1.repository;

namespace realTest1.Components.Pages;

    public class EmployeeListBase : ComponentBase
    {
        [Inject]
        public IEmployeeRepo EmployeeRepo { get; set; }

        public IEnumerable<Employee> Employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Employees = await EmployeeRepo.GetAllStaffs();
        }
    }


using Microsoft.AspNetCore.Components;
using realTest1.Models;
using realTest1.repository;

namespace realTest1.Components.Pages
{
    public class EmployeeDetailBase : ComponentBase
    {
        [Inject]
        public IEmployeeRepo EmployeeRepo { get; set; }

        public Employee Employee { get; set; }

        [Parameter]
        public string id { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Employee = await EmployeeRepo.GetStaffById(Int32.Parse(id));
        }
    }
}

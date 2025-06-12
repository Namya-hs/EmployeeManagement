using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; } = new List<Employee>();

        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadEmployees);
            //return base.OnInitializedAsync();
        }


        private void LoadEmployees()
        {
            //System.Threading.Thread.Sleep(3000);
            Employee e1 = new Employee
            {
                EmployeeId = 1,
                FirstName = "John",
                LastName = "Doe",
                DateOfBirth = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                Department = new Department { DepartmentId = 1, DepartmentName = "Development" },
                Email = "John@gmail.com",
                PhotoPath = "images/person.png"
            };
            Employee e2 = new Employee
            {
                EmployeeId = 2,
                FirstName = "Sam",
                LastName = "Josh",
                DateOfBirth = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                Department = new Department { DepartmentId = 1, DepartmentName = "Development" },
                Email = "Sam@gmail.com",
                PhotoPath = "images/person.png"
            };
            Employee e3 = new Employee
            {
                EmployeeId = 3,
                FirstName = "Mary",
                LastName = "Brown",
                DateOfBirth = new DateTime(1980, 10, 5),
                Gender = Gender.Female,
                Department = new Department { DepartmentId = 1, DepartmentName = "Development" },
                Email = "Mary@gmail.com",
                PhotoPath = "images/person.png"
            };
            Employees = new List<Employee> { e1, e2, e3 };
        }

    }
}

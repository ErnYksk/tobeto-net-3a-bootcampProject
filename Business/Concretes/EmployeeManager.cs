using Business.Abstracts;
using DataAccess.Abstracs;

namespace Business.Concretes
{
    public class EmployeeManager : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeManager(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
    }
}

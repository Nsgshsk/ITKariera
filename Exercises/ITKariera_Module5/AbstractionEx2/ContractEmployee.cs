using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionEx2
{
    public class ContractEmployee : BaseEmployee
    {
        private string employeeTask;
        private string employeeDepartment;

        public string EmployeeTask
        {
            get { return employeeTask; }
            set { employeeTask = value; }
        }
        public string EmployeeDepartment
        {
            set { employeeDepartment = value; }
        }

        public ContractEmployee(string employeeID, string employeeName, string employeeAddress, string employeeTask, string employeeDepartment) : base(employeeID, employeeName, employeeAddress)
        {
            EmployeeTask = employeeTask;
            EmployeeDepartment = employeeDepartment;
        }

        public void Show()
        {
            Console.WriteLine($"EmployeeTask: {EmployeeTask}\nEmployeeDepartment: {GetDepartment()}");
        }

        public override decimal CalculateSalary(int workingHours)
        {
            return 250m + workingHours * 20m;
        }

        public override string GetDepartment()
        {
            return employeeDepartment;
        }
    }
}

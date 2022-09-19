using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionEx2
{
    public class FullTimeEmployee : BaseEmployee
    {
        private string employeePosition;
        private string employeeDepartment;

        public string EmployeePosition
        {
            get { return employeePosition; }
            set { employeePosition = value; }
        }
        public string EmployeeDepartment
        {
            //get { return employeeDepartment; }
            set { employeeDepartment = value; }
        }

        public FullTimeEmployee(string employeeID, string employeeName, string employeeAddress, string employeePosition, string employeeDepartment) : base(employeeID, employeeName, employeeAddress)
        {
            EmployeePosition = employeePosition;
            EmployeeDepartment = employeeDepartment;
        }

        public void Show()
        {
            base.Show();
            Console.WriteLine($"EmployeePosition: {EmployeePosition}\nEpmloyeeDepartment: {GetDepartment()}");
        }

        public override decimal CalculateSalary(int workingHours)
        {
            return 250m + workingHours * 10.8m;
        }

        public override string GetDepartment()
        {
            return employeeDepartment;
        }
    }
}

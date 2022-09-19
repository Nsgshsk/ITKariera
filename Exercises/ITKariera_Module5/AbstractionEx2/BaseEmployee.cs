using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionEx2
{
    public abstract class BaseEmployee
    {
        private string employeeID;
        private string employeeName;
        private string employeeAddress;

        public string EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }
        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }
        public string EmployeeAddress
        {
            get { return employeeAddress; }
            set { employeeAddress = value; }
        }

        public BaseEmployee(string employeeID, string employeeName, string employeeAddress)
        {
            EmployeeID = employeeID;
            EmployeeName = employeeName;
            EmployeeAddress = employeeAddress;
        }

        public void Show()
        {
            Console.WriteLine($"$EpmloyeeID: {EmployeeID}\nEmployeeName: {EmployeeName}\nEmployeeAddress: {EmployeeAddress}");
        }

        public abstract decimal CalculateSalary(int workingHours);
        public abstract string GetDepartment();
    }
}

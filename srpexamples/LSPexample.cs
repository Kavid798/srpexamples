using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srpexamples
{

    public interface IEmployeeDetails
    {
        string GetProjectDetails(int employeeId);
    }
    public interface IGetEmployeeByName
    {
        string GetEmployeeByName(string employeeName);
    }
    public class Employee_Lsp:IEmployeeDetails,IGetEmployeeByName
    {
        public virtual string GetProjectDetails(int employeeId)
        {
            Console.WriteLine(employeeId);
            return "Employee project details";
        }
        public virtual string GetEmployeeByName(string employeeName)
        {
            Console.WriteLine(employeeName);
            return "Employee Personal Details";
        }
    }
    public class PermanentEmployee : Employee_Lsp
    {
        public override string GetProjectDetails(int employeeId)
        {
            Console.WriteLine(employeeId);
            return "Permanent employee Project Details";
        }
        public override string GetEmployeeByName(string employeeName)
        {
            Console.WriteLine(employeeName);
            return "Permanent employee Personal Details";
        }
    }
    public class ContractEmployee : IEmployeeDetails
    {
        public string GetProjectDetails(int employeeId)
        {
            Console.WriteLine(employeeId);
            return "Contract Project Details";
        }

        
    }
    public class employee
    {
        static void Main3(string[] args)
        {

            Employee_Lsp employee = new PermanentEmployee();
            employee.GetProjectDetails(1);
            employee.GetEmployeeByName("Viju");


            ContractEmployee contract = new ContractEmployee();
            contract.GetProjectDetails(1);
        }
    }

}

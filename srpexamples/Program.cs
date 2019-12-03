using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srpexamples
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName{ get; set; }

    }
    public class InsertEmployeeDetails
    {
        public bool InsertIntEmployeeTable(Employee employee)
        {
            if (employee == null)
                throw new Exception();
            Console.WriteLine("successfully inserted");
            return true;
        }
    }
    public class GenerateEmployeeReport
    {
        public void GenerateReport(Employee employee)
        {
            if (employee == null)
                throw new Exception();
            Console.WriteLine("successfully generated");
           

        }
    }
    public class LogManager
    {
        public void ReadLog(string error)
        {
            Console.WriteLine(error);
        }
    }
    public class Employee_srp
    {
        static void Main1(string[] args)
        {
            InsertEmployeeDetails insertEmployeeDetails = new InsertEmployeeDetails();
            GenerateEmployeeReport generateEmployeeReport = new GenerateEmployeeReport();
            Employee e = null;
            try
            {
                insertEmployeeDetails.InsertIntEmployeeTable(e);
                Console.WriteLine("try block");
            }
            catch(Exception ex)
            {
                LogManager log = new LogManager();
                log.ReadLog(ex.Message);
                //Console.WriteLine("catch error");
            }
            //try
            //{
            //    generateEmployeeReport.GenerateReport(e);
            //    Console.WriteLine("try block");
            //}
            //catch (Exception ex)
            //{
            //    LogManager log = new LogManager();
            //    log.ReadLog(ex.Message);
            //    //Console.WriteLine("catch error");
            //}
        }
    }
}

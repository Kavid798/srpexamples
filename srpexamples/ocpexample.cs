using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srpexamples
{
    class ocpexample
    {
        static void Main2(string[] args)
        {
            Create create = new Demat();
            create.CreateAccount(new customer(), "Saving");

        }
    }
    public class customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MobileNumber { get; set; }
    }
    public class CustomerDetails
    {
        //SRP
        public void SerachCustomerById(int Id)
        {
            Console.WriteLine("Search completed");
        }
    }
    

    public class Create
    {
        //ocp
        public virtual void CreateAccount(customer cus, string accType)
        {
            if (accType == "Current")
            {
                Console.WriteLine("successfully created current account");
            }
            else if (accType == "Saving")
            {
                Console.WriteLine("Successfully created savings account");
            }
        }
    }
    public class Demat : Create
    {
        public override void CreateAccount(customer cus, string accType)
        {
            if (accType == "Demat")
            {
                Console.WriteLine("Successfully created demat account");
                return;
            }
            base.CreateAccount(cus, accType);
        }
    }
}

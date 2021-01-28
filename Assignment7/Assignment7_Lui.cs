using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    class Invoice
    {
        //Create an Invoice class with three fields:  ID number, balance due and day due.
        private int id = 0;
        private double balanceDue = 0;
        private int dayDue = 0;
        //constant range
        private const int LowDay = 1;
        private const int HighDay = 31;
        //Create read-only implemented accessors for ID number, balance due, and day due.
        public int Id 
        { 
            get 
            { 
                return this.id; 
            } 
        }
        public double BalanceDue
        {
            get
            {
                return this.balanceDue;
            }
        }
        public int DayDue {
            get
            {
                return this.dayDue;
            } 
        }
        //The constructor for Invoice will accept three arguments for the three fields noted above.
        public Invoice(int id, double balanceDue, int dayDue)
        {
            //In the Invoice class constructor check that the id number falls within a constant range where the low id number is 100 
            //and the high id number is 999.  Check that the day falls within a constant range where the low day number is 1 and the high day is 31.
            //If the ID number or the day fall outside of the specified ranges, throw an argument exception.  
            //Assign the values passed in to the corresponding class variables.
            if (id <= 999 && id >= 100)
            {
                this.id = id;
            }
            else
            {
                throw new ArgumentException(String.Format("{0} is not within the id range", id));
            }
            if (dayDue >= LowDay && dayDue <= HighDay)
            {
                this.dayDue = dayDue;
            }
            else
            {
                throw new ArgumentException(String.Format("{0} is not within the day range", id));
            }
            this.balanceDue = balanceDue;
          
            
        }
    }
    class Assignment7_Lui
    {
        static void Main(string[] args)
        {
            //instantiate an array of five (5) Invoice objects.
            Invoice[] invoices = new Invoice[5];
            //Create a constant integer and set the default constant to 999.
            const int ConstantInteger = 999;
            for (int i = 0; i < invoices.Length; i++)
            {
                //Prompt the user for inputs for ID number, balance, and day. 
                Invoice invoice;
                Console.Write("Enter invoice number >> ");
                string id = Console.ReadLine();
                Console.Write("Enter balance >> ");
                string balanceDue = Console.ReadLine();
                Console.Write("Enter due day >> ");
                string dueDay = Console.ReadLine();
                //Trythe assignment of each instantiation object, passing the three entered values to the object array element and catchan argument exception, 
                //assigning an instantiation using the constant default value, 0, and 1for the ID number, balance, and day respectively.
                try
                {
                    invoice = new Invoice(int.Parse(id), double.Parse(balanceDue), int.Parse(dueDay));
                }
                catch
                {
                    invoice = new Invoice(ConstantInteger, 0, 1);
                }
                invoices[i] = invoice;
            }
            Console.WriteLine();
            Console.WriteLine("Entered invoices");
            //Display all the entered and possibly corrected records as shown below.
            foreach (var item in invoices)
            {
                Console.WriteLine("#{0} {1} day {2}", item.Id, String.Format("{0:C}", item.BalanceDue), item.DayDue);
            }

        }
    }
}

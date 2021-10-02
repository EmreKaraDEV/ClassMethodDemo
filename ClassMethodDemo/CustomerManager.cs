using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void customerAdd(Customer customer) {
            setFontColor(ConsoleColor.Cyan);
            Console.WriteLine("New customer added. New Customer ID: " + customer.getId() + " First Name: " + customer.getFirstName() + " Last Name: " + customer.getLastName() + " Age: " + customer.getAge());
        }
        int listLayoutDecision = 0;
        public void getCustomerList(Customer[] customers) {
            setFontColor(ConsoleColor.Yellow);
            Console.WriteLine("\nCustomer List Options");
            Console.WriteLine("Select list layout: Horizontal = 0, Vertical = 1. (Horizontal layout is used by default.)");
            Console.Write("\nSelect list layout: ");
            try { 
                listLayoutDecision = Convert.ToSByte(Console.ReadLine()); 
            } catch(Exception e) {
                setFontColor(ConsoleColor.DarkRed); Console.WriteLine("ERROR: "+e.Message);
            }
            setFontColor(ConsoleColor.Green);
            Console.WriteLine("Customer LIST---------------------------------------------------------");
            foreach (Customer customer in customers)
            {
                switch (listLayoutDecision)
                {
                    case 0:
                        Console.WriteLine("\nCustomer ID: " + customer.getId() + " First Name: " + customer.getFirstName() + " Last Name: " + customer.getLastName() + " Age: " + customer.getAge());
                        break;
                    case 1:
                        Console.WriteLine("\nCustomer ID: " + customer.getId() + "\nFirst Name: " + customer.getFirstName() + "\nLast Name: " + customer.getLastName() + "\nAge: " + customer.getAge());
                        break;
                    default:
                        Console.WriteLine("\nCustomer ID: " + customer.getId() + " First Name: " + customer.getFirstName() + " Last Name: " + customer.getLastName() + " Age: " + customer.getAge());
                        break;
                }
            }
            Console.WriteLine("\nCustomer LIST END-----------------------------------------------------\n");
        }

        public void customerDelete(Customer customer) {
            setFontColor(ConsoleColor.Red);
            Console.WriteLine("The customer with ID "+customer.getId()+" has been deleted.");
            setFontColor(ConsoleColor.White);
        }

        void setFontColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }
    }
}

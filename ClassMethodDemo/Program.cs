using System;

namespace ClassMethodDemo
{
    class Program
    {   //Emre Kara Github: https://github.com/EmreKaraDEV Web: https://emreki.art.blog/
        static void Main(string[] args)
        {
            int lastID = 0;
            CustomerManager customerManager = new CustomerManager();
            Customer c1 = new Customer(++lastID);
            c1.setFirstName("Jack");
            c1.setLastName("White");
            c1.setAge(24);
            customerManager.customerAdd(c1);

            Customer c2 = new Customer(++lastID);
            c2.setFirstName("Alice");
            c2.setLastName("Brown");
            c2.setAge(28);
            customerManager.customerAdd(c2);

            Customer c3 = new Customer(++lastID);
            c3.setFirstName("Emre");
            c3.setLastName("Kara");
            c3.setAge(20);
            customerManager.customerAdd(c3);

            Customer c4 = new Customer(++lastID);
            c4.setFirstName("Richard");
            c4.setLastName("Hope");
            c4.setAge(32);
            customerManager.customerAdd(c4);

            Customer[] customers = new Customer[] { c1 , c2 , c3 , c4 };

            customerManager.getCustomerList(customers);
            customerManager.customerDelete(c1);
            customerManager.customerDelete(c2);
            customerManager.customerDelete(c3);
            customerManager.customerDelete(c4);
        }
    }
}

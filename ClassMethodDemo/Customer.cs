using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class Customer
    {
        public Customer(int id)
        {
            this.Id = id;
        }

        private int Id { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private int Age { get; set; }

        public int getId()
        {
            return this.Id;
        }

        //setId, The ID is determined automatically.

        public String getFirstName()
        {
            return this.FirstName;
        }

        public void setFirstName(String firstName)
        {
            this.FirstName = firstName;
        }
        
        public String getLastName()
        {
            return this.LastName;
        }

        public void setLastName(String lastName)
        {
            this.LastName = lastName;
        }

        public int getAge()
        {
            return this.Age;
        }

        public void setAge(int age)
        {
            this.Age = age;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerMaintenance
{
    public class Customer
    {
        //private string firstName;
        //private string lastName;
        //private string email;

        // constructor- default
        public Customer() 
        { 

        }

        // expression-bodied constructor that uses a tuple
        public Customer(string firstname, string lastname, string email) =>
            (this.FirstName, this.LastName, this.Email) = (firstname, lastname, email);

        // auto-implemented properties
        public string FirstName 
        { 
            get; 
            set; 
        }
        public string LastName 
        {
            get;
            set;
        }
        public string Email 
        { 
            get;
            set; 
        }
        
        // expression-bodied method
        public string GetDisplayText() => FirstName + " " + LastName + " , " + Email;

        

        



            


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeInsuranceDB.Business_Logic_Layer
{
    class Customers
    {
        //Set-Get properties

        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string Gender { get; set; }
        public int PostCode { get; set; }
        public int CategoryID { get; set; }
        public DateTime BirthDate { get; set; }



        //Declaring Default Constructor
        public Customers() { }

        //Parameterised Constructor
        public Customers(int customerID, string firstname,
                         string lastname, string address, string suburb,
                         string state, string gender, int postcode, int categoryID,
                          DateTime birthdate)
                    
        {
            CustomerID = customerID;
            FirstName = firstname;
            LastName = lastname;
            Address = address;
            Suburb = suburb;
            State = state;
            Gender = gender;
            PostCode = postcode;
            CategoryID = categoryID;
            BirthDate = birthdate;
        }

    }
}

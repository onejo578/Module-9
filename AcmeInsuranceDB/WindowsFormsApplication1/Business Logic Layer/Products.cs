using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeInsuranceDB.Business_Logic_Layer
{
    class Products
    {
        //Set-Get properties

        public int ProductID { get; set;}
        public string ProductName { get; set; }
        public int YearlyPremium { get; set; }
        public string ProductTypeID { get; set; }

        //Declaring Default Constructor
        public Products() { }

        //Parameterised Constructor
        public Products(string productname, int yearlypremium, string producttypeID)

        {
            ProductName = productname;
            YearlyPremium = yearlypremium;
            ProductTypeID = producttypeID;
        }

    }
}
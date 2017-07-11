using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeInsuranceDB.Business_Logic_Layer
{
    class Product_Types_Class
    {
        //Set-Get properties

        public int ProductTypeID { get; set; }
        public string ProductType { get; set; }
        
        //Declaring Default Constructor
        public Product_Types_Class() { }

        //Parameterised Constructor
        public Product_Types_Class(int producttypeID, string producttype)

        {
            ProductTypeID = producttypeID;
            ProductType = producttype;
        }

    }
}

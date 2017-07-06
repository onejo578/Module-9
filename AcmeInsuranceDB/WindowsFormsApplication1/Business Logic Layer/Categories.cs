using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeInsuranceDB.Business_Logic_Layer
{
    class Categories
    {
        public int CategoryID { get; set; }
        public string Category { get; set; }

        //Declaring Default Constructor
        public Categories() { }

        //Parameterised Constructor
        public Categories(int categoryid, string category)
        {
            CategoryID = categoryid;
            Category = category;
        }
    }
}

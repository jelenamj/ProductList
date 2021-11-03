using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductList
{
    public static class Validation
    {
        public static int PriceValidation(string s)
        {
            double price;
            bool isDouble = Double.TryParse(s, out price);
            if (String.IsNullOrEmpty(s) || !isDouble)
            {
                return 0;
            }
            else if (price <= 0)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }
}
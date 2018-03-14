using System;
using System.Collections.Generic;
using System.Text;

namespace HiveKeeper.Models
{
    public class Address
    {
        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public string Country { get; set; }

        public string FullAddress
        {
            get
            {
                return string.Format("{0} {1} {2} {3} {4} {5}", Address1, Address2, City, State, Zip, Country);
            }           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HiveKeeper.Models
{
    public class Apiary
    {
        public Apiary()
        {
            Address = new Address();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public Address Address { get; set; }

        public string HostName { get; set; }

        public string HostPhone { get; set; }

        public string HostEmail { get; set; }

        public string GateCode { get; set; }
    }
}

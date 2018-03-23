using System;
using System.Collections.Generic;
using System.Text;

namespace HiveKeeper.Models
{
    public class Hive
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public HiveType HiveType { get; set; }
    }
}

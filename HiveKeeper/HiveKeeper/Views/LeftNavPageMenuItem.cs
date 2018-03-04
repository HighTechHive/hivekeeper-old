using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiveKeeper.Views
{

    public class LeftNavPageMenuItem
    {
        public LeftNavPageMenuItem()
        {
            TargetType = typeof(LeftNavPageDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}
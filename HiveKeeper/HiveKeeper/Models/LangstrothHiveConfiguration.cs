using System;
using System.Collections.Generic;
using System.Text;

namespace HiveKeeper.Models
{
    public class LangstrothHiveConfiguration
    {
        // number of brood boxes
        public int BroodBoxes { get; set; }

        // number of honey supers
        public int HoneySupers { get; set; }

        // number of frames per box
        public int FrameCount { get; set; }
    }
}

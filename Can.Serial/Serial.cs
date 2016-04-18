using Can.Common.Interfaces;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Can.Serial
{
    public class Serial : ISerial
    {
        public Serial()
        {
            
        }


        public void Go()
        {
            System.Diagnostics.Debug.WriteLine("GO");
        }
    }
}

using Can.Common.Base;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Can.Serial.UI.ViewModel
{
    public class SerialOutputViewModel: BaseViewModel
    {
        public SerialOutputViewModel() { }


        private void Go()
        {
            Serial serial = new Serial();
            serial.Go();
        }


        public ICommand btn_Go { get { return new DelegateCommand(Go); } }
    }
}

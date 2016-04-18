using Can.Common.Interfaces;
using Can.Serial.UI.View;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Can.Serial.ModuleDef
{
    public class Main : IModule
    {
        public void Initialize()
        {
            IUnityContainer container = ServiceLocator.Current.GetInstance<IUnityContainer>();
            container.RegisterType<ISerial, Serial>();

            IRegionManager region = ServiceLocator.Current.GetInstance<IRegionManager>();
            region.RegisterViewWithRegion("SerialOutPutUIRegion", typeof(SerialOutputView));
        }
    }
}

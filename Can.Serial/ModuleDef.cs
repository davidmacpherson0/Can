using Can.Common.Interfaces;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Can.Serial
{
    public class ModuleDef : IModule
    {
        public void Initialize()
        {
            System.Diagnostics.Debug.WriteLine("########## Loaded: Can.Serial" );
            IUnityContainer container = ServiceLocator.Current.GetInstance<IUnityContainer>();
            container.RegisterType<ISerial, Serial>();

        }
    }
}

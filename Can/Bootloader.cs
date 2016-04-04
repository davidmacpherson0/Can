using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Prism.Unity;
using Microsoft.Practices.ServiceLocation;
using Can.UI;
using Prism.Modularity;

namespace Can
{
    public class Bootloader : UnityBootstrapper
    {

        protected override DependencyObject CreateShell()
        {
            return ServiceLocator.Current.GetInstance<MainShellView>();

        }

        protected override void InitializeShell()
        {
            base.InitializeShell();
            Application.Current.MainWindow = (Window)Shell;
            Application.Current.MainWindow.Show();

        }


        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new ConfigurationModuleCatalog();
        }

        public override void Run(bool runWithDefaultConfiguration)
        {
            base.Run(runWithDefaultConfiguration);

        }
    }
}

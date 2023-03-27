using Padutronics.DependencyInjection;
using Padutronics.Wpf.ViewModels.Windows;

namespace Padutronics.Wpf.DependencyInjection.Modules;

internal sealed class WpfContainerModule : IContainerModule
{
    public void Load(IContainerBuilder containerBuilder)
    {
        containerBuilder.For<IWindowFinder>().Use<WindowFinder>().SingleInstance();

        containerBuilder.For<IWindowState>().Use<WindowState>().InstancePerDependency();
        containerBuilder.For<IWindowStateFactory>().UseFactory();
    }
}
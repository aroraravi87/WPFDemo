using System.Windows;
using WPFAppDemo_Unity.UnityBase;

namespace WpfAppDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            CustomUnityContainerExtension.InitializeContainer();
        }
    }
}

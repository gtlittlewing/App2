using Microsoft.UI.Xaml;
using WinUIEx;

namespace App2
{
    public partial class App : Application
    {
        public App()
        {
            this.InitializeComponent();
        }

        protected override void OnLaunched(LaunchActivatedEventArgs args)
        {
            m_window = new MainWindow();
            m_window.Activate();
        }

        private WindowEx m_window;
    }
}

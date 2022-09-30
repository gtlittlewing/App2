using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using WinUIEx;

namespace App2
{
    public sealed partial class MainWindow : WindowEx
    {
        private AcrylicSystemBackdrop AcrylicBackdrop { get; init; } = new AcrylicSystemBackdrop();
        private MicaSystemBackdrop MicaBackdrop { get; init; } = new MicaSystemBackdrop();

        public MainWindow()
        {
            this.InitializeComponent();
            if (AppWindowTitleBar.IsCustomizationSupported())
            {
                this.ExtendsContentIntoTitleBar = true;
                this.SetTitleBar(this.CustomAppTitleBar);
            }
            else
            {
                CustomAppTitleBar.Visibility = Visibility.Collapsed;
            }
        }

        private void Backdrop_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.Backdrop = ((ComboBox)sender).SelectedIndex switch
            {
                0 => AcrylicBackdrop,
                1 => MicaBackdrop,
                _ => null,
            };
        }

        private void Theme_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LayoutRoot.RequestedTheme = ((ComboBox)sender).SelectedIndex switch
            {
                1 => ElementTheme.Dark,
                2 => ElementTheme.Light,
                _ => ElementTheme.Default,
            };
        }
    }
}

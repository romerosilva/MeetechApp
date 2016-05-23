using System;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MeetechApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            var titleBar = ApplicationView.GetForCurrentView().TitleBar;
            var bgColor = new Color
            {
                R = 97,
                G = 26,
                B = 119
            };
            titleBar.BackgroundColor = bgColor;
            titleBar.ForegroundColor = Colors.White;
            titleBar.ButtonBackgroundColor = bgColor;
            titleBar.ButtonForegroundColor = Colors.White;
            ContentFrame.Navigate(typeof(HomePage));
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            Menu.IsPaneOpen = !Menu.IsPaneOpen;
        }

        private void HomePageButton_OnClick(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(HomePage));
        }

        private void GalleryPageButton_OnClick(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(GalleryPage));
        }

        private void WebViewPageButton_OnClick(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(WebViewPage));
        }

        private void ContactPageButton_OnClick(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(ContactPage));
        }
    }
}

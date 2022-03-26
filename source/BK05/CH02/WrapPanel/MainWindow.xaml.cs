using System.Windows;
using System.Windows.Controls;

namespace WrapPanel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cmdWidth_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button.Content.ToString() == "Set Wide")
            {
                pnlContainer.Width = 350;
                button.Content = "Set Narrow";
                Title = "Wrap Panel - Wide";
            }
            else
            {
                pnlContainer.Width = 80;
                button.Content = "Set Wide";
                Title = "Wrap Panel - Narrow";
            }
        }
    }
}

using System.Windows;
using System.Windows.Controls;

namespace StackPanel
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
        private void cmdOrientation_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button.Content.ToString() == "Set Vertical")
            {
                pnlStack.Orientation = Orientation.Vertical;
                pnlStack.MinHeight = 0;
                button.Content = "Set Horizontal";
                Title = "Stack Panel - Vertical";
            }
            else
            {
                pnlStack.Orientation = Orientation.Horizontal;
                pnlStack.MinHeight = 50;
                button.Content = "Set Vertical";
                Title = "Stack Panel - Horizontal";
            }
        }
    }
}

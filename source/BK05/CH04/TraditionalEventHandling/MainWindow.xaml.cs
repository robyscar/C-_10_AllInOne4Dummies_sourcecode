using System.Windows;

namespace TraditionalEventHandling
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

        private void ClickMe_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Message.Text);
        }
    }
}

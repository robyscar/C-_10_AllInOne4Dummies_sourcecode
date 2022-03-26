using System.Windows;
using System.Windows.Input;

namespace RoutedCommands
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

        private void CommandBinding_CanExecute(object sender, 
            CanExecuteRoutedEventArgs e)
        {
            if ((NameStr != null) && (NameStr.Text.Length > 0))
                e.CanExecute = true;
            else
                e.CanExecute = false;
        }

        private void CommandBinding_Executed(object sender, 
            ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Hello " + NameStr.Text);
        }
    }

    public static class Command
    {
        public static readonly RoutedUICommand cmdSayHello =
            new RoutedUICommand("Say Hello Menu", "DoSayHello", 
                typeof(MainWindow));
    }
}

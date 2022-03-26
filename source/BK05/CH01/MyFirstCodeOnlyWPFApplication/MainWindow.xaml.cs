using System.Windows;
using System.Windows.Controls;

namespace MyFirstCodeOnlyWPFApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //define grid column and row
            this.gridLayout.ColumnDefinitions.Add(new ColumnDefinition());
            this.gridLayout.RowDefinitions.Add(new RowDefinition());

            //obtain label content from the application resource, Purpose
            string purpose = this.TryFindResource("Purpose") as string;
            Label lblPurpose = new Label();
            lblPurpose.Content = purpose;
            lblPurpose.FontSize = 25;

            //add label to the grid
            this.gridLayout.Children.Add(lblPurpose);

            //assign attached property values
            Grid.SetColumn(lblPurpose, 0);
            Grid.SetRow(lblPurpose, 0);
        }
    }
}

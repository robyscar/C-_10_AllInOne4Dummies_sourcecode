using System.Windows;

namespace BindingSample1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GenerateData();
        }

        private void GenerateData()
        {
            Car car1 = new Car() { Make = "Athlon", Model = "XYZ" };
            this.DataContext = car1;
        }
    }
}

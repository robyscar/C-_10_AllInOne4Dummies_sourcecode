using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

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

            Binding makeBinding = new Binding("Make");
            makeBinding.Mode = BindingMode.OneTime;
            BindingOperations.SetBinding(lblCarMake,
                       Label.ContentProperty, makeBinding);

            Binding modelBinding = new Binding("Model");
            modelBinding.Mode = BindingMode.OneTime;
            BindingOperations.SetBinding(lblCarModel,
                             Label.ContentProperty, modelBinding);

            this.DataContext = car1;
        }
    }
}

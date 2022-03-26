using System.Windows;

namespace MyFirstCodeOnlyWPFApplication
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            //create and add the Purpose application resource
            string purpose = "Hello WPF World, in C#";
            this.Resources.Add("Purpose", purpose);

            base.OnStartup(e);
        }
    }
}

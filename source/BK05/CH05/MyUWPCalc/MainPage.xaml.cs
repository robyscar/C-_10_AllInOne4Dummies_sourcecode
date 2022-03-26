using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MyUWPCalc
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            // Set the input up to allow easy entry.
            Input.SelectAll();
            Input.Focus(FocusState.Keyboard);

        }

        private void DoMath(object sender, RoutedEventArgs e)
        {
            // Obtain the current values.
            Double NewValue = 0;
            Double.TryParse(Input.Text, out NewValue);
            Double ExistingValue = 0;
            Double.TryParse(Result.Text, out ExistingValue);

            // Perform a task based on which button is pressed.
            switch (((Button)sender).Name)
            {
                case "Add":
                    ExistingValue += NewValue;
                    break;
                case "Sub":
                    ExistingValue -= NewValue;
                    break;
                case "Mul":
                    ExistingValue *= NewValue;
                    break;
                case "Div":
                    ExistingValue /= NewValue;
                    break;
                case "Clr":
                    ExistingValue = 0;
                    break;
            }

            // Output the result.
            Result.Text = ExistingValue.ToString();

            // Set the input up for the next entry.
            Input.Text = "0";
            Input.SelectAll();
            Input.Focus(FocusState.Keyboard);
        }
    }
}

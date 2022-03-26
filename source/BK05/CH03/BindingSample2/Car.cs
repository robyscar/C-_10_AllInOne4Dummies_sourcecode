using System.ComponentModel;

namespace BindingSample2
{
    internal class Car : INotifyPropertyChanged
    {
        private string _make;

        public string Make
        {
            get { return _make; }
            set
            {
                if (_make != value)
                {
                    _make = value;
                    NotifyPropertyChanged("Make");
                }
            }
        }

        private string _model;

        public string Model
        {
            get { return _model; }
            set
            {
                if (_model != value)
                {
                    _model = value;
                    NotifyPropertyChanged("Model");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                this.PropertyChanged(this,
                       new PropertyChangedEventArgs(propertyName));
            }
        }

        public Car() { }
    }
}

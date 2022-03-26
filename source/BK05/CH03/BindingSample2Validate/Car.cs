using System;
using System.ComponentModel;

namespace BindingSample2
{
    internal class Car : INotifyPropertyChanged, IDataErrorInfo
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

        public string Error => null;

        public string this[string columnName]
        {
            get
            {
                string retvalue = null;
                if (columnName == "Make")
                {
                    if (String.IsNullOrEmpty(this._make)
                               || this._make.Length < 3)
                    {
                        retvalue = "Car Make must be at least 3 " +
                                       "characters in length";
                    }
                }

                if (columnName == "Model")
                {
                    if (String.IsNullOrEmpty(this._model)
                                || this._model.Length < 3)
                    {
                        retvalue = "Car Model must be at least 3 " +
                                           "characters in length";
                    }
                }

                return retvalue;
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

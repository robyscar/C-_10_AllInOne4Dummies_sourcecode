using System;

namespace Parts
{
    public partial class DoStuff
    {
        public void DoAdd(int value)
        {
            if (value > 0)
                TheValue += value;
            else
                throw new ArgumentOutOfRangeException("value",
                    "Input must be greater than 0!");
        }

        public void DoSubtract(int value)
        {
            if (value > 0)
                if (value <= TheValue)
                    TheValue -= value;
                else
                    TheValue = 0;
            else
                throw new ArgumentOutOfRangeException("value",
                    "Input must be greater than 0!");
        }

        public partial void DoDivide(int value)
        {
            if (value > 0)
                TheValue = TheValue / value;
            else
                throw new ArgumentOutOfRangeException("value",
                    "Input must be greater than 0!");
        }
    }
}
namespace MathRoutines  // Broken into two segments -- see below.
{
    class Sort
    {
        public void SomeMethod() 
        {
            System.Console.WriteLine("In SomeMethod");
        }
    }
}

namespace Paint
{
    public class PaintColor
    {
        public PaintColor(int nRed, int nGreen, int nBlue) { }
        public void Paint() 
        {
            System.Console.WriteLine("Painting");
        }
        public static void StaticPaint() 
        {
            System.Console.WriteLine("Static Painting");
        }
    }
}

namespace MathRoutines  // Another piece of this namespace
{
    public class Test
    {
        static public void Main(string[] args)
        {
            // Create an object of type Sort from the same namespace
            // we’re in and invoke a method.
            Sort obj = new Sort();
            obj.SomeMethod();

            // Create an object in another namespace -- notice that the
            // namespace name must be included explicitly in every
            // class reference.
            Paint.PaintColor black = new Paint.PaintColor(0, 0, 0);
            black.Paint();
            Paint.PaintColor.StaticPaint();
        }
    }
}

namespace MyCSharpPractice
{
    // Program Entry Point
    public static class Program
    {
        [STAThread] // Required for MessageBox
        public static void Main()
        {
            MyDemoClass demo1 = new MyDemoClass();
            demo1.ShowMessage();

            MyDemoClass demo2 = new MyDemoClass("This is a custom message!", 42);
            demo2.ShowMessage();
        }
    }
}
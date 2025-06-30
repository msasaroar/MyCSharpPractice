using System;
using System.Windows.Forms; // Needed for MessageBox

public class MyDemoClass
{
    // Field
    private string message;

    // Property
    public int Number { get; set; }

    // Default Constructor
    public MyDemoClass()
    {
        message = "Hello from MyDemoClass!";
        Number = 0;
    }

    // Parameterized Constructor
    public MyDemoClass(string msg, int num)
    {
        message = msg;
        Number = num;
    }

    // Method
    public void ShowMessage()
    {
        MessageBox.Show($"Message: {message}\nNumber: {Number}");
    }
}
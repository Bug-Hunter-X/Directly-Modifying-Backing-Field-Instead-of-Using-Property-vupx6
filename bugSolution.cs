public class ExampleClass
{
    private int _myField;

    public int MyProperty
    {
        get { return _myField; }
        set { _myField = value; }
    }

    public void MyMethod()
    {
        // Correct way to access and modify the field: use the property
        MyProperty = 10; 
        Console.WriteLine(MyProperty); // The property will now correctly reflect the change
    }
} 
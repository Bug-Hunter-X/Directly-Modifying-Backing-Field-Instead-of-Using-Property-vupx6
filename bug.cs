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
        // Accessing the field directly instead of using the property.
        _myField = 10; // This is the problematic line
        Console.WriteLine(MyProperty); // The property will not reflect the change
    }
}
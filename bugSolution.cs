public class ExampleClass
{
    public int MyProperty { get; set; }

    // Constructor to initialize the property
    public ExampleClass()
    {
        MyProperty = 0; // Initialize with a default value
    }

    public void MyMethod()
    {
        // Now MyProperty is guaranteed to have a value
        int value = MyProperty * 2; 
    }
}
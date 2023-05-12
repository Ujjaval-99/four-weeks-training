public class Stack<T>
{
    private System.Collections.Generic.List<T> items;
    public Stack()
    {
        items = new System.Collections.Generic.List<T>();
    }
    public void Push(T item)
    {
        items.Add(item);
    }
    public T Pop()
    {
        if (IsEmpty())
        {
            throw new System.InvalidOperationException("Stack is empty.");
        }
        T item = items[items.Count - 1];
        items.RemoveAt(items.Count - 1);
        return item;
    }
    public bool IsEmpty()
    {
        return items.Count == 0;
    }
}
public class Program
{
    public static void Main()
    {
        // Test the Stack<T> class with integers
        Stack<int> intStack = new Stack<int>();
        intStack.Push(10);
        intStack.Push(20);
        intStack.Push(30);
        Console.WriteLine("Integers in the stack:");
        while (!intStack.IsEmpty())
        {
            int item = intStack.Pop();
            Console.WriteLine(item);
        }
        // Test the Stack<T> class with strings
        Stack<string> stringStack = new Stack<string>();
        stringStack.Push("Hello");
        stringStack.Push("World");
        Console.WriteLine("Strings in the stack:");
        while (!stringStack.IsEmpty())
        {
            string item = stringStack.Pop();
            Console.WriteLine(item);
        }
        // Test the Stack<T> class with custom objects
        Stack<Person> personStack = new Stack<Person>();
        personStack.Push(new Person("John", 25));
        personStack.Push(new Person("Alice", 30));
        Console.WriteLine("Persons in the stack:");
        while (!personStack.IsEmpty())
        {
            Person person = personStack.Pop();
            Console.WriteLine(person.Name + ", Age: " + person.Age);
        }
    }
}
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

public sealed class AipEmployee // AIP(Automatically Implemented Properties) - автосвойства крч
{
    public string Name { get; set; }
    private int m_Age;
    public int Age
    {
        get { return m_Age; }

        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("value", value.ToString(), "The value must be greater or equal to 0");
                m_Age = value;
            }
        }
    }
}

// Ну, согласно Рихтеру, автосвойства - полная дичь, которой пользуются зря, и вообще удалить их надо из мира
// методы лучше, там возможножностей больше и т.д., ну мне впринципе все равно, мне и так, и по другому писать приятно
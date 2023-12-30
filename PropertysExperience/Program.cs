internal class Program
{
    private static void Main(string[] args)
    {

        //AipEmployee employee = new AipEmployee() { Age = 1, Name = "Sebastian" };
        //String a = new AipEmployee() { Age = 1, Name = "Sebastian" }.ToString().ToUpper(); // Можно еще кст без скобок, просто ... = new AipEmployee {....}

        //Console.WriteLine(a);

        Classroom.M();
        
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


public sealed class Classroom
{
    private List<String> m_students = new List<string>();
    public List<String> Students { get { return m_students; } }

    public Classroom() { }

    public static void M()
    {
        Classroom classroom = new Classroom
        {
            Students = { "Jeff", "Kristin", "Anton", "Grant"}
        };

        // тоже самое что

        Classroom classroom1 = new Classroom();
        classroom1.Students.Add("Jeff");
        classroom1.Students.Add("Kristin");
        classroom1.Students.Add("Anton");
        classroom1.Students.Add("Grant");

        foreach (var student in classroom.Students)
        {
            Console.WriteLine(student);
        }


        // еще вот так можно, если в коллекции несколько аргументов
        var table = new Dictionary<String, Int32>
        {
            {"Jeffery", 1 }, {"Mike", 3}, {"Timur", 3}
        };     
        // ну и конечно схема с Add тут тоже сработает, как в примере выше
    }
}
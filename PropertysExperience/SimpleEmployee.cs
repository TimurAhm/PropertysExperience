public sealed class SimpleEmployee
{
    private string? m_Name;
    private int m_Age;

    public string get_Name()
    {
        return m_Name;
    }

    public void set_Name(string name)
    {
        m_Name = name;
    }

    public int get_Age()
    {
        return m_Age;
    }

    public void set_Age(int age)
    {
        if (age < 0)
            throw new ArgumentOutOfRangeException("age", age.ToString(), "The age must be greater or equal to 0");
        m_Age = age;
    }
}
namespace _12._06Task;

internal class Student
{
    private int _id;
    public int Id { get;}
    public string FullName { get; set; }
    public int Point { get; set; }

    public Student(string fullName, int point)
    {
        Id = ++_id;
        FullName = fullName;
        Point = point;
    }

    public void StudentInfo()
    {
        Console.WriteLine($"{Id}-{FullName}-{Point}");
    }
}

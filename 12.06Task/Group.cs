namespace _12._06Task;

internal class Group
{
    private string _groupNo;
    private int _studentLimit;
    Student[] students;
    public string GroupNo
    {
        get => _groupNo;
        set
        {
            while (!CheckGroupNo(value))
            {
                Console.WriteLine("Qrup nomresini duzgun daxil edin!!!");
                value = Console.ReadLine();
            }
            _groupNo = value;
        }
    }
    public int StudentLimit
    {
        get => _studentLimit;
        set
        {
            if (value >= 5 && value <= 18)
            {
                _studentLimit = value;
            }
            while (!(value >= 5 && value <= 18))
            {
            LimitConvert:
                Console.WriteLine("Telebe limiti 5 ve 18 arasi olmalidir ,zehmet olmasa duzgun daxil edin");
                bool limitConvert = int.TryParse(Console.ReadLine(), out int stuLimit);
                if (limitConvert)
                {
                    value = stuLimit;
                }
                else
                {
                    goto LimitConvert;
                }
            }
        }
    }

    public Group(string groupNo, int studentLimit)
    {
        GroupNo = groupNo;
        StudentLimit = studentLimit;
        students = new Student[0];
    }



    public bool CheckGroupNo(string groupNo)
    {
        if (groupNo.Length == 5)
        {
            if (char.IsUpper(groupNo[0]) && char.IsUpper(groupNo[1]) && char.IsDigit(groupNo[2]) && char.IsDigit(groupNo[3]) && char.IsDigit(groupNo[3]))
                return true;
            return false;
        }
        return false;
    }

    public void AddStudent(Student student)
    {
        if (students.Length < StudentLimit)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
            Console.WriteLine("Elave olundu");
        }
        else
        {
            Console.WriteLine("eelave olunmadi, qrupda yer yoxdur");
        }
    }


    public Student GetStudent(int id)
    {
        foreach (Student student in students)
        {
            if (student.Id == id)
            {
                return student;
            }
        }
        return null;
    }
    public void GetAllStudents()
    {
        foreach (Student student in students)
        {
            student.StudentInfo();
        }

    }



}

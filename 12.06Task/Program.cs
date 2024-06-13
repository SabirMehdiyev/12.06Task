namespace _12._06Task;

internal class Program
{
    static void Main(string[] args)
    {
        //int num = 5;
        //Console.WriteLine(num.IsEven());
        //Console.WriteLine(num.IsOdd());
        //string text = "Sabir";
        //Console.WriteLine(text.IsContainsDigit());

        Console.WriteLine("Fullname daxil edin:");
        string fullName = Console.ReadLine();
        Console.WriteLine("Email daxil ediin");
        string email = Console.ReadLine();
        Console.WriteLine("Sifreni daxil edin");
        string password = Console.ReadLine();
        User user = new User(email, fullName, password);

        bool isContinue = true;
        while (isContinue)
        {
            Console.WriteLine(
                "1.Show Info" +
                "2.Create new group");
            string command = Console.ReadLine();

            switch (command)
            {
                case "1":
                    user.ShowInfo();
                    break;
                case "2":
                    Console.WriteLine("Qrup nomresi daxil edin");
                    string groupNo = Console.ReadLine();
                convert:
                    Console.WriteLine("Telebe sayi ucun limit daxil edin");
                //int studentLimit = Convert.ToInt32(Console.ReadLine());
                    bool studentLimitConvert = int.TryParse(Console.ReadLine(), out int studentLimit);
                    Group group;
                    if (studentLimitConvert)
                    {
                        group = new(groupNo, studentLimit);
                    }
                    else
                    {
                        goto convert;
                    }
                    while (true)
                    {
                        Console.WriteLine("1.Show all students" +
                        "2.Get student by id" +
                        "3.Add srudent" +
                        "0.Quit");
                        string choice = Console.ReadLine();
                        switch (choice)
                        {
                            case "1":
                                group.GetAllStudents();
                                break;
                            case "2":
                            Idconvert:
                                Console.WriteLine("Id daxil edin");
                                bool IdConvert = int.TryParse(Console.ReadLine(), out int id);
                                if (IdConvert)
                                {
                                    group.GetStudent(id).StudentInfo();
                                }
                                else
                                {
                                    goto Idconvert;
                                }
                                break;
                            case "3":
                                Console.WriteLine("Ad daxil edin:");
                                string name = Console.ReadLine();
                            Pointconvert:
                                Console.WriteLine("Point daxil edin");
                                bool PointConvert = int.TryParse(Console.ReadLine(), out int point);
                                if (PointConvert)
                                {
                                    Student student = new(name, point);
                                    group.AddStudent(student);
                                }
                                else
                                {
                                    goto Pointconvert;
                                }
                                break;
                            case "0":
                                isContinue = false;
                                return;
                            default:
                                break;
                        }
                    }
                default:
                    break;
            }

        }
    }
}

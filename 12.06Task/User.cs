namespace _12._06Task;

internal class User : Account
{
    private string _password;
    private int _id;
    public int Id { get; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Password 
    {
        get => _password;
        set
        {
            while (!PasswordChecker(value))
            {
                Console.WriteLine("Sifreni duzgun daxil edin:");
                value = Console.ReadLine();
            }
            _password = value;
        }
    }

    public User(string email , string fullName, string password)
    {
        Id = ++_id;
        Email = email;
        FullName = fullName;
        Password = password;

    }


    public override bool PasswordChecker(string password)
    {
        bool hasUpper = false;
        bool hasLower = false;
        bool hasDigit = false;


        if (password.Length>=8)
        {
            foreach (char c in password) 
            {
                if (char.IsUpper(c))
                {
                    hasUpper = true;
                }
                else if (char.IsLower(c))
                {
                    hasLower = true;
                }
                else if (char.IsDigit(c))
                {
                    hasDigit = true;
                }


                if (hasUpper && hasLower && hasDigit)
                {
                    return true;
                }
            }
        }
        return false;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"{Id}-{FullName}-{Email}");
    }
}

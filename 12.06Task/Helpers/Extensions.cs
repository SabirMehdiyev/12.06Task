namespace _12._06Task.Helpers;

public static class Extensions
{
    public static bool IsOdd(this int num)
    {
        return num % 2 != 0;
    }

    public static bool IsEven(this int num)
    {
        return num % 2 == 0;
    }

    public static bool IsContainsDigit(this string text)
    {
        foreach (var item in text)
        {
            if (char.IsDigit(item))
            {
                return true;
            }
        } 
        return false;
    }

}

namespace Utils;

public static class Extensions
{
    public static void AnimateText(this string text, int delay = 50)
    {
        foreach (var c in text)
        {
            Console.Write(c);
            Thread.Sleep(delay);
        }
        Console.WriteLine();
    }

    public static bool IsEven(this int value)
    {
        return value % 2 == 0;
    }
}

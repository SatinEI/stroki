
string[] names = { "James", "Carl", "Alex", "Jacob", "Stacy" };
int n = 564321;
int[] num = { 9, 1, 3, 8, 1, 2, 6, 3, 9, 0};
string phrase = "Hellooooooooooooooooooo";
string CreatePhoneNumber(int[] num) //№1
{
    if (num.Length != 10) { Console.WriteLine("Номер телефона должен содержать 10 цифр"); return null; };
    return $"+8 ({num[0]}{num[1]}{num[2]}){num[3]}{num[4]}{num[5]}-{num[6]}{num[7]}{num[8]}{num[9]}";
}
Console.WriteLine(CreatePhoneNumber(num));
static string TrimString(string phrase, int len) //№2
{
    if (len <= 0) return "...";
    if (phrase.Length <= len) return phrase;

    if (len <= 3)
    {
        return phrase.Substring(0, len) + "...";
    }

    return phrase.Substring(0, len - 3) + "...";
}
Console.WriteLine(TrimString(phrase, 14));
static long SquareDigits(long n) //№3
{
    string result = string.Empty;

    foreach (char digit in n.ToString())
    {
        int num = int.Parse(digit.ToString());
        result += (num * num).ToString();
    }

    return long.Parse(result);
}
Console.WriteLine(SquareDigits(n));
static string Likes(string[] names) //№4
{
    switch (names.Length)
    {
        case 0:
            return "no one likes this";
        case 1:
            return $"{names[0]} likes this";
        case 2:
            return $"{names[0]} and {names[1]} like this";
        case 3:
            return $"{names[0]}, {names[1]} and {names[2]} like this";
        default:
            return $"{names[0]}, {names[1]} and {names.Length - 2} others like this";
    }
}
Console.WriteLine(Likes(names));
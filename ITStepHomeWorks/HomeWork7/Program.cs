using System.Globalization;

Console.Write("enter your text: ");
string text = Console.ReadLine() ?? "";
Console.Write("\nResult: ");
Console.WriteLine(UppercaseFirstLetterOfSentence(text));
static string UppercaseFirstLetterOfSentence(string txt)
{
    if (string.IsNullOrWhiteSpace(txt))
        return txt;

    char[] charArray = txt.ToCharArray();
    bool isStartOfSentence = true;

    for (int i = 0; i < charArray.Length; i++)
    {
        if (isStartOfSentence && char.IsLetter(charArray[i]))
        {
            charArray[i] = char.ToUpper(charArray[i], CultureInfo.CurrentCulture);
            isStartOfSentence = false;
        }
        else if (charArray[i] == '.' || charArray[i] == '!' || charArray[i] == '?')
        {
            isStartOfSentence = true;
        }
    }

    return new string(charArray);
}
using System;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {

        if (statement.Trim().EndsWith('?'))
        {
            var result = IsAskingWithCrying(statement);
            if (result)
            {
                return "Calm down, I know what I'm doing!";
            }

            return "Sure.";
        }

        if (IsWhiteSpace(statement))
        {
            return "Fine. Be that way!";
        }

        if (IsShouting(statement))
        {
            return "Whoa, chill out!";
        }
        else
        {
            return "Whatever.";
        }
    }

    private static bool IsAskingWithCrying(string text)
    {
        var newText = SaveOnlyLetters(text);
        if (newText.All(char.IsUpper) && newText != "")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private static bool IsWhiteSpace(string text)
    {
        if (text.All(char.IsWhiteSpace))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private static bool IsShouting(string text)
    {
        var filreredText = SaveOnlyLetters(text);
        if (filreredText.All(char.IsUpper) && filreredText != "")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private static string SaveOnlyLetters(string text)
    {
        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsWhiteSpace(text[i]) || !char.IsLetter(text[i]))
            {
                text = text.Remove(i, 1);
                i -= 1;
            }
        }
        return text;
    }
}
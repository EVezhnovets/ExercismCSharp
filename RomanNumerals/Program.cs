public static class RomanNumeralExtension
{
    public static string ToRoman(this int value)
    {
        var str = value.ToString();
        if (str.Length == 1) return ToRomanIfOneDigit(str[0]);
        if (str.Length == 2) return ToRomanIfTwoDigits(str[0]) + ToRomanIfOneDigit(str[1]);
        if (str.Length == 3) return ToRomanIfThreeDigits(str[0]) + ToRomanIfTwoDigits(str[1]) + ToRomanIfOneDigit(str[2]);
        if (str.Length == 4) return ToRomanIfFourDigits(str[0]) + ToRomanIfThreeDigits(str[1]) + ToRomanIfTwoDigits(str[2]) + ToRomanIfOneDigit(str[3]);
        else return str;
    }

    public static string ToRomanIfOneDigit(char value) => value switch
    {
        '1' => "I",
        '2' => "II",
        '3' => "III",
        '4' => "IV",
        '5' => "V",
        '6' => "VI",
        '7' => "VII",
        '8' => "VIII",
        '9' => "IX",
        _ => default
    };
    public static string ToRomanIfTwoDigits(char value) => value switch
    {
        '1' => "X",
        '2' => "XX",
        '3' => "XXX",
        '4' => "XL",
        '5' => "L",
        '6' => "LX",
        '7' => "LXX",
        '8' => "LXXX",
        '9' => "XC",
        _ => default
    };
    public static string ToRomanIfThreeDigits(char value) => value switch
    {
        '1' => "C",
        '2' => "CC",
        '3' => "CCC",
        '4' => "CD",
        '5' => "D",
        '6' => "DC",
        '7' => "DCC",
        '8' => "DCCC",
        '9' => "CM",
        _ => default
    };
    public static string ToRomanIfFourDigits(char value) => value switch
    {
        '1' => "M",
        '2' => "M",
        '3' => "MMM",
        _ => default
    };
}
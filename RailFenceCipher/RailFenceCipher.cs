using System;
using System.Text;

namespace RailFenceCipher
{
    public class RailFenceCipher
    {
        public int Rails { get; set; }

        public RailFenceCipher(int rails)
        {
            Rails = rails;
        }

        public string Encode(string input)
        {
            var inputForEncode = input.Replace(" ", "");
            char[] inputArr = inputForEncode.ToCharArray();
            string[] list = new string[Rails];

            int counterRail = 0;
            int counterChar = 0;
            bool ascent = true;

            for (int i = 0; i < inputForEncode.Length; i++)
            {
                if (ascent)
                {
                    list[counterRail] += inputArr[i].ToString();
                    counterChar++;
                    counterRail++;
                    if (counterRail == (Rails - 1))
                    {
                        ascent = false;
                    }
                    if (counterRail == 0)
                    {
                        ascent = true;
                    }
                }
                else
                {
                    list[counterRail] += inputArr[i].ToString();
                    counterChar++;
                    counterRail--;
                    if (counterRail == (Rails - 1))
                    {
                        ascent = false;
                    }
                    if (counterRail == 0)
                    {
                        ascent = true;
                    }
                }
            }

            StringBuilder result = new();

            foreach (string str in list)
            {
                result.Append(str);
            }

            return result.ToString();
        }

        public string Decode(string input)
        {
            int[] list = new int[Rails];
            int counterRail = default;
            int counterChar = default;
            bool ascent = true;

            for (int i = 0; i < input.Length; i++)
            {
                if (ascent)
                {
                    list[counterRail] += 1;
                    counterChar++;
                    counterRail++;
                    if (counterRail == (Rails - 1))
                    {
                        ascent = false;
                    }
                    if (counterRail == 0)
                    {
                        ascent = true;
                    }
                }
                else
                {
                    list[counterRail] += 1;
                    counterChar++;
                    counterRail--;
                    if (counterRail == (Rails - 1))
                    {
                        ascent = false;
                    }
                    if (counterRail == 0)
                    {
                        ascent = true;
                    }
                }
            }

            StringBuilder result = new(input);
            int counterLength = default;
            foreach (int str in list)
            {
                result.Insert(str + counterLength, " ");
                counterLength = str + counterLength + 1;

            }

            string[] resArr = result.ToString().Trim().Split(" ");
            bool ascentFinish = true;
            counterRail = default;
            int counterFinish = default;
            result.Clear();

            while (counterFinish <= input.Length)
            {
                if (ascentFinish)
                {
                    for (int i = counterRail; i < resArr.Length; i++)
                    {
                        var str = resArr[i];

                        if (!(str == ""))
                        {
                            result.Append(str[0]);
                            resArr[i] = resArr[i].Substring(1);
                        }

                        counterRail++;
                        counterFinish++;

                        if (counterRail == (Rails - 1))
                        {
                            ascentFinish = false;
                        }
                    }

                }
                if (!ascentFinish)
                {
                    counterRail -= 2;
                    for (int i = counterRail; i >= 0; i--)
                    {
                        string str = resArr[i];
                        if (!(str == ""))
                        {
                            result.Append(str[0]);
                            resArr[i] = resArr[i].Substring(1);
                        }
                        counterRail--;
                        counterFinish++;
                        if (counterRail == 0)
                        {
                            ascentFinish = true;
                        }
                    }
                    counterRail += 2;
                }
            }
            return result.ToString();
        }
    }
}
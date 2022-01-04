
Console.WriteLine();

string word = "ABC";

Console.WriteLine($"{word[0]}{word[1]}{word[2]}");

Console.WriteLine($"{word[0]}{word[2]}{word[1]}");

Console.WriteLine($"{word[1]}{word[0]}{word[2]}");

Console.WriteLine($"{word[1]}{word[2]}{word[0]}");

Console.WriteLine($"{word[2]}{word[0]}{word[1]}");

Console.WriteLine($"{word[2]}{word[1]}{word[0]}");

Console.WriteLine();



foreach (char letter1 in word)
{
    foreach (char letter2 in word)
    {
        foreach (char letter3 in word)
        {
            if (letter1 != letter2 && letter1 != letter3 && letter2 != letter3)
            {
                Console.WriteLine($"{letter1}{letter2}{letter3}");

            }

        }

    }

}



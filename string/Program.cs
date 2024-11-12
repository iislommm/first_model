namespace String;

internal class Program
{
    public static string HelloName(string name)
    {
        var response = $"Hello {name}";
        return response;
    }
    public static string MakeAbba(string firstWord, string secondWord)
    {
        var response = $"{firstWord}{secondWord} {secondWord}{firstWord}";

        return response;
    }
    public static string MakeOutWord(string firstWord, string secondWord)
    {

        var readyText = firstWord.Substring(0, 2) + secondWord + firstWord.Substring(2);
        return readyText;
    }

    public static string ExtraEnd(string text)
    {
        var readyText = text.Substring(text.Length - 2) + text.Substring(text.Length - 2) + text.Substring(text.Length - 2);
        return readyText;
    }

    public static string FirstTwo(string letter)
    {
        if (letter.Length >= 2)
        {
            var readyText = letter.Substring(0, 2);
            return readyText;
        }
        else
        {
            return letter;
        }

    }

    public static string FirstHalf(string word)
    {
        var readyText = word.Substring(0, word.Length / 2);
        return readyText;
    }

    public static string WithoutEnd(string word)
    {
        if (word.Length > 2)
        {
            var readyWord = word.Substring(1, word.Length - 2);

            return readyWord;
        }
        return word;
    }

    public static string ComboStarting(string firstWord, string secondWord)
    {

        if (firstWord.Length > secondWord.Length)
        {
            return $"{secondWord} {firstWord} {secondWord}";
        }
        else if (firstWord.Length < secondWord.Length)
        {
            return $"{firstWord} {secondWord} {firstWord}";
        }
        else
        {
            return "They are equal";
        }

    }

    public static string NonStart(string firstWord, string secondWord)
    {
        var readyForm = firstWord.Substring(1) + secondWord.Substring(1);
        return readyForm;
    }

    public static string LeftTwo(string word)
    {
        var readyForm = word.Substring(2) + word.Substring(0, 2);
        return readyForm;
    }

    public static string TheEnd(string word, bool front)
    {
        if (front is true)
        {
            return word.Substring(0, 1);
        }
        else
        {
            return word.Substring(word.Length - 1);
        }
    }

    public static string nTwice(string word, int number)
    {
        var readyForm = word.Substring(0, number) + word.Substring(word.Length - number);
        return readyForm;
    }

    public static string MiddleThree(string word)
    {
        var readyForm = word.Remove(word.Length / 2 - 1, word.Length / 2 + 1);
        return readyForm;
    }

    public static string ConCat(string firstWord, string secondWord)
    {
        for (var i = 1; i < firstWord.Length; i++)
        {
            if (firstWord[firstWord.Length - 1] == secondWord[0])
            {
                secondWord = secondWord.Remove(0, 1);
            }
        }
        return $"{firstWord}{secondWord}";
    }

    public static string LastTwo(string word)
    {
        var readyForm = word.Substring(0, word.Length - 2) + word.Substring(word.Length - 1) + word.Substring(word.Length - 2);
        return readyForm;
    }

    public static string SeeColor (string word)
    {
        var redForm = word.Substring(0, 3);
        var blueForm = word.Substring(0, 4);
        if (redForm is "red")
        {
            return redForm;
        }else if (blueForm is "blue")
        {
            return blueForm;
        }else
        {
            return word;
        }

    }
    static void Main(string[] args)
    {
        //Console.Write("Enter name :");
        //var text = Console.ReadLine();
        //var result = HelloName(text);
        //Console.WriteLine($"Hello {result}");

        //Console.Write("Enter firtsWord :");
        //var firstWordd = (Console.ReadLine());
        //Console.Write("Enter secodndWord :");
        //var secondWordd = (Console.ReadLine());
        //var result = MakeAbba(firstWordd, secondWordd);
        //Console.WriteLine(result);

        //Console.Write("Enter firstWord :");
        //var firstWord = Console.ReadLine();
        //Console.Write("Enter secondWord :");
        //var secondWord = Console.ReadLine();
        //var result = MakeOutWord(firstWord, secondWord);
        //Console.WriteLine(result);

        //Console.Write("Enter word :");
        //var text = Console.ReadLine();
        //var result = ExtraEnd(text);
        //Console.WriteLine(result);

        //Console.Write("Enter smth :");
        //var letter = Console.ReadLine();
        //var result = FirstTwo(letter);
        //Console.WriteLine(result);

        //Console.Write("Enter word :");
        //var word = Console.ReadLine();
        //var result = FirstHalf(word);
        //Console.WriteLine(result);

        //Console.Write("Enter word plz :");
        //var word = Console.ReadLine();
        //var result = WithoutEnd(word);
        //Console.WriteLine(result);

        //Console.Write("Enter first number :");
        //var firstNumber = Console.ReadLine();
        //Console.Write("Enter second number :");
        //var secondNumber = Console.ReadLine();
        //var result = ComboStarting(firstNumber, secondNumber);
        //Console.WriteLine(result);

        //Console.Write("Enter first number :");
        //var firstWord = Console.ReadLine();
        //Console.Write("Enter second number :");
        //var secondWord = Console.ReadLine();
        //var result = NonStart(firstWord, secondWord);
        //Console.WriteLine(result);

        //Console.Write("Enter word :");
        //var word = Console.ReadLine();
        //var result = LeftTwo(word);
        //Console.WriteLine(result);

        //Console.Write("Enter word :");
        //var word = Console.ReadLine();
        //Console.Write("7 x 6 =  ");
        //var number = int.Parse(Console.ReadLine());
        //var check = false;
        //if (number is 42)
        //{
        //    check = true;
        //}
        //var result = TheEnd(word, check);
        //Console.WriteLine(result);

        //Console.Write("Eneter word :");
        //var word = Console.ReadLine();
        //Console.Write("Enter number plz :");
        //var number = int.Parse(Console.ReadLine());
        //var result = nTwice(word, number);
        //Console.WriteLine(result);

        //Console.Write("Enter word :");
        //var word = Console.ReadLine();
        //var result = MiddleThree(word);
        //Console.WriteLine(result);

        //Console.Write("Enter firstWord :");
        //var firstWord = Console.ReadLine();
        //Console.Write("Enter seconWord :");
        //var secondWord = Console.ReadLine();
        //var result = ConCat(firstWord, secondWord);
        //Console.WriteLine();

        //Console.Write("Enter word :");
        //var word = Console.ReadLine();
        //var result = LastTwo(word);
        //Console.WriteLine(result);

        Console.Write("Enter word :");
        var word = Console.ReadLine();
        var result = SeeColor(word);
        Console.WriteLine(result);









        Main(args);
    }
}

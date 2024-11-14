namespace secondSlideInString
{
    internal class Program
    {
        public static bool CatDog(string word)
        {
            var temp = string.Empty;
            var catCounter = 0;
            var dogCounter = 0;
            for (var i = 0; i < word.Length - 2; i++)
            {
                temp = word.Substring(i, 3);
                if (temp == "cat")
                {
                    catCounter++;
                }
                else if (temp == "dog")
                {
                    dogCounter++;
                }
            }


            return catCounter == dogCounter;
        }
        public static int CountCode(ref string word)
        {
            var counter = 0;//code cofe
            for (var i = 0; i < word.Length - 2; ++i)
            {
                if (Char.IsLetter(word[i + 2]) && word[i] == 'c' && word[i + 1] == 'o' && word[i + 3] == 'e')
                {
                    counter++;
                }

            }
            return counter;
        }
        public static bool EndOther(string firstWord, string secondWord)
        {

            var checker = false;
            var checkerString = string.Empty;
            //foreach (var charecter in firstWord)
            //{
            //     if (char.IsLower(charecter) is true)
            //    {
            //        firstWord += char.ToUpper(charecter);
            //    }
            //    else
            //    {
            //        secondWord += charecter;
            //    }
            //    if (char.IsLower(charecter) is true)
            //    {
            //        secondWord += char.ToUpper(charecter);
            //    }
            //    else
            //    {
            //        secondWord += charecter;
            //    }
            //}
            if (firstWord.Length > secondWord.Length)
            {
                for (var i = 0; i < firstWord.Length; ++i)
                {

                    checkerString = firstWord.Substring(firstWord.Length - secondWord.Length);
                    if (checkerString == secondWord)
                    {
                        checker = true;
                    }
                }
            }
            else if (firstWord.Length < secondWord.Length)
            {
                for (var i = 0; i > firstWord.Length; ++i)
                {
                    checkerString = secondWord.Substring(secondWord.Length - firstWord.Length);
                    if (checkerString == firstWord)
                    {
                        checker = true;
                    }
                }
            }

            return checker;
        }
        public static bool Xyz(string word)
        {
            var check = false;
            var readyForm = string.Empty;
            for (var i = 0; i < word.Length; ++i)
            {
                readyForm = word.Substring(i, 3);
                if (readyForm == "xyz")
                {
                    if (i == 0 || word[i - 1] != '.')
                    {
                        check = true;
                    }
                }
            }

            return check;
        }
        public static string RepeatEnd(string word, int number)
        {
            var result = string.Empty;
            var readyForm = word.Substring(word.Length - number);
            for (var i = 0; i < number; ++i)
            {
                result += readyForm;
            }
            return result;
        }
        public static string RepeatStart(string word, int number)
        {
            var result = string.Empty;
            var readyForm = word.Substring(0, number);
            for (var i = number; i > 0; --i)
            {
                result += readyForm;
            }
            return result;
        }

        public static string RepeatSeparator(string firstString, string secondString, int number)
        {
            var result = firstString.Substring(0) + secondString.Substring(0);
            var readyForm = string.Empty;
            for (var i = 0; i < number; ++i)
            {
                readyForm += result;
            }
            readyForm = readyForm.Remove(readyForm.Length - secondString.Length);
            return readyForm;
        }

        public static bool PrefixAgain(string word, int number)
        {//assalomu alaikum nima  assalomu alaikum gap 
            var substeredWord = word.Substring(0, number);
            var removed = word.Substring(number);
            //var check = false;
            for (var i = number; i < word.Length; i++)
            {
                if (word.Contains(substeredWord))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool XyzMiddle(string text)
        {
            // "salomxyz xyzhelloxyz" 5
            for (var i = 0; i < text.Length - 2; i++)
            {
                var substredText = text.Substring(i, 3);
                if (substredText == "xyz")
                {
                    var firstText = text.Substring(0, i);
                    var secondText = text.Substring(i + 3);

                    var diff = firstText.Length - secondText.Length;
                    if (-1 <= diff && diff <= 1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static string PlusOut(string word)
        {

            var result = string.Empty;
            foreach (var character in word)
            {
                if (char.IsLetter(character))
                {
                    result += character;
                }
                else
                {
                    result += "+";
                }
            }
            return result;
        }


        static void Main(string[] args)
        {
            //Console.Write("Enter word :");
            //var word = Console.ReadLine();
            //var result = CatDog(word);
            //Console.WriteLine(result);

            //Console.Write("Enter something :");
            //var text = Console.ReadLine();
            //Console.WriteLine(CountCode(ref text));

            //Console.Write("Enter firstWord :");
            //var firstWord = Console.ReadLine();
            //Console.Write("Enter seconWord :");
            //var secondWord = Console.ReadLine();
            //var result = EndOther(firstWord, secondWord);
            //Console.WriteLine(result);

            //Console.Write("Enter text");
            //var text = Console.ReadLine();
            //var result = Xyz(text);
            //Console.WriteLine(result);

            //Console.Write("Enter text :");
            //var word = Console.ReadLine();
            //Console.Write("Enter number :");
            //var number = int.Parse(Console.ReadLine());
            //var result = RepeatEnd(word, number);
            //Console.WriteLine(result);

            //Console.Write("Enter word :");
            //var word = Console.ReadLine();
            //Console.Write("Enter number plz :");
            //var number = int.Parse(Console.ReadLine());
            //var result = RepeatStart(word, number);
            //Console.WriteLine(result);

            //Console.Write("Enter firstWord :");
            //var firstWord = Console.ReadLine();
            //Console.Write("Enter secondWord :");
            //var secondWord = Console.ReadLine();
            //Console.Write("Enter number :");
            //var number = int.Parse(Console.ReadLine());
            //var result = RepeatSeparator(firstWord, secondWord, number);
            //Console.WriteLine(result);

            //Console.Write("Enter word :");
            //var word = Console.ReadLine();
            //Console.Write("Enter number :");
            //var number = int.Parse(Console.ReadLine());
            //var result = PrefixAgain(word, number);
            //Console.WriteLine(result);

            //Console.WriteLine(XyzMiddle("xyz"));
            //Console.WriteLine(XyzMiddle("AAxyzBB"));
            //Console.WriteLine(XyzMiddle("AxyzBB"));
            //Console.WriteLine(XyzMiddle("AxyzBBB"));
            //Console.WriteLine(XyzMiddle("xyzAxyzBBB"));

            //Console.Write("Enter word :");
            //var word = Console.ReadLine();
            //var result = PlusOut(word);
            //Console.WriteLine(result);



            Main(args);


        }
    }
}



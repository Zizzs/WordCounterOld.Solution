using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class Program
    {
        public static void Main()
        {
            WordMatchClass userMatch = new WordMatchClass();
            Console.WriteLine("Welcome to Word Counter!");
            Console.WriteLine("The program will check to see how many times your word is contained in a sentence.");
            Console.WriteLine("Please enter your word: ");
            string userWord = Console.ReadLine().ToLower();
            Console.WriteLine("Please enter a sentence");
            string userString = Console.ReadLine().ToLower();
            userMatch.StringSplitWord(userWord, userString);
            int total = RepeatCounter.totalMatch;
            Console.WriteLine(total);
        }
    }

    public class WordMatchClass
    {
        public int StringSplitWord(string inputWord, string inputString)
        {
            string[] userArr = inputString.Split(' ');
            foreach (string word in userArr)
            {
                Calculate(inputWord , word);
            }
            return RepeatCounter.totalMatch;
        }
        public void FindMatch(string userWordInput, string stringWordInput)
        {
                if (userWordInput == stringWordInput)
                {
                    AddToCounter();
                    return;
                }
                else
                {
                    return;
                }
        }

        public void AddToCounter()
        {
            RepeatCounter.totalMatch++;
        }

        public void Calculate(string tempUserString, string tempWordString)
        {
            FindMatch(tempUserString, tempWordString);
        }

        public static void ClearAll()
        {
            RepeatCounter.totalMatch = 0;
            
        }

    }

    class RepeatCounter
    {
        public static int totalMatch = 0;
    }
}
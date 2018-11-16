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
            string userWord = Console.ReadLine();
            Console.WriteLine("Please enter a sentence");
            string userString = Console.ReadLine();
            string[] userArr = userString.Split(' ');
            foreach (string word in userArr)
            {
                userMatch.Calculate(userWord , word);
            }
            Console.WriteLine(RepeatCounter.totalMatch);
        }
    }

    public class WordMatchClass
    {
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
    }

    class RepeatCounter
    {
        public static int totalMatch = 0;
    }
}
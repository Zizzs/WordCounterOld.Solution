using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class Program
    {
        public static void Main()
        {
            WordMatchClass userMatch = new WordMatchClass();
            string multiple;
            Console.WriteLine("Welcome to Word Counter!");
            Console.WriteLine("The program will check to see how many times your word is contained in a sentence.");
            Console.WriteLine("Please enter your word: ");
            string userWordInput = Console.ReadLine();
            string userWord = userWordInput.ToLower();
            Console.WriteLine("Please enter a sentence");
            string userStringInput = Console.ReadLine();
            string userString = userStringInput.ToLower();
            userMatch.StringSplitWord(userWord, userString);
            int total = RepeatCounter.totalMatch;
            if (total > 1 || total == 0)
            {
                multiple = "times";
            }
            else
            {
                multiple = "time";
            }
            Console.WriteLine("The word " + userWordInput +" is used within the sentence " + "'" + userStringInput + "' " + total + " " + multiple + ".");
        }
    }

    public class WordMatchClass
    {
        public int StringSplitWord(string inputWord, string inputString)
        {
            string[] userArr = inputString.Replace(",","").Replace(".","").Split(' ');
            foreach (string word in userArr)
            {
                FindMatch(inputWord , word);
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
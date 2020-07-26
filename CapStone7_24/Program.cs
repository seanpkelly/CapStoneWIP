using System;

namespace CapStone7_24
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x = true;
            
            while (x)
            {
                Console.WriteLine("Let's convert a word into Pig Latin!");
                Console.WriteLine("*OR* as they say in Pig Latin-");
                Console.WriteLine("Et'slay onvertcay away ordway intoway Igpay Atinlay!");
                Console.WriteLine("=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*");
                string word = Console.ReadLine();
                word = word.ToLower();
                string pigLatin = ToPigLatin(word);
                Console.WriteLine(pigLatin);

                while (true)
                {
                    Console.Write("Do you want to play again [Y/N]?");
                    string answer = Console.ReadLine().ToUpper();
                    if (answer == "Y")
                        break;
                    else if (answer == "N")
                        x = false;
                        break; 
                }
            }
        }

        public static int VowelOrNot(char letter)
        {
            string vowels = "aeiou";
            int index = vowels.IndexOf(letter);
            return index;
        }

        public static string ToPigLatin(string word)
        {
            string restOfWord, newWord, initialPart = "";
            int currentLetter = 0;
            string ToPigLatin;
            // return initialPart + " = " + word;

            if (VowelOrNot(word[0]) != -1)

            {
                newWord = word + "way";
                return newWord;
            }
            else
            {

                for (int i = 0; i < word.Length; i++)
                {
                    // string initalPart = word.Substring(i, 1);
                    currentLetter = i;
                    if (VowelOrNot(word[i]) == -1)
                    {
                        initialPart += word[i].ToString();
                    }
                    else
                    {
                        // using substring(startIndex, length) get the remaining part of the word (restOfWord)
                        break;
                        //newWord = restOfWord + initalPart + "ay";
                    }
                }
                return word.Substring(currentLetter) + word.Substring(0, currentLetter) + "ay";
                }
            }
        }
    }








using System;

namespace CapStone7_24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's convert a word into Pig Latin!");
            Console.WriteLine("*OR* as they say in Pig Latin-");
            Console.WriteLine("Et'slay onvertcay away ordway intoway Igpay Atinlay!");
            Console.WriteLine("=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*");
            string word = Console.ReadLine();
            string pigLatin = ToPigLatin(word);
            Console.WriteLine(pigLatin);
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
            int currentLetter;

            if (VowelOrNot(word[0]) != -1)
            {
                newWord = word + "way";
            }
            else
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (VowelOrNot(word[i]) == -1)
                    {
                        initialPart += word[i].ToString();
                    }
                    else
                    {
                        // using substring(startIndex, length) get teh remaining part of the word (restOfWord)




                        newWord = restOfWord + initalPart + "ay";
                    }
                }

            }


            
        }
    }







}





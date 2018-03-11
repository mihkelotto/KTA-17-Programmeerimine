using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string[] words = { "karu", "ilves", "kits", "orav", "siil", "kährik", "hunt", "rebane" };
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZÜÖÄ".ToCharArray();
            string[] alphaStr = new string[alpha.Length];

            Random rnd = new Random();
            string rndWord = words[rnd.Next(0, words.Length - 1)];

            int wrong = 0;

            for (int i = 0; i < alpha.Length; i++)
            {
                alphaStr[i] = alpha[i].ToString().ToLower();
            }

            StringBuilder wordPieces = new StringBuilder();
            for (int i = 0; i < rndWord.Length; i++)
            {
                wordPieces.Append(rndWord[i]);
            }

            string[] rightInput = new string[wordPieces.Length];

            Console.WriteLine("Arvuti on valinud ühe sõna, arva see tähthaaval ära vähem kui 5 eksimusega");

            while (true)
            {
                bool wrongSymbol = false;

                Console.Write("Sisesta täht: ");
                string userInput = Console.ReadLine().ToLower();

                if (!(alphaStr.Contains(userInput)))
                {
                    Console.WriteLine("Vale sisend, sisesta ÜKS TÄHT.");
                    wrongSymbol = true;
                }

                if (rightInput.Contains(userInput))
                {
                    Console.WriteLine($"Sinu sisestatud täht {userInput} oli õige. Kaks korda ei saa sama tähte sisestada.");
                    wrong++;

                }

                if (wordPieces.ToString().Contains(userInput) && (!(rightInput.Contains(userInput))) && !(wrongSymbol == true))
                {
                    Console.WriteLine();
                    Console.WriteLine($"Täht {userInput} sobib.");
                    Console.Write("Ära arvatud tähed:   ");

                    for (int i = 0; i < rndWord.Length; i++)
                    {
                        if (userInput.Equals(wordPieces[i].ToString()))
                        {
                            Console.Write(userInput + " ");
                            rightInput[i] = userInput;
                        }

                        else if (!(rightInput[i] == null))
                        {
                            Console.Write(rightInput[i] + " ");
                        }

                        else
                        {
                            Console.Write("_ ");
                        }
                    }

                    Console.WriteLine();

                }

                if (!(wordPieces.ToString().Contains(userInput)) && !(rightInput.Contains(userInput)) && !(wrongSymbol == true))
                {
                    Console.WriteLine();
                    Console.WriteLine("Ei arvanud õiget tähte ära, paku mõni teine täht.");
                    Console.Write("Ära arvatud tähed:   ");

                    for (int i = 0; i < rndWord.Length; i++)
                    {
                        if (!(rightInput[i] == null))
                        {
                            Console.Write(rightInput[i] + " ");
                        }
                        else
                        {
                            Console.Write("_ ");
                        }
                    }
                    Console.WriteLine();
                    wrong++;

                }

                Console.WriteLine();

                if (!(rightInput.Contains(null)))
                {
                    Console.WriteLine("Võit! Arvasid sõna ära.");
                    break;
                }

                if(wrong == 5)
                {
                    Console.WriteLine("Kaotasid! 5 eksimust");
                    break;
                }

            }

            Console.WriteLine();

            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordMixer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("See programm jätab lauses iga sõna esimese ja viimase tähe paigale, kuid muudab sõna sees olevate tähtede järjekorda.");

            Console.Write("Sisesta lause: ");
            string s = Console.ReadLine();

            string[] words = s.Split(' ');
            string word;
            string first;
            string last;

            word = words[0];

            StringBuilder wordPieces = new StringBuilder();
            for (int i = 0; i < word.Length; i++)
            {
                wordPieces.Append(word[i]);
            }

            string[] choppedWord = new String[wordPieces.Length];
            for (int i = 0; i < wordPieces.Length; i++)
            {
                choppedWord[i] = wordPieces[i].ToString();

            }

            first = choppedWord.First();
            last = choppedWord.Last();

            string[] arr = choppedWord.Skip(1).ToArray();

            string[] shuffledReadyArray = new String[arr.Length];
            for (int i = 0; i < shuffledReadyArray.Length - 1; i++)
            {
                shuffledReadyArray[i] = arr[i];
            }

            Random r = new Random();

            shuffledReadyArray = shuffledReadyArray.OrderBy(x => r.Next()).ToArray();

            string str = string.Join("", shuffledReadyArray);


            Console.WriteLine(first + str + last);



            //Console.WriteLine("> must koer hüppas üle suure valge aia");
            //Console.WriteLine("msut keor hapüps üle surue vgale aia");

            Console.WriteLine("Press any key to continue");
            Console.ReadLine();

        }
    }

}
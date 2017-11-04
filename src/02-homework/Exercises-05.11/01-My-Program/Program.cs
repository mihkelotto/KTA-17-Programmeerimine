using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
  Kasutaja sisestab 6 arvu vahemikus 1-20ni ja arvud sisestatakse masiivi.
  Arvuti valib 6 suvalist samas vahemikus olevat numbrit, mis sisestatakse teise massiivi.
  Kasutaja sisestuse puhul kontrollitakse seda, et arv on lubatud vahemikus või numbrid ei korduks,
  sel juhul peab kasutaja arvu uuesti sisestama.
  Ka arvuti valitud numbrid ei tohi korduda.
  Programm kirjutab välja nii kasutaja sisestatud numbrid kui ka arvuti omad,
  tabamuste arvu ning seejärel äraarvatud numbrid,
  kui need puuduvad siis kuvatakse numbrite asemel sõna "puuduvad".
  Viimasena arvutatakse välja mitu protsenti arvuti valitud arvudest ära arvati.

  Õppisin kasutama massiivi, kasutaja ja arvuti sisestatud arvude salvestamiseks 
  ning for tsükklit arvude massiivi sisestamiseks ja nende massiivist lugemiseks.
  Meetodit Contains kasutasin selleks, et kindlaks teha kas sisestatud arv on juba massiivis ja 
  kahe massiivi samasuguste elementide kindlaks tegemisel.
*/

namespace _01_My_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] userArray = new int[6];
            int[] computerArray = new int[6];

            Random rnd = new Random();

            Console.WriteLine("Arvuti valib kuus numbrit, püüa võimalikult palju ära arvata, sisestades kuus numbrit vahemikus 1-20ni.");
            Console.WriteLine();

            for (int i = 0; i < userArray.Length; i++)
            {
                bool getOutUser = false;
                while (getOutUser == false)
                {
                    bool wrongUserNumber = false;

                    Console.Write($"{i + 1}. number: ");

                    string input = Console.ReadLine();

                    int userNumber = int.Parse(input);

                    if (userNumber < 1 || userNumber > 20)
                    {
                        Console.WriteLine("Sisestatud arv peab jääma vahemikku 1-20ni.");
                        Console.WriteLine();
                        wrongUserNumber = true;
                    }

                    if (userNumber > 0 && userNumber < 21)
                    {
                        wrongUserNumber = false;
                    }

                    if (userArray.Contains(userNumber))
                    {
                        if (userNumber != 0)
                        {
                            Console.WriteLine("Väärtus on juba sisestatud. Palun sisesta mõni teine number. ");
                            Console.WriteLine();
                            wrongUserNumber = true;
                        }
                    }

                    if (wrongUserNumber == false)
                    {
                        userArray[i] = userNumber;
                        getOutUser = true;
                    }
                }
            }

            for (int i = 0; i < computerArray.Length; i++)
            {
                bool getOutComp = false;
                while (getOutComp == false)
                {
                    bool wrongCompNumber = false;

                    int randomNumber = rnd.Next(1, 21);

                    if (computerArray.Contains(randomNumber))
                    {
                        wrongCompNumber = true;
                    }

                    if (wrongCompNumber == false)
                    {
                        computerArray[i] = randomNumber;
                        getOutComp = true;
                    }
                }

            }

            Console.WriteLine();

            Console.Write("Sinu sisestatud numbrid: ");
            for (int i = 0; i < userArray.Length; i++)
            {
                if (!(i == userArray.Length - 1))
                {
                    Console.Write($"{userArray[i]}, ");
                }

                if (i == userArray.Length - 1)
                {
                    Console.Write(userArray[i]);
                }
            }

            Console.WriteLine();

            Console.Write("Arvuti valitud numbrid:  ");
            for (int i = 0; i < computerArray.Length; i++)
            {
                if (!(i == computerArray.Length - 1))
                {
                    Console.Write($"{computerArray[i]}, ");
                }

                if (i == computerArray.Length - 1)
                {
                    Console.Write(computerArray[i]);
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Äraarvatud numbrid: ");
            int count = 0;

            for (int i = 0; i < computerArray.Length; i++)
            {
                if (userArray.Contains(computerArray[i]))
                {
                    Console.Write($"{computerArray[i]}  ");
                    count++;
                }

                if (i == computerArray.Length - 1 && count == 0)
                {
                    Console.Write("puuduvad");
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Tabamuste arv: " + count);

            Console.WriteLine();

            Console.WriteLine($"Arvasid {count * 100 / computerArray.Length} %  arvuti valitud arvudest ära.");

            Console.WriteLine();

            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}

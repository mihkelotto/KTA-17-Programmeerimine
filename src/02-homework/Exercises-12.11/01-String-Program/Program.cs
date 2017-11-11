using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  Kuude täht tähe haaval ära arvamise programm. Kasutaja peab ära arvama sõna, sisestades korraga ühe tähe.
  Kui arvuti poolt valitud sõna sisaldab sama tähte, näidatakse kasutajale, et sisestus sobib ning saab pakkuda järgmise tähe. 
  Kui kasutaja poolt sisestatud täht ei ole õige, siis tekib võimalus uuesti pakkuda. Mõlemal juhul näidatakse kasutajale kas ja 
  kui palju sõnast ta on ära arvanud. Juba kord tuvastatud tähe uuesti sisestamisel tuleb teade, 
  et ära arvatud tähte pole mõtet teist korda sisestada. Kasutaja tohib sisestada ainult ühe tähe,
  igasugused muud sümbolid on keelatud, samas peab saama sisestada väikese või suurtähe. 
  Programm annab võimaluse sisestada tähti seni, kuni sõna on täielikult ära arvatud.
  Viimase arvamata tähe sisestamisel kuvatakse terve sõna.
  Sel juhul kuvab programm, et sõna on ära arvatud ja arvutab kokku valede pakkumiste summa.
  Vale pakkumise alla läheb ainult valesti pakutud üks täht, mitte muud sümbolid või mitu tähte koos.

  Materjalidena kasutasin youtube videot, kust õppisin stringide tükeldamist eraldi osadeks. 
  Lisaks kasutasin Microsofti String Class lehte, vaadates programmiks vajaminevat funktsionaalsust.

  https://www.youtube.com/watch?v=CLsmRBmteas
  https://msdn.microsoft.com/en-us/library/s1wwdcbf(v=vs.85)
  
*/

namespace _01_String_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months = { "jaanuar", "veebruar", "märts", "aprill", "mai", "juuni", "juuli", "august", "september", "oktoober", "november", "detsember" };
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZÜÖÄ".ToCharArray();
            string[] alphaStr = new string[alpha.Length];

            Random rnd = new Random();
            string rndMonth = months[rnd.Next(0, months.Length - 1)];

            int wrong = 0;

            for (int i = 0; i < alpha.Length; i++)
            {
                alphaStr[i] = alpha[i].ToString().ToLower();
            }

            StringBuilder monthPieces = new StringBuilder();
            for (int i = 0; i < rndMonth.Length; i++)
            {
                monthPieces.Append(rndMonth[i]);
            }

            string[] rightInput = new string[monthPieces.Length];

            Console.WriteLine("Proovi täht tähe haaval ära arvata kuude nimetused.");

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

                if (monthPieces.ToString().Contains(userInput) && (!(rightInput.Contains(userInput))) && !(wrongSymbol == true))
                {
                    Console.WriteLine();
                    Console.WriteLine($"Täht ``{userInput}´´ sobib.");
                    Console.Write("Ära arvatud tähed:   ");

                    for (int i = 0; i < rndMonth.Length; i++)
                    {
                        if (userInput.Equals(monthPieces[i].ToString()))
                        {
                            Console.Write(userInput);
                            rightInput[i] = userInput;
                        }

                        else if (!(rightInput[i] == null))
                        {
                            Console.Write(rightInput[i]);
                        }

                        else
                        {
                            Console.Write("-");
                        }
                    }

                    Console.WriteLine();

                }

                if (!(monthPieces.ToString().Contains(userInput)) && !(rightInput.Contains(userInput)) && !(wrongSymbol == true))
                {
                    Console.WriteLine();
                    Console.WriteLine("Ei arvanud õiget tähte ära, paku mõni teine täht.");
                    Console.Write("Ära arvatud tähed:   ");

                    for (int i = 0; i < rndMonth.Length; i++)
                    {
                        if (!(rightInput[i] == null))
                        {
                            Console.Write(rightInput[i]);
                        }
                        else
                        {
                            Console.Write("-");
                        }
                    }
                    Console.WriteLine();
                    wrong++;

                }

                Console.WriteLine();

                if (!(rightInput.Contains(null)))
                {
                    Console.WriteLine("Arvasid sõna ära.");
                    Console.WriteLine($"Valede pakkumiste arv oli {wrong}.");
                    break;
                }


            }

            Console.WriteLine();

            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}

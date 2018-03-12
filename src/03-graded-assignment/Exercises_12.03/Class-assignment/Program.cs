using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vali kas 0 v6i 1");
            string input = Console.ReadLine();
            int userNumber = int.Parse(input);

            if (userNumber == 0) {
                char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
                char[] alphabetCiper = "XYZABCDEFGHIJKLMNOPQRSTUVW".ToCharArray();

                // int changeCiper = 0;
                // Console.WriteLine(alphabet.Length);

                /* Console.WriteLine("Change ciper: ");
                 string input = Console.ReadLine();
                 changeCiper = int.Parse(input); 
                 */

                Console.Write("Plaintext: ");
                string userInput = Console.ReadLine().ToUpper();

                string s = userInput;
                char[] charArray = s.ToCharArray();

                string[] ciperWord = new string[charArray.Length];

                int tempNumber = 0;

                for (int i = 0; i < charArray.Length; i++)
                {
                    for (int j = 0; j < alphabet.Length; j++)
                    {
                        if (charArray[i] == alphabet[j])
                        {
                            // if(changeCiper == 0)
                            // {
                            tempNumber = j;
                            //  }

                            /* if (changeCiper != 0 || ( (j + changeCiper) <= alphabet.Length || (j - changeCiper) >= 0))
                             {
                                 tempNumber = j + changeCiper;
                                 Console.WriteLine("test1");
                             }

                             if ((j + changeCiper) > alphabet.Length)
                             {
                                 tempNumber = (j + changeCiper) - (alphabet.Length - 1);
                                 Console.WriteLine("test2");
                             }

                             if ((j + changeCiper) < 0)
                             {
                                 tempNumber = (j - changeCiper) + (alphabet.Length + 1);
                                 Console.WriteLine("test3");
                             }
                             */


                        }
                    }

                    string letter = alphabetCiper[tempNumber].ToString();

                    ciperWord[i] = letter.ToLower();
                }

                //File.WriteAllText(Directory.GetCurrentDirectory() + "/crypto.txt", encrypted);

                Console.Write("Cipherword: ");

                for (int i = 0; i < charArray.Length; i++)
                {
                    Console.Write(ciperWord[i]);
                }
            }

            if (userNumber == 1)
            {
                char[] alphabetCiper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
                char[] alphabet = "XYZABCDEFGHIJKLMNOPQRSTUVW".ToCharArray();

                // int changeCiper = 0;
                // Console.WriteLine(alphabet.Length);

                /* Console.WriteLine("Change ciper: ");
                 string input = Console.ReadLine();
                 changeCiper = int.Parse(input); 
                 */

                Console.Write("Plaintext: ");
                string userInput = Console.ReadLine().ToUpper();

                string s = userInput;
                char[] charArray = s.ToCharArray();

                string[] ciperWord = new string[charArray.Length];

                int tempNumber = 0;

                for (int i = 0; i < charArray.Length; i++)
                {
                    for (int j = 0; j < alphabetCiper.Length; j++)
                    {
                        if (charArray[i] == alphabetCiper[j])
                        {
                            // if(changeCiper == 0)
                            // {
                            tempNumber = j;
                            //  }

                            /* if (changeCiper != 0 || ( (j + changeCiper) <= alphabet.Length || (j - changeCiper) >= 0))
                             {
                                 tempNumber = j + changeCiper;
                                 Console.WriteLine("test1");
                             }

                             if ((j + changeCiper) > alphabet.Length)
                             {
                                 tempNumber = (j + changeCiper) - (alphabet.Length - 1);
                                 Console.WriteLine("test2");
                             }

                             if ((j + changeCiper) < 0)
                             {
                                 tempNumber = (j - changeCiper) + (alphabet.Length + 1);
                                 Console.WriteLine("test3");
                             }
                             */


                        }
                    }

                    string letter = alphabet[tempNumber].ToString();

                    ciperWord[i] = letter.ToLower();
                }

                Console.Write("Cipherword: ");

                for (int i = 0; i < charArray.Length; i++)
                {
                    Console.Write(ciperWord[i]);
                }

                Console.ReadLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace Couteau_Suisse
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            while (true)
            {
                
                Console.Write("Bienvenue, veuillez choisir une de ces 3 option: \n\n1. Chiffrement en Morse\n2. A venir\n3. A venir \n0. Quitter \nVotre choix: ");
                string choix = Console.ReadLine();

                if (choix == "1")
                {

                    Console.Write("\n");
                    JouerMorse(ConvertToMorse());
                    Console.Write("\n\n");
                    
                }
                else if (choix == "2")
                {
                    Console.Write("Choix disponible prochainement");
                }
                else if (choix == "3")
                {
                    Console.Write("Choix disponible prochainement");
                }
                else if (choix == "0")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Write("Veuillez choisir 1, 2 ou 3\n");
                }
            }
        }

        static void JouerMorse(string phrase)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            foreach (char symbole in phrase)
            {

                switch (symbole)
                {
                    case '.': Console.Write(symbole); Console.Beep(800, 200); Thread.Sleep(200); break;
                    case '-': Console.Write(symbole); Console.Beep(800, 750); break;
                    case '/': Console.Write(symbole); Thread.Sleep(1000); break;
                    case ' ': Console.Write(symbole); break;


                }
            }

            Console.ResetColor();
        }

        static string ConvertToMorse()
        {

            Console.Clear();
            string phrase = "";

            Console.Write("Veuillez entrer une phrase a coder en morse: ");
            string phraseToTranslate = Console.ReadLine();
            phraseToTranslate = phraseToTranslate.ToUpper();
        
            foreach(char lettre in phraseToTranslate)
            {
                switch(lettre)
                {
                    case 'A': phrase += ".- "; break;
                    case 'B': phrase += "-... "; break;
                    case 'C': phrase += "-.-. "; break;
                    case 'D': phrase += "-.. "; break;
                    case 'E': phrase += ". "; break;
                    case 'F': phrase += "..-. "; break;
                    case 'G': phrase += "--. "; break;
                    case 'H': phrase += ".... "; break;
                    case 'I': phrase += ".. "; break;
                    case 'J': phrase += ".--- "; break;
                    case 'K': phrase += "-.- "; break;
                    case 'L': phrase += ".-.. "; break;
                    case 'M': phrase += "-- "; break;
                    case 'N': phrase += "-. "; break;
                    case 'O': phrase += "--- "; break;
                    case 'P': phrase += ".--. "; break;
                    case 'Q': phrase += "--.- "; break;
                    case 'R': phrase += ".-. "; break;
                    case 'S': phrase += "... "; break;
                    case 'T': phrase += "- "; break;
                    case 'U': phrase += "..- "; break;
                    case 'V': phrase += "...- "; break;
                    case 'W': phrase += ".-- "; break;
                    case 'X': phrase += "-..- "; break;
                    case 'Y': phrase += "-.-- "; break;
                    case 'Z': phrase += "--.. "; break;
                    case ' ': phrase += "/ "; break;
                    case '0': phrase += "----- "; break;
                    case '1': phrase += ".---- "; break;
                    case '2': phrase += "..--- "; break;
                    case '3': phrase += "...-- "; break;
                    case '4': phrase += "....- "; break;
                    case '5': phrase += "..... "; break;
                    case '6': phrase += "-.... "; break;
                    case '7': phrase += "--... "; break;
                    case '8': phrase += "---.. "; break;
                    case '9': phrase += "----. "; break;
                    case '.': phrase += ".-.-.- "; break;
                    case ',': phrase += "--..-- "; break;
                    case '?': phrase += "..--.. "; break;
                    case '!': phrase += "-.-.-- "; break;
                    case ';': phrase += "-.-.-. "; break;
                    case '*': phrase += "-..- "; break;
                    case ':': phrase += "---... "; break;
                    case '/': phrase += "-..-. "; break;
                    case '+': phrase += ".-.-. "; break;
                    case '-': phrase += "-....- "; break;
                    case '=': phrase += "-...- "; break;
                    case '(': phrase += "-.--.- "; break;
                    case ')': phrase += "-.--.- "; break;
                    case '@': phrase += ".--.-. "; break;
                    case '"': phrase += ".-..-. "; break;
                    case '&': phrase += ".-... "; break;
                    case '_': phrase += "..--.- "; break;
                    case '$': phrase += "...-..- "; break;
                    case 'É': phrase += "..-.. "; break;
                    case 'À': phrase += ".--.- "; break;
                    case 'È': phrase += ".-..- "; break;
                    default: Console.ForegroundColor = ConsoleColor.Red; Console.Write($"Le charactère {lettre} à été ignoré.\n"); Console.ResetColor(); break;

                }
            }


            

            return phrase;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                
                Console.Write("Bienvenue, veuillez choisir une de ces 3 option: \n\n1. Chiffrement en Morse\n2. A venir\n3. A venir \n4. Quitter \nVotre choix: ");
                string choix = Console.ReadLine();

                if (choix == "1")
                {
                    Console.Write($"\n{CodeToMorse()}\n");
                }
                else if(choix == "4")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Write("Veuillez choisir 1, 2 ou 3\n");
                }
            }
        }

        static string CodeToMorse()
        {
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
                    default: Console.Write($"Le charactère {lettre} à été ignoré.\n"); break;

                }
            }

            return phrase;

        }
    }
}

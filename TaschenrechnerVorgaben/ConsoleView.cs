using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TaschenrechnerVorgaben
{

    internal class ConsoleView
    {
        private RechnerModel model;

        public ConsoleView(RechnerModel model)
        {
            this.model = model;
        }
    
 


        public void GibResultatAus(string operation)
        {
            switch (operation)
            {
                case "+":
                    Console.WriteLine("Die Summe ist: {0}", model.Resultat);
                    break;

                case "-":
                    Console.WriteLine("Die Differenz ist: {0}", model.Resultat);
                    break;

                case "/":
                    Console.WriteLine("Der Wert des Quotienten ist: {0}", model.Resultat);
                    break;

                case "*":
                    Console.WriteLine("Das Produkt ist: {0}", model.Resultat);
                    break;

                default:
                    Console.WriteLine("Du hast eine ungültige Auswahl der Operation getroffen.");
                    break;
            }
        }
        public string HoleZahlVonBenutzer()
        {
            Console.WriteLine("Bitte gebe die Zahl für die Berechnung ein:");
            return Console.ReadLine();
        }

        public string HoleOperatorVonBenutzer()
        {
            Console.WriteLine("Was ist die der Operator (+, -, *, /)?");
            return Console.ReadLine();
        }

        public void WarteAufEndeVonBenutzer()
        {
            Console.WriteLine("Um Das Programm zu schliessen, klicke Return");
            Console.ReadLine();
        }
    }
}

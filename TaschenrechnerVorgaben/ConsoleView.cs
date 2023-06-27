using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TaschenrechnerVorgaben
{

    public class ConsoleView
    {
        private RechnerModel model;

        public ConsoleView(RechnerModel model)
        {
            this.model = model;
            BenutzerWillBeenden = false;
        }
    
 
        public bool BenutzerWillBeenden { get; private set; }

        public void HoleEingabenFuerErsteBerechnungVomBenutzer()
        {
            model.ErsteZahl = HoleZahlVonBenutzer();
            model.Operation = HoleOperatorVonBenutzer();
            model.ZweiteZahl = HoleZahlVonBenutzer();
        }

        public void HoleEingabenFuerFortlaufendeBerechnung()
        {
            string? eingabe = HoleNaechsteAktionVomBenutzer();

            if (eingabe == "Fertig")
            {
                BenutzerWillBeenden = true;
            }
            else
            {
                model.ErsteZahl = model.Resultat;
                model.ZweiteZahl = Convert.ToDouble(eingabe);
            }
        }

        private string? HoleNaechsteAktionVomBenutzer()
        {
            Console.Write("Bitte gib eine weitere Zahl ein (Fertig zum Beenden): ");
            return Console.ReadLine();
        }

        public void GibResultatAus()
        {
            switch (model.Operation)
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

      

       

        public void HoleEingabenVomBenutzer() 
        {
            model.ErsteZahl = HoleZahlVonBenutzer();
            model.Operation = HoleOperatorVonBenutzer();
            model.ZweiteZahl = HoleZahlVonBenutzer();
        }
        public double HoleZahlVonBenutzer()
        {
            Console.WriteLine("Bitte gebe die Zahl für die Berechnung ein (FERTIG zum beenden):");
            string? eingabe = Console.ReadLine();


            return Convert.ToDouble(eingabe);
        
        }

        private string? HoleOperatorVonBenutzer()
        {
            Console.WriteLine("Was ist die der Operator (+, -, *, /)?");
            return Console.ReadLine();
        }

      
    }
}

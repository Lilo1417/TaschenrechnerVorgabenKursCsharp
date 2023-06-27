using System;
using System.Transactions;
using TaschenrechnerVorgaben;

namespace Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
           
            RechnerModel model = new RechnerModel();
            ConsoleView view = new ConsoleView(model);
            string ersteZahlAlsString = view.HoleZahlVonBenutzer();
            string operation = view.HoleOperatorVonBenutzer();
            string zweiteZahlAlsString = view.HoleZahlVonBenutzer();

            // Wandel Text in Gleikommazahlen
            // TODO: Auslagern in Methode, wenn Struktur umfangreicher geworden ist.
            double ersteZahl = Convert.ToDouble(ersteZahlAlsString);
            double zweiteZahl = Convert.ToDouble(zweiteZahlAlsString);

            // Berechnung ausführen
            model.Berechne(ersteZahl, zweiteZahl, operation);

            // Ausgabe
            view.GibResultatAus(operation);
            view.WarteAufEndeVonBenutzer();
        }


    }
}

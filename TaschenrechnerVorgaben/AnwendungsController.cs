using System;


namespace TaschenrechnerVorgaben
{


	public class AnwendungsController
	{

        private ConsoleView view;
        private RechnerModel model;

        public AnwendungsController(ConsoleView view, RechnerModel model)
		{
			this.view = view;
			this.model = model;
	    }

		public void Ausfueren() 
		{
            string? ersteZahlAlsString = view.HoleZahlVonBenutzer();
            string? operation = view.HoleOperatorVonBenutzer();
            string? zweiteZahlAlsString = view.HoleZahlVonBenutzer();

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
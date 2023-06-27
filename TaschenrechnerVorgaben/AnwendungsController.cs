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
            double ersteZahl= view.HoleZahlVonBenutzer();
            string? operation = view.HoleOperatorVonBenutzer();
            double zweiteZahl= view.HoleZahlVonBenutzer();

            // Berechnung ausführen
            model.Berechne(ersteZahl, zweiteZahl, operation);

            // Ausgabe
            view.GibResultatAus();
            view.WarteAufEndeVonBenutzer();
        }

	}

}
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
            view.HoleEingabenVomBenutzer();
            

            model.Berechne();

            // Ausgabe
            view.GibResultatAus();
            view.WarteAufEndeVonBenutzer();
        }

	}

}
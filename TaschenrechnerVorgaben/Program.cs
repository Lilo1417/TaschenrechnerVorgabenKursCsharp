using System;
using System.Transactions;
using TaschenrechnerVorgaben;

namespace TaschenrechnerVorgaben
{
    class Program
    {
        static void Main(string[] args)
        {
           
            RechnerModel model = new RechnerModel();
            ConsoleView view = new ConsoleView(model);
            AnwendungsController controller = new AnwendungsController(view, model);

            controller.Ausfueren();
        }


    }
}

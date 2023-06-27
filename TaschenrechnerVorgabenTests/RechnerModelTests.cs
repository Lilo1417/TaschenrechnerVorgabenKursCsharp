using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaschenrechnerVorgaben;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaschenrechnerVorgaben.Tests
{
    [TestClass()]
    public class RechnerModelTests
    {
        [TestMethod()]
        public void BerechneDivisionDurchNullERgibtUnendlich()
        {
            RechnerModel model = new RechnerModel();

            model.Operation = "/";
            model.ErsteZahl = 10;
            model.ZweiteZahl = 0;

            model.Berechne();

            Assert.AreEqual(Double.PositiveInfinity, model.Resultat);
        }
    }
}
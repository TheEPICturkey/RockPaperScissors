using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockDeckWins;


namespace RPSTesting
{
    [TestClass]
    public class RockTesting
    {
        [TestMethod]
        public void DoWeGetRock()
        {
            RPSCode newThing = new RPSCode();
            Assert.AreEqual(true, newThing.Match());
        }
    }

}
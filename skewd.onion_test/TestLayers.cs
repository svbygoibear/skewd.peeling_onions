using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using skewd.peeling_onions;

namespace skewd.onion_test {
    [TestClass]
    public class TestLayers {
        [TestMethod]
        public void NumberOfLayers() {
            var numberOfLayers = new Onion(new Onion(new Onion(new Onion()))).NumberOfInnerLayers;
            var didItWork = false;

            if (numberOfLayers == 3)
                didItWork = true;

            Assert.AreEqual(true, didItWork); //assert if result is as expected
        }
    }
}

using HundredPrisonersLib.Classes;
using HundredPrisonersRiddle;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace UnitTestHundredPrisonersRiddle
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFindYourBox()
        {
            Factory f = new Factory();
            IPrisoner p = f.GetPrisoner(7, 50);
            IRoom r = f.GetRoom();
            IBox b = p.FindYourBox(r);
            Assert.AreEqual(b.Inside, 7);
        }

        [TestMethod]
        public void TestRoomBoxUniqueness()
        {
            int[] inside = new int[100];
            int[] outside = new int[100];
            Factory f = new Factory();
            IRoom r = f.GetRoom();
            IBox b;

            for (int i = 1; i < 101; i++)
            {
                b = r.GetaBox(i);
                inside[i-1] = b.Inside;
                outside[i-1] = b.Outside;
            }

            bool isUniqueInside = inside.Distinct().Count() == inside.Count();
            bool isUniqueOutside = outside.Distinct().Count() == outside.Count();

            Assert.IsTrue(isUniqueInside && isUniqueOutside);
        }

        [TestMethod]
        public void TestRoomBoxValues()
        {
            Factory f = new Factory();
            IRoom r = f.GetRoom();
            IBox b;

            for (int i = 1; i < 101; i++)
            {
                b = r.GetaBox(i);

                if (b.Inside < 1 || b.Inside > 100)
                    Assert.Fail();

                if (b.Outside < 1 || b.Outside > 100)
                    Assert.Fail();
            }
        }
    }
}

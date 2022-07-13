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
            IPisoner p = new Pisoner(7);
            IRoom r = new Room();
            IBox b = p.FindYourBox(r, 100);
            Assert.AreEqual(b.Inside, 7);
        }

        [TestMethod]
        public void TestRoomBoxUniqueness()
        {
            int[] inside = new int[100];
            int[] outside = new int[100];
            IRoom r = new Room();
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
            IRoom r = new Room();
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

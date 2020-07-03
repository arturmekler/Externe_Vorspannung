using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Externe_Vorspannung;
using Externe_Vorspannung.Model;

namespace App.Tests
{
    class SumForcesTest
    {
        [Test]
        public void SumForcesCheck()
        {

            Dictionary<int, Cable> cables = new Dictionary<int, Cable>();

            Cable cable1 = new Cable();
            Cable cable2 = new Cable();
            List<Point> points1 = new List<Point>();
            List<Point> points2 = new List<Point>();
            points1.Add(new Point()
            {
                X = 0,
                Y = 0,
            });
            points1.Add(new Point()
            {
                X = 20,
                Y = 2,
            });
            points1.Add(new Point()
            {
                X = 40,
                Y = 0,
            });
            points2.Add(new Point()
            {
                X = 20,
                Y = 2,
            });
            points2.Add(new Point()
            {
                X = 30,
                Y = 0,
            });
            points2.Add(new Point()
            {
                X = 40,
                Y = 2,
            });

            cable1.cableOrdinates = points1;
            cable1.cableBeginActive = true;
            cable1.cableEndActive = false;
            cable1.prestressForce = 1233;
            cable1.quantityCable = 1;
            cable1.nrCable = 1;

            cable2.cableOrdinates = points2;
            cable2.cableBeginActive = true;
            cable2.cableEndActive = false;
            cable2.prestressForce = 2233;
            cable2.quantityCable = 1;
            cable2.nrCable = 2;

            cables.Add(1, cable1);
            cables.Add(2, cable2);

            var sumForcesResult = SumForcesManager.SumForces(cables);
            var asd = "asd";

            var sumForcesExpect = new List<Force>();
            sumForcesExpect.Add(new Force()
            {
                X = 1226.8808555289165,
                Y = 122.68808555289166,
                Z = 0,
                point = new Point()
                {
                    X = 0,
                    Y = 0,
                    Z = 0,
                }
            });
            sumForcesExpect.Add(new Force()
            {
                X = 2189.6366488178251,
                Y = -683.30350086934823,
                Z = 0,
                point = new Point()
                {
                    X = 20,
                    Y = 0,
                    Z = 0,
                }
            });
            sumForcesExpect.Add(new Force()
            {
                X = 0,
                Y = 875.85465952712991,
                Z = 0,
                point = new Point()
                {
                    X = 30,
                    Y = 0,
                    Z = 0,
                }
            });
            sumForcesExpect.Add(new Force()
            {
                X = -3416.5175043467416,
                Y = -315.23924421067329,
                Z = 0,
                point = new Point()
                {
                    X = 40,
                    Y = 0,
                    Z = 0,
                }
            });

            Assert.AreEqual(sumForcesExpect[1].Y, sumForcesResult[1].Y);
            Assert.AreEqual(sumForcesExpect[2].Y, sumForcesResult[2].Y);
            Assert.AreEqual(sumForcesExpect[3].Y, sumForcesResult[3].Y);

        }
    }
}

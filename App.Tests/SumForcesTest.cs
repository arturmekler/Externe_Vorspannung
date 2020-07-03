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

            cable1.cableOrdinates.ordinates = points1;
            cable2.cableOrdinates.ordinates = points2;
            cables.Add(1, cable1);
            cables.Add(2, cable2);

            SumForcesManager.SummForces(cables);
            
        }
    }
}

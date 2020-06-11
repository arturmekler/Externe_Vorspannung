using Externe_Vorspannung.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Externe_Vorspannung
{
    public class SumForcesManager
    {
        public static List<Force> SummForces(Dictionary<int, Cable> cables)   // sums the forces from the cables
        {
            List<Force> sumForcesNew = new List<Force>();
            List<Point> globalX = new List<Point>();


            foreach (var cable in cables)
            {
                var asd = cable.Value.cableOrdinates.ordinates;


            }


            //double[,] sumForces;

            //HashSet<double> globalOrdinatesX;
            //globalOrdinatesX = new HashSet<double>();
            //List<double> ordinatesX;
            //Dictionary<double, double> sumForcesX;
            //Dictionary<double, double> sumForcesY;


            //for (int i = 1; i <= cables.Count(); i++)
            //{
            //    for (int j = 0; j < cables[i].cableOrdinates.ordinates.Count(); j++)
            //    {
            //        globalOrdinatesX.Add(cables[i].cableOrdinates.ordinates[j].X);
            //    }
            //}
            //ordinatesX = globalOrdinatesX.ToList<double>();

            //sumForces = new double[ordinatesX.Count(), 3];
            //sumForcesX = new Dictionary<double, double>();
            //sumForcesY = new Dictionary<double, double>();


            //// making dictionary
            //for (int i = 0; i < ordinatesX.Count(); i++)
            //{
            //    sumForcesX.Add(ordinatesX[i], 0);
            //    sumForcesY.Add(ordinatesX[i], 0);
            //}

            //for (int i = 1; i <= cables.Count(); i++) // loop through cables
            //{
            //    for (int j = 0; j < cables[i].cableOrdinates.ordinates.Count(); j++) // loop through "X" ordinate
            //    {
            //        for (int k = 0; k < ordinatesX.Count(); k++) // loop looking for a common "X" ordinate
            //        {
            //            if (cables[i].cableOrdinates.ordinates[k].X == ordinatesX[k])
            //            {
            //                ordinatesX.Sort();
            //                sumForcesX[ordinatesX[k]] = cables[i].Forces()[j].X + sumForcesX[ordinatesX[k]];
            //                sumForcesY[ordinatesX[k]] = cables[i].Forces()[j].Y + sumForcesY[ordinatesX[k]];
            //            }
            //        }
            //    }
            //}


            //for (int i = 0; i < ordinatesX.Count; i++) // loop writes values into one array
            //{
            //    sumForces[i, 0] = sumForcesX[ordinatesX[i]];
            //    sumForces[i, 1] = sumForcesY[ordinatesX[i]];
            //    sumForces[i, 2] = ordinatesX[i];
            //}

            return sumForcesNew;
        }
    }
}

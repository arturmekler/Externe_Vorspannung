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
        public static List<Force> SumForces(Dictionary<int, Cable> cables)   // sums the forces from the cables
        {
            List<Force> sumForcesNew = new List<Force>();

            foreach (var cable in cables)
            {
                sumForcesNew.AddRange(cable.Value.Forces());
            }

            var test = sumForcesNew
                .OrderBy(qw => qw.point.X)
                .GroupBy(p => p.point.X)
                .Select(pw => new Force()
                {
                    X = pw.Sum(qw => qw.X),
                    Y = pw.Sum(qw => qw.Y),
                    Z = pw.Sum(qw => qw.Z),
                    point = pw.Select(pww => pww.point).FirstOrDefault()
                })
                .ToList();
        
            return test;
        }
    }
}

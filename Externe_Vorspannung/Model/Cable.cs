using Externe_Vorspannung.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Externe_Vorspannung
{
    public class Cable
    {
        public string systemName;
        public int nrCable;
        public int quantityCable;
        public double prestressForce;
        public double friction;
        public bool cableBeginActive;
        public bool cableEndActive;
        public double[,] cableOrdinates;
        private double dfi1;
        private double dfi2;
        public Ordinates cableOrdinatesNew { get; set; }


        public Cable()
        {
            systemName = "";
            nrCable = 0;
            quantityCable = 0;
            prestressForce = 0;
            friction = 0;
            cableBeginActive = true;
            cableEndActive = true;

            cableOrdinates = new double[2,2];
            cableOrdinatesNew = new Ordinates();
        }

        public Cable(string systemName, int nrCable, int quantityCable, double prestressForce, double friction,
            bool cableBeginActive, bool cableEndActive)
        {
            this.systemName = systemName;
            this.nrCable = nrCable;
            this.quantityCable = quantityCable;
            this.prestressForce = prestressForce;
            this.friction = friction;
            this.cableBeginActive = cableBeginActive;
            this.cableEndActive = cableEndActive;
            cableOrdinates = new double[2, 2];
        }

        public double[,] Forces()
        {
            int oR;
            double cos;
            double sin;
            double cos1;
            double sin1;
            double cos2;
            double sin2;
            double forcePx;
            double forcePy;
            double forcePx1;
            double forcePy1;
            double forcePx2;
            double forcePy2;
            double prestressForceNew;
            double[,] forces;

            oR = cableOrdinates.GetLength(0);        //last force's ordinate

            forces = new double[oR, 3];

            if (cableBeginActive && cableEndActive)
            {
                ActiveBeginEndCableForce();
                return forces;
            }

            else if (!cableBeginActive && cableEndActive)
            {
                ActiveEndCableForce();
                return forces;
            }

            else if (cableBeginActive && !cableEndActive)
            {
                ActiveBeginCableForce();
                return forces;
            }
            else
            {

                return null;
            }

            void ActiveBeginCableForce()
            {
                // calculate forces in the beginning

                cos = (cableOrdinatesNew.ordinates.ElementAt(1).X - cableOrdinatesNew.ordinates.ElementAt(0).X)
                         / Math.Sqrt(Math.Pow((cableOrdinatesNew.ordinates.ElementAt(1).X - cableOrdinatesNew.ordinates.ElementAt(0).X), 2)
                         + Math.Pow((cableOrdinatesNew.ordinates.ElementAt(1).Y - cableOrdinatesNew.ordinates.ElementAt(0).Y), 2));

                sin = (cableOrdinatesNew.ordinates.ElementAt(1).Y - cableOrdinatesNew.ordinates.ElementAt(0).Y)
                         / Math.Sqrt(Math.Pow((cableOrdinatesNew.ordinates.ElementAt(1).X - cableOrdinatesNew.ordinates.ElementAt(0).X), 2) 
                         + Math.Pow((cableOrdinatesNew.ordinates.ElementAt(1).Y - cableOrdinatesNew.ordinates.ElementAt(0).Y), 2));

                forcePx = quantityCable * prestressForce * cos;
                forcePy = quantityCable * prestressForce * sin;

                forces[0, 0] = forcePx;
                forces[0, 1] = forcePy;
                forces[0, 2] = cableOrdinates[0, 0];

                // calculate forces in the middle
                prestressForceNew = quantityCable * prestressForce;

                for (int i = 1; i < oR - 1; i++)
                {
                    cos1 = (cableOrdinates[i, 0] - cableOrdinates[i - 1, 0])
                        / Math.Sqrt(Math.Pow((cableOrdinates[i, 0] - cableOrdinates[i - 1, 0]), 2) + Math.Pow((cableOrdinates[i, 1] - cableOrdinates[i - 1, 1]), 2));

                    sin1 = (cableOrdinates[i, 1] - cableOrdinates[i - 1, 1])
                        / Math.Sqrt(Math.Pow((cableOrdinates[i, 0] - cableOrdinates[i - 1, 0]), 2) + Math.Pow((cableOrdinates[i, 1] - cableOrdinates[i - 1, 1]), 2));

                    cos2 = (cableOrdinates[i + 1, 0] - cableOrdinates[i, 0])
                        / Math.Sqrt(Math.Pow((cableOrdinates[i + 1, 0] - cableOrdinates[i, 0]), 2) + Math.Pow((cableOrdinates[i + 1, 1] - cableOrdinates[i, 1]), 2));

                    sin2 = (cableOrdinates[i + 1, 1] - cableOrdinates[i, 1])
                        / Math.Sqrt(Math.Pow((cableOrdinates[i + 1, 0] - cableOrdinates[i, 0]), 2) + Math.Pow((cableOrdinates[i + 1, 1] - cableOrdinates[i, 1]), 2));

                    dfi1 = Math.Acos(cos1);
                    dfi2 = Math.Acos(cos2);

                    prestressForceNew = prestressForceNew - prestressForceNew * (1 - Math.Exp(-friction * (dfi1 + dfi2)));

                    forcePx1 = prestressForceNew * (1 - Math.Exp(-friction * dfi1)) * cos1;
                    forcePy1 = -prestressForceNew * sin1;

                    forcePx2 = prestressForceNew * (1 - Math.Exp(-friction * dfi2)) * cos2;
                    forcePy2 = prestressForceNew * sin2;

                    forces[i, 0] = -forcePx1 - forcePx2;
                    forces[i, 1] = forcePy1 + forcePy2;
                    forces[i, 2] = cableOrdinates[i, 0];
                }

                // calculate forces in the end
                cos = (cableOrdinates[oR - 1, 0] - cableOrdinates[oR - 2, 0])
           / Math.Sqrt(Math.Pow((cableOrdinates[oR - 1, 0] - cableOrdinates[oR - 2, 0]), 2) + Math.Pow((cableOrdinates[oR - 1, 1] - cableOrdinates[oR - 2, 1]), 2));

                sin = (cableOrdinates[oR - 1, 1] - cableOrdinates[oR - 2, 1])
                   / Math.Sqrt(Math.Pow((cableOrdinates[oR - 1, 0] - cableOrdinates[oR - 2, 0]), 2) + Math.Pow((cableOrdinates[oR - 1, 1] - cableOrdinates[oR - 2, 1]), 2));

                forcePx = prestressForceNew * cos;
                forcePy = prestressForceNew * sin;

                forces[oR - 1, 0] = -forcePx;
                forces[oR - 1, 1] = -forcePy;
                forces[oR - 1, 2] = cableOrdinates[oR - 1, 0];
            }

            void ActiveEndCableForce()
            {
                // calculate forces in the end

                cos = (cableOrdinates[oR - 1, 0] - cableOrdinates[oR - 2, 0])
               / Math.Sqrt(Math.Pow((cableOrdinates[oR - 1, 0] - cableOrdinates[oR - 2, 0]), 2) + Math.Pow((cableOrdinates[oR - 1, 1] - cableOrdinates[oR - 2, 1]), 2));

                sin = (cableOrdinates[oR - 1, 1] - cableOrdinates[oR - 2, 1])
                   / Math.Sqrt(Math.Pow((cableOrdinates[oR - 1, 0] - cableOrdinates[oR - 2, 0]), 2) + Math.Pow((cableOrdinates[oR - 1, 1] - cableOrdinates[oR - 2, 1]), 2));

                forcePx = quantityCable * prestressForce * cos;
                forcePy = quantityCable * prestressForce * sin;

                forces[oR - 1, 0] = -forcePx;
                forces[oR - 1, 1] = -forcePy;
                forces[oR - 1, 2] = cableOrdinates[oR - 1, 0];

                // calculate forces in the middle

                prestressForceNew = quantityCable * prestressForce;

                for (int i = oR - 2; i >= 1; i--)
                {
                    cos1 = (cableOrdinates[i, 0] - cableOrdinates[i - 1, 0])
                        / Math.Sqrt(Math.Pow((cableOrdinates[i, 0] - cableOrdinates[i - 1, 0]), 2) + Math.Pow((cableOrdinates[i, 1] - cableOrdinates[i - 1, 1]), 2));

                    sin1 = (cableOrdinates[i, 1] - cableOrdinates[i - 1, 1])
                        / Math.Sqrt(Math.Pow((cableOrdinates[i, 0] - cableOrdinates[i - 1, 0]), 2) + Math.Pow((cableOrdinates[i, 1] - cableOrdinates[i - 1, 1]), 2));

                    cos2 = (cableOrdinates[i + 1, 0] - cableOrdinates[i, 0])
                        / Math.Sqrt(Math.Pow((cableOrdinates[i + 1, 0] - cableOrdinates[i, 0]), 2) + Math.Pow((cableOrdinates[i + 1, 1] - cableOrdinates[i, 1]), 2));

                    sin2 = (cableOrdinates[i + 1, 1] - cableOrdinates[i, 1])
                        / Math.Sqrt(Math.Pow((cableOrdinates[i + 1, 0] - cableOrdinates[i, 0]), 2) + Math.Pow((cableOrdinates[i + 1, 1] - cableOrdinates[i, 1]), 2));

                    dfi1 = Math.Acos(cos1);
                    dfi2 = Math.Acos(cos2);

                    prestressForceNew = prestressForceNew - prestressForceNew * (1 - Math.Exp(-friction * (dfi1 + dfi2)));

                    forcePx1 = prestressForceNew * (1 - Math.Exp(-friction * dfi1)) * cos1;
                    forcePy1 = -prestressForceNew * sin1;

                    forcePx2 = prestressForceNew * (1 - Math.Exp(-friction * dfi2)) * cos2;
                    forcePy2 = prestressForceNew * sin2;

                    forces[i, 0] = forcePx1 + forcePx2;
                    forces[i, 1] = forcePy1 + forcePy2;
                    forces[i, 2] = cableOrdinates[i, 0];
                }

                // calculate forces in the begin

                cos = (cableOrdinates[1, 0] - cableOrdinates[0, 0])
               / Math.Sqrt(Math.Pow((cableOrdinates[1, 0] - cableOrdinates[0, 0]), 2) + Math.Pow((cableOrdinates[1, 1] - cableOrdinates[0, 1]), 2));

                sin = (cableOrdinates[1, 1] - cableOrdinates[0, 1])
                   / Math.Sqrt(Math.Pow((cableOrdinates[1, 0] - cableOrdinates[0, 0]), 2) + Math.Pow((cableOrdinates[1, 1] - cableOrdinates[0, 1]), 2));

                forcePx = prestressForceNew * cos;
                forcePy = prestressForceNew * sin;

                forces[0, 0] = forcePx;
                forces[0, 1] = forcePy;
                forces[0, 2] = cableOrdinates[0, 0];
            }

            void ActiveBeginEndCableForce()
            {
                // calculate forces in the beginning

                cos = (cableOrdinates[1, 0] - cableOrdinates[0, 0])
                   / Math.Sqrt(Math.Pow((cableOrdinates[1, 0] - cableOrdinates[0, 0]), 2) + Math.Pow((cableOrdinates[1, 1] - cableOrdinates[0, 1]), 2));

                sin = (cableOrdinates[1, 1] - cableOrdinates[0, 1])
                   / Math.Sqrt(Math.Pow((cableOrdinates[1, 0] - cableOrdinates[0, 0]), 2) + Math.Pow((cableOrdinates[1, 1] - cableOrdinates[0, 1]), 2));

                forcePx = quantityCable * prestressForce * cos;
                forcePy = quantityCable * prestressForce * sin;

                forces[0, 0] = forcePx;
                forces[0, 1] = forcePy;
                forces[0, 2] = cableOrdinates[0, 0];

                // calculate forces in the middle ONE
                prestressForceNew = quantityCable * prestressForce;

                for (int i = 1; i < oR / 2; i++)
                {
                    cos1 = (cableOrdinates[i, 0] - cableOrdinates[i - 1, 0])
                        / Math.Sqrt(Math.Pow((cableOrdinates[i, 0] - cableOrdinates[i - 1, 0]), 2) + Math.Pow((cableOrdinates[i, 1] - cableOrdinates[i - 1, 1]), 2));

                    sin1 = (cableOrdinates[i, 1] - cableOrdinates[i - 1, 1])
                        / Math.Sqrt(Math.Pow((cableOrdinates[i, 0] - cableOrdinates[i - 1, 0]), 2) + Math.Pow((cableOrdinates[i, 1] - cableOrdinates[i - 1, 1]), 2));

                    cos2 = (cableOrdinates[i + 1, 0] - cableOrdinates[i, 0])
                        / Math.Sqrt(Math.Pow((cableOrdinates[i + 1, 0] - cableOrdinates[i, 0]), 2) + Math.Pow((cableOrdinates[i + 1, 1] - cableOrdinates[i, 1]), 2));

                    sin2 = (cableOrdinates[i + 1, 1] - cableOrdinates[i, 1])
                        / Math.Sqrt(Math.Pow((cableOrdinates[i + 1, 0] - cableOrdinates[i, 0]), 2) + Math.Pow((cableOrdinates[i + 1, 1] - cableOrdinates[i, 1]), 2));

                    dfi1 = Math.Acos(cos1);
                    dfi2 = Math.Acos(cos2);

                    prestressForceNew = prestressForceNew - prestressForceNew * (1 - Math.Exp(-friction * (dfi1 + dfi2)));

                    forcePx1 = prestressForceNew * (1 - Math.Exp(-friction * dfi1)) * cos1;
                    forcePy1 = -prestressForceNew * sin1;

                    forcePx2 = prestressForceNew * (1 - Math.Exp(-friction * dfi2)) * cos2;
                    forcePy2 = prestressForceNew * sin2;


                    forces[i, 0] = -forcePx1 - forcePx2;
                    forces[i, 1] = forcePy1 + forcePy2;
                    forces[i, 2] = cableOrdinates[i, 0];
                }


                // calculate forces in the end

                cos = (cableOrdinates[oR - 1, 0] - cableOrdinates[oR - 2, 0])
               / Math.Sqrt(Math.Pow((cableOrdinates[oR - 1, 0] - cableOrdinates[oR - 2, 0]), 2) + Math.Pow((cableOrdinates[oR - 1, 1] - cableOrdinates[oR - 2, 1]), 2));

                sin = (cableOrdinates[oR - 1, 1] - cableOrdinates[oR - 2, 1])
                   / Math.Sqrt(Math.Pow((cableOrdinates[oR - 1, 0] - cableOrdinates[oR - 2, 0]), 2) + Math.Pow((cableOrdinates[oR - 1, 1] - cableOrdinates[oR - 2, 1]), 2));

                forcePx = quantityCable * prestressForce * cos;
                forcePy = quantityCable * prestressForce * sin;

                forces[oR - 1, 0] = -forcePx;
                forces[oR - 1, 1] = -forcePy;
                forces[oR - 1, 2] = cableOrdinates[oR - 1, 0];

                // calculate forces in the middle

                prestressForceNew = quantityCable * prestressForce;

                for (int i = oR - 2; i >= oR / 2; i--)
                {
                    cos1 = (cableOrdinates[i, 0] - cableOrdinates[i - 1, 0])
                        / Math.Sqrt(Math.Pow((cableOrdinates[i, 0] - cableOrdinates[i - 1, 0]), 2) + Math.Pow((cableOrdinates[i, 1] - cableOrdinates[i - 1, 1]), 2));

                    sin1 = (cableOrdinates[i, 1] - cableOrdinates[i - 1, 1])
                        / Math.Sqrt(Math.Pow((cableOrdinates[i, 0] - cableOrdinates[i - 1, 0]), 2) + Math.Pow((cableOrdinates[i, 1] - cableOrdinates[i - 1, 1]), 2));

                    cos2 = (cableOrdinates[i + 1, 0] - cableOrdinates[i, 0])
                        / Math.Sqrt(Math.Pow((cableOrdinates[i + 1, 0] - cableOrdinates[i, 0]), 2) + Math.Pow((cableOrdinates[i + 1, 1] - cableOrdinates[i, 1]), 2));

                    sin2 = (cableOrdinates[i + 1, 1] - cableOrdinates[i, 1])
                        / Math.Sqrt(Math.Pow((cableOrdinates[i + 1, 0] - cableOrdinates[i, 0]), 2) + Math.Pow((cableOrdinates[i + 1, 1] - cableOrdinates[i, 1]), 2));

                    dfi1 = Math.Acos(cos1);
                    dfi2 = Math.Acos(cos2);

                    prestressForceNew = prestressForceNew - prestressForceNew * (1 - Math.Exp(-friction * (dfi1 + dfi2)));

                    forcePx1 = prestressForceNew * (1 - Math.Exp(-friction * dfi1)) * cos1;
                    forcePy1 = -prestressForceNew * sin1;

                    forcePx2 = prestressForceNew * (1 - Math.Exp(-friction * dfi2)) * cos2;
                    forcePy2 = prestressForceNew * sin2;

                    forces[i, 0] = forcePx1 + forcePx2;
                    forces[i, 1] = forcePy1 + forcePy2;
                    forces[i, 2] = cableOrdinates[i, 0];
                }

                if (oR % 2 != 0)
                {
                    forces[Convert.ToInt32(oR / 2 - 0.5), 0] = 0;
                }
                else
                {

                };
            }

        }

    }
}

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
        public Ordinates cableOrdinates { get; set; }


        public Cable()
        {
            systemName = "";
            nrCable = 0;
            quantityCable = 0;
            prestressForce = 0;
            friction = 0;
            cableBeginActive = true;
            cableEndActive = true;
            cableOrdinates = new Ordinates();
        }

        public Cable(string systemName, int nrCable, int quantityCable, double prestressForce, double friction,
            bool cableBeginActive, bool cableEndActive)
        {
            this.systemName = systemName;
            this.nrCable = nrCable;
            this.prestressForce = prestressForce;
            this.friction = friction;
            this.cableBeginActive = cableBeginActive;
            this.cableEndActive = cableEndActive;
            this.quantityCable = quantityCable;

            cableOrdinates = new Ordinates();
        }
        

        public List<Force> Forces()
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
            List<Force> forces = new List<Force>();
            oR = cableOrdinates.ordinates.Count();

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

                cos = (cableOrdinates.ordinates.ElementAt(1).X - cableOrdinates.ordinates.ElementAt(0).X)
                         / Math.Sqrt(Math.Pow((cableOrdinates.ordinates.ElementAt(1).X - cableOrdinates.ordinates.ElementAt(0).X), 2)
                         + Math.Pow((cableOrdinates.ordinates.ElementAt(1).Y - cableOrdinates.ordinates.ElementAt(0).Y), 2));

                sin = (cableOrdinates.ordinates.ElementAt(1).Y - cableOrdinates.ordinates.ElementAt(0).Y)
                         / Math.Sqrt(Math.Pow((cableOrdinates.ordinates.ElementAt(1).X - cableOrdinates.ordinates.ElementAt(0).X), 2) 
                         + Math.Pow((cableOrdinates.ordinates.ElementAt(1).Y - cableOrdinates.ordinates.ElementAt(0).Y), 2));

                forcePx = quantityCable * prestressForce * cos;
                forcePy = quantityCable * prestressForce * sin;

                forces.Add(new Force()
                {
                    X = forcePx,
                    Y = forcePy,
                    point = new Point()
                    {
                        X = cableOrdinates.ordinates.ElementAt(0).X
                    }
                });

                // calculate forces in the middle
                prestressForceNew = quantityCable * prestressForce;

                for (int i = 1; i < oR - 1; i++)
                {
                    cos1 = (cableOrdinates.ordinates.ElementAt(i).X - cableOrdinates.ordinates.ElementAt(i - 1).X)
                        / Math.Sqrt(Math.Pow((cableOrdinates.ordinates.ElementAt(i).X - cableOrdinates.ordinates.ElementAt(i - 1).X), 2) + Math.Pow((cableOrdinates.ordinates.ElementAt(i).Y - cableOrdinates.ordinates.ElementAt(i - 1).Y), 2));

                    sin1 = (cableOrdinates.ordinates.ElementAt(i).Y - cableOrdinates.ordinates.ElementAt(i - 1).Y)
                        / Math.Sqrt(Math.Pow((cableOrdinates.ordinates.ElementAt(i).X - cableOrdinates.ordinates.ElementAt(i - 1).X), 2) + Math.Pow((cableOrdinates.ordinates.ElementAt(i).Y - cableOrdinates.ordinates.ElementAt(i - 1).Y), 2));

                    cos2 = (cableOrdinates.ordinates.ElementAt(i + 1).X - cableOrdinates.ordinates.ElementAt(i).X)
                        / Math.Sqrt(Math.Pow((cableOrdinates.ordinates.ElementAt(i + 1).X - cableOrdinates.ordinates.ElementAt(i).X), 2) + Math.Pow((cableOrdinates.ordinates.ElementAt(i + 1).Y - cableOrdinates.ordinates.ElementAt(i).Y), 2));

                    sin2 = (cableOrdinates.ordinates.ElementAt(i + 1).Y - cableOrdinates.ordinates.ElementAt(i).Y)
                        / Math.Sqrt(Math.Pow((cableOrdinates.ordinates.ElementAt(i + 1).X - cableOrdinates.ordinates.ElementAt(i).X), 2) + Math.Pow((cableOrdinates.ordinates.ElementAt(i + 1).Y - cableOrdinates.ordinates.ElementAt(i).Y), 2));

                    var dfi1 = Math.Acos(cos1);
                    var dfi2 = Math.Acos(cos2);

                    prestressForceNew = prestressForceNew - prestressForceNew * (1 - Math.Exp(-friction * (dfi1 + dfi2)));

                    forcePx1 = prestressForceNew * (1 - Math.Exp(-friction * dfi1)) * cos1;
                    forcePy1 = -prestressForceNew * sin1;

                    forcePx2 = prestressForceNew * (1 - Math.Exp(-friction * dfi2)) * cos2;
                    forcePy2 = prestressForceNew * sin2;

                    forces.Add(new Force()
                    {
                        X = -forcePx1 - forcePx2,
                        Y = forcePy1 + forcePy2,
                        point = new Point()
                        {
                            X = cableOrdinates.ordinates.ElementAt(i).X
                        }
                    });
                }

                // calculate forces in the end
                cos = (cableOrdinates.ordinates.ElementAt(oR - 1).X - cableOrdinates.ordinates.ElementAt(oR - 2).X)
           / Math.Sqrt(Math.Pow((cableOrdinates.ordinates.ElementAt(oR - 1).X - cableOrdinates.ordinates.ElementAt(oR - 2).X), 2) + Math.Pow((cableOrdinates.ordinates.ElementAt(oR - 1).Y - cableOrdinates.ordinates.ElementAt(oR - 2).Y), 2));

                sin = (cableOrdinates.ordinates.ElementAt(oR - 1).Y - cableOrdinates.ordinates.ElementAt(oR - 2).Y)
                   / Math.Sqrt(Math.Pow((cableOrdinates.ordinates.ElementAt(oR - 1).X - cableOrdinates.ordinates.ElementAt(oR - 2).X), 2) + Math.Pow((cableOrdinates.ordinates.ElementAt(oR - 1).Y - cableOrdinates.ordinates.ElementAt(oR - 2).Y), 2));

                forcePx = prestressForceNew * cos;
                forcePy = prestressForceNew * sin;

                forces.Add(new Force()
                {
                    X = -forcePx,
                    Y = -forcePy,
                    point = new Point()
                    {
                        X = cableOrdinates.ordinates.ElementAt(oR - 1).X
                    }
                });
            }

            void ActiveEndCableForce()
            {
                // calculate forces in the end

                cos = (cableOrdinates.ordinates.ElementAt(oR - 1).X - cableOrdinates.ordinates.ElementAt(oR - 2).X)
               / Math.Sqrt(Math.Pow((cableOrdinates.ordinates.ElementAt(oR - 1).X - cableOrdinates.ordinates.ElementAt(oR - 2).X), 2) + Math.Pow((cableOrdinates.ordinates.ElementAt(oR - 1).Y - cableOrdinates.ordinates.ElementAt(oR - 2).Y), 2));

                sin = (cableOrdinates.ordinates.ElementAt(oR - 1).Y - cableOrdinates.ordinates.ElementAt(oR - 2).Y)
                   / Math.Sqrt(Math.Pow((cableOrdinates.ordinates.ElementAt(oR - 1).X - cableOrdinates.ordinates.ElementAt(oR - 2).X), 2) + Math.Pow((cableOrdinates.ordinates.ElementAt(oR - 1).Y - cableOrdinates.ordinates.ElementAt(oR - 2).Y), 2));

                forcePx = quantityCable * prestressForce * cos;
                forcePy = quantityCable * prestressForce * sin;

                forces.Add(new Force()
                {
                    X = -forcePx,
                    Y = -forcePy,
                    point = new Point()
                    {
                        X = cableOrdinates.ordinates.ElementAt(oR - 1).X
                    }
                });

                // calculate forces in the middle

                prestressForceNew = quantityCable * prestressForce;

                for (int i = oR - 2; i >= 1; i--)
                {
                    cos1 = (cableOrdinates.ordinates.ElementAt(i).X - cableOrdinates.ordinates.ElementAt(i - 1).X)
                        / Math.Sqrt(Math.Pow((cableOrdinates.ordinates.ElementAt(i).X - cableOrdinates.ordinates.ElementAt(i - 1).X), 2) + Math.Pow((cableOrdinates.ordinates.ElementAt(i).Y - cableOrdinates.ordinates.ElementAt(i - 1).Y), 2));

                    sin1 = (cableOrdinates.ordinates.ElementAt(i).Y - cableOrdinates.ordinates.ElementAt(i - 1).Y)
                        / Math.Sqrt(Math.Pow((cableOrdinates.ordinates.ElementAt(i).X - cableOrdinates.ordinates.ElementAt(i - 1).X), 2) + Math.Pow((cableOrdinates.ordinates.ElementAt(i).Y - cableOrdinates.ordinates.ElementAt(i - 1).Y), 2));

                    cos2 = (cableOrdinates.ordinates.ElementAt(i + 1).X - cableOrdinates.ordinates.ElementAt(i).X)
                        / Math.Sqrt(Math.Pow((cableOrdinates.ordinates.ElementAt(i + 1).X - cableOrdinates.ordinates.ElementAt(i).X), 2) + Math.Pow((cableOrdinates.ordinates.ElementAt(i + 1).Y - cableOrdinates.ordinates.ElementAt(i).Y), 2));

                    sin2 = (cableOrdinates.ordinates.ElementAt(i + 1).Y - cableOrdinates.ordinates.ElementAt(i).Y)
                        / Math.Sqrt(Math.Pow((cableOrdinates.ordinates.ElementAt(i + 1).X - cableOrdinates.ordinates.ElementAt(i).X), 2) + Math.Pow((cableOrdinates.ordinates.ElementAt(i + 1).Y - cableOrdinates.ordinates.ElementAt(i).Y), 2));

                    var dfi1 = Math.Acos(cos1);
                    var dfi2 = Math.Acos(cos2);

                    prestressForceNew = prestressForceNew - prestressForceNew * (1 - Math.Exp(-friction * (dfi1 + dfi2)));

                    forcePx1 = prestressForceNew * (1 - Math.Exp(-friction * dfi1)) * cos1;
                    forcePy1 = -prestressForceNew * sin1;

                    forcePx2 = prestressForceNew * (1 - Math.Exp(-friction * dfi2)) * cos2;
                    forcePy2 = prestressForceNew * sin2;

                    forces.Add(new Force()
                    {
                        X = forcePx1 + forcePx2,
                        Y = forcePy1 + forcePy2,
                    point = new Point()
                        {
                            X = cableOrdinates.ordinates.ElementAt(i).X
                        }
                    });
                }

                // calculate forces in the begin

                cos = (cableOrdinates.ordinates.ElementAt(1).X - cableOrdinates.ordinates.ElementAt(0).X)
               / Math.Sqrt(Math.Pow((cableOrdinates.ordinates.ElementAt(1).X - cableOrdinates.ordinates.ElementAt(0).X), 2) + Math.Pow((cableOrdinates.ordinates.ElementAt(1).Y - cableOrdinates.ordinates.ElementAt(0).Y), 2));

                sin = (cableOrdinates.ordinates.ElementAt(1).Y - cableOrdinates.ordinates.ElementAt(0).Y)
                   / Math.Sqrt(Math.Pow((cableOrdinates.ordinates.ElementAt(1).X - cableOrdinates.ordinates.ElementAt(0).X), 2) + Math.Pow((cableOrdinates.ordinates.ElementAt(1).Y - cableOrdinates.ordinates.ElementAt(0).Y), 2));

                forcePx = prestressForceNew * cos;
                forcePy = prestressForceNew * sin;

                forces.Add(new Force()
                {
                    X = forcePx,
                    Y = forcePy,
                    point = new Point()
                    {
                        X = cableOrdinates.ordinates.ElementAt(0).X
                    }
                });
            }

            void ActiveBeginEndCableForce()
            {
                // calculate forces in the beginning

                cos = (cableOrdinates.ordinates.ElementAt(1).X - cableOrdinates.ordinates.ElementAt(0).X)
                   / Math.Sqrt(Math.Pow((cableOrdinates.ordinates.ElementAt(1).X - cableOrdinates.ordinates.ElementAt(0).X), 2) + Math.Pow((cableOrdinates.ordinates.ElementAt(1).Y - cableOrdinates.ordinates.ElementAt(0).Y), 2));

                sin = (cableOrdinates.ordinates.ElementAt(1).Y - cableOrdinates.ordinates.ElementAt(0).Y)
                   / Math.Sqrt(Math.Pow((cableOrdinates.ordinates.ElementAt(1).X - cableOrdinates.ordinates.ElementAt(0).X), 2) + Math.Pow((cableOrdinates.ordinates.ElementAt(1).Y - cableOrdinates.ordinates.ElementAt(0).Y), 2));

                forcePx = quantityCable * prestressForce * cos;
                forcePy = quantityCable * prestressForce * sin;

                forces.Add(new Force()
                {
                    X = forcePx,
                    Y = forcePy,
                    point = new Point()
                    {
                        X = cableOrdinates.ordinates.ElementAt(0).X
                    }
                });

                // calculate forces in the middle ONE
                prestressForceNew = quantityCable * prestressForce;

                for (int i = 1; i < oR / 2; i++)
                {
                    cos1 = (cableOrdinates.ordinates.ElementAt(i).X - cableOrdinates.ordinates.ElementAt(i - 1).X)
                        / Math.Sqrt(Math.Pow((cableOrdinates.ordinates.ElementAt(i).X - cableOrdinates.ordinates.ElementAt(i - 1).X), 2) + Math.Pow((cableOrdinates.ordinates.ElementAt(i).Y - cableOrdinates.ordinates.ElementAt(i - 1).Y), 2));

                    sin1 = (cableOrdinates.ordinates.ElementAt(i).Y - cableOrdinates.ordinates.ElementAt(i - 1).Y)
                        / Math.Sqrt(Math.Pow((cableOrdinates.ordinates.ElementAt(i).X - cableOrdinates.ordinates.ElementAt(i - 1).X), 2) + Math.Pow((cableOrdinates.ordinates.ElementAt(i).Y - cableOrdinates.ordinates.ElementAt(i - 1).Y), 2));

                    cos2 = (cableOrdinates.ordinates.ElementAt(i + 1).X - cableOrdinates.ordinates.ElementAt(i).X)
                        / Math.Sqrt(Math.Pow((cableOrdinates.ordinates.ElementAt(i + 1).X - cableOrdinates.ordinates.ElementAt(i).X), 2) + Math.Pow((cableOrdinates.ordinates.ElementAt(i + 1).Y - cableOrdinates.ordinates.ElementAt(i).Y), 2));

                    sin2 = (cableOrdinates.ordinates.ElementAt(i + 1).Y - cableOrdinates.ordinates.ElementAt(i).Y)
                        / Math.Sqrt(Math.Pow((cableOrdinates.ordinates.ElementAt(i + 1).X - cableOrdinates.ordinates.ElementAt(i).X), 2) + Math.Pow((cableOrdinates.ordinates.ElementAt(i + 1).Y - cableOrdinates.ordinates.ElementAt(i).Y), 2));

                    var dfi1 = Math.Acos(cos1);
                    var dfi2 = Math.Acos(cos2);

                    prestressForceNew = prestressForceNew - prestressForceNew * (1 - Math.Exp(-friction * (dfi1 + dfi2)));

                    forcePx1 = prestressForceNew * (1 - Math.Exp(-friction * dfi1)) * cos1;
                    forcePy1 = -prestressForceNew * sin1;

                    forcePx2 = prestressForceNew * (1 - Math.Exp(-friction * dfi2)) * cos2;
                    forcePy2 = prestressForceNew * sin2;


                    forces.Add(new Force()
                    {
                        X = -forcePx1 - forcePx2,
                        Y = forcePy1 + forcePy2,
                        point = new Point()
                        {
                            X = cableOrdinates.ordinates.ElementAt(i).X
                        }
                    });
                }


                // calculate forces in the end

                cos = (cableOrdinates.ordinates.ElementAt(oR - 1).X - cableOrdinates.ordinates.ElementAt(oR - 2).X)
               / Math.Sqrt(Math.Pow((cableOrdinates.ordinates.ElementAt(oR - 1).X - cableOrdinates.ordinates.ElementAt(oR - 2).X), 2) + Math.Pow((cableOrdinates.ordinates.ElementAt(oR - 1).Y - cableOrdinates.ordinates.ElementAt(oR - 2).Y), 2));

                sin = (cableOrdinates.ordinates.ElementAt(oR - 1).Y - cableOrdinates.ordinates.ElementAt(oR - 2).Y)
                   / Math.Sqrt(Math.Pow((cableOrdinates.ordinates.ElementAt(oR - 1).X - cableOrdinates.ordinates.ElementAt(oR - 2).X), 2) + Math.Pow((cableOrdinates.ordinates.ElementAt(oR - 1).Y - cableOrdinates.ordinates.ElementAt(oR - 2).Y), 2));

                forcePx = quantityCable * prestressForce * cos;
                forcePy = quantityCable * prestressForce * sin;

                forces.Add(new Force()
                {
                    X = -forcePx,
                    Y = -forcePy,
                    point = new Point()
                    {
                        X = cableOrdinates.ordinates.ElementAt(oR - 1).X
                    }
                });

                // calculate forces in the middle

                prestressForceNew = quantityCable * prestressForce;

                for (int i = oR - 2; i >= oR / 2; i--)
                {
                    cos1 = (cableOrdinates.ordinates.ElementAt(i).X - cableOrdinates.ordinates.ElementAt(i - 1).X)
                        / Math.Sqrt(Math.Pow((cableOrdinates.ordinates.ElementAt(i).X - cableOrdinates.ordinates.ElementAt(i - 1).X), 2) + Math.Pow((cableOrdinates.ordinates.ElementAt(i).Y - cableOrdinates.ordinates.ElementAt(i - 1).Y), 2));

                    sin1 = (cableOrdinates.ordinates.ElementAt(i).Y - cableOrdinates.ordinates.ElementAt(i - 1).Y)
                        / Math.Sqrt(Math.Pow((cableOrdinates.ordinates.ElementAt(i).X - cableOrdinates.ordinates.ElementAt(i - 1).X), 2) + Math.Pow((cableOrdinates.ordinates.ElementAt(i).Y - cableOrdinates.ordinates.ElementAt(i - 1).Y), 2));

                    cos2 = (cableOrdinates.ordinates.ElementAt(i + 1).X - cableOrdinates.ordinates.ElementAt(i).X)
                        / Math.Sqrt(Math.Pow((cableOrdinates.ordinates.ElementAt(i + 1).X - cableOrdinates.ordinates.ElementAt(i).X), 2) + Math.Pow((cableOrdinates.ordinates.ElementAt(i + 1).Y - cableOrdinates.ordinates.ElementAt(i).Y), 2));

                    sin2 = (cableOrdinates.ordinates.ElementAt(i + 1).Y - cableOrdinates.ordinates.ElementAt(i).Y)
                        / Math.Sqrt(Math.Pow((cableOrdinates.ordinates.ElementAt(i + 1).X - cableOrdinates.ordinates.ElementAt(i).X), 2) + Math.Pow((cableOrdinates.ordinates.ElementAt(i + 1).Y - cableOrdinates.ordinates.ElementAt(i).Y), 2));

                    var dfi1 = Math.Acos(cos1);
                    var dfi2 = Math.Acos(cos2);

                    prestressForceNew = prestressForceNew - prestressForceNew * (1 - Math.Exp(-friction * (dfi1 + dfi2)));

                    forcePx1 = prestressForceNew * (1 - Math.Exp(-friction * dfi1)) * cos1;
                    forcePy1 = -prestressForceNew * sin1;

                    forcePx2 = prestressForceNew * (1 - Math.Exp(-friction * dfi2)) * cos2;
                    forcePy2 = prestressForceNew * sin2;

                    forces.Add(new Force()
                    {
                        X = forcePx1 + forcePx2,
                        Y = forcePy1 + forcePy2,
                        point = new Point()
                        {
                            X = cableOrdinates.ordinates.ElementAt(i).X
                        }
                    });
                }

                if (oR % 2 != 0)
                {
                    forces[Convert.ToInt32(oR / 2 - 0.5)].X = 0;
                }
            }
        }
    }
}

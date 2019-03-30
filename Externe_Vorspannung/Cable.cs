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
        public List<double[,]> cableOrdinates;

        public Cable()
        {
            systemName = "";
            nrCable = 0;
            quantityCable = 0;
            prestressForce = 0;
            friction = 0;
            cableOrdinates = new List<double[,]>();
        }

        public Cable(string nazwaSystemu, int nrKabla, int iloscKabli, double silaSprez, double tarcie)
        {
            this.systemName = nazwaSystemu;
            this.nrCable = nrKabla;
            this.quantityCable = iloscKabli;
            this.prestressForce = silaSprez;
            this.friction = tarcie;
            cableOrdinates = new List<double[,]>();
        }

        public double[,] Forces() 
        {
            int oR; // ostatnia rzedna
            double cos;
            double sin;
            double cos1;
            double sin1;
            double cos2;
            double sin2;
            double silaPx;
            double silaPy;
            double silaPx1;
            double silaPy1;
            double silaPx2;
            double silaPy2;
            double dfi;
            double SilaSpreznew;

            double[,] sily;


            //----------------------------------- OBLICZENIE SIL NA KONCACH KABLA-----------------------------------//
            
            oR = cableOrdinates[0].GetLength(0);
            sily = new double[oR, 2];

            cos = (cableOrdinates[0][1, 0] - cableOrdinates[0][0, 0])
               / Math.Sqrt(Math.Pow((cableOrdinates[0][1, 0] - cableOrdinates[0][0, 0]), 2) + Math.Pow((cableOrdinates[0][1, 1] - cableOrdinates[0][0, 1]), 2));

            sin = (cableOrdinates[0][1, 1] - cableOrdinates[0][0, 1])
               / Math.Sqrt(Math.Pow((cableOrdinates[0][1, 0] - cableOrdinates[0][0, 0]), 2) + Math.Pow((cableOrdinates[0][1, 1] - cableOrdinates[0][0, 1]), 2));

            silaPx = quantityCable * prestressForce * cos;
            silaPy = quantityCable * prestressForce * sin;

            sily[0, 0] = silaPx;
            sily[0, 1] = silaPy;


            cos = (cableOrdinates[0][oR-1, 0] - cableOrdinates[0][oR-2, 0])
               / Math.Sqrt(Math.Pow((cableOrdinates[0][oR-1, 0] - cableOrdinates[0][oR-2, 0]), 2) + Math.Pow((cableOrdinates[0][oR-1, 1] - cableOrdinates[0][oR-2, 1]), 2));

            sin = (cableOrdinates[0][oR-1, 1] - cableOrdinates[0][oR-2, 1])
               / Math.Sqrt(Math.Pow((cableOrdinates[0][oR-1, 0] - cableOrdinates[0][oR-2, 0]), 2) + Math.Pow((cableOrdinates[0][oR-1, 1] - cableOrdinates[0][oR-2, 1]), 2));

                silaPx = quantityCable * prestressForce * cos;
                silaPy = quantityCable * prestressForce * sin;

            sily[oR-1, 0] = -silaPx;
            sily[oR-1, 1] = -silaPy;


            //------------------------------------------------------------------------------------------------------//

            //----------------------------------- OBLICZENIE SIL W SRODKU KABLA-----------------------------------//

           for (int i = 1; i < oR-1; i++)
            {
                cos1 = (cableOrdinates[0][i, 0] - cableOrdinates[0][i-1, 0])
                    / Math.Sqrt(Math.Pow((cableOrdinates[0][i, 0] - cableOrdinates[0][i-1, 0]), 2) + Math.Pow((cableOrdinates[0][i, 1] - cableOrdinates[0][i-1, 1]), 2));

                sin1 = (cableOrdinates[0][i, 1] - cableOrdinates[0][i-1, 1])
                    / Math.Sqrt(Math.Pow((cableOrdinates[0][i, 0] - cableOrdinates[0][i-1, 0]), 2) + Math.Pow((cableOrdinates[0][i, 1] - cableOrdinates[0][i-1, 1]), 2));

                cos2 = (cableOrdinates[0][i + 1, 0] - cableOrdinates[0][i, 0])
                    / Math.Sqrt(Math.Pow((cableOrdinates[0][i + 1, 0] - cableOrdinates[0][i, 0]), 2) + Math.Pow((cableOrdinates[0][i + 1, 1] - cableOrdinates[0][i, 1]), 2));

                sin2 = (cableOrdinates[0][i + 1, 1] - cableOrdinates[0][i, 1])
                    / Math.Sqrt(Math.Pow((cableOrdinates[0][i + 1, 0] - cableOrdinates[0][i, 0]), 2) + Math.Pow((cableOrdinates[0][i + 1, 1] - cableOrdinates[0][i, 1]), 2));

                dfi = Math.Atan((cableOrdinates[0][i,1]-cableOrdinates[0][i-1,1]))/(cableOrdinates[0][i, 0] - cableOrdinates[0][i - 1, 0])+
                            (cableOrdinates[0][i+1, 1] - cableOrdinates[0][i, 1])/ (cableOrdinates[0][i+1, 0] - cableOrdinates[0][i, 0]);

                SilaSpreznew = prestressForce;

                SilaSpreznew = quantityCable * SilaSpreznew * (1 - friction * dfi);

                silaPx1 = quantityCable * prestressForce * (1 - friction * dfi) * cos1;
                silaPy1 = -quantityCable * prestressForce * sin1;

                silaPx2 = quantityCable * prestressForce * (1 - friction * dfi) * cos2;
                silaPy2 = quantityCable * prestressForce * sin2;

                sily[i, 0] = 0;
                sily[i, 1] = silaPy1+silaPy2;
            }

            return sily;

        }

    }
}

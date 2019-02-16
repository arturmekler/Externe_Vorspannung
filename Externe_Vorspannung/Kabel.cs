using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Externe_Vorspannung
{
    public class Kabel
    {
        public string nazwaSystemu;
        public int nrKabla;
        public int iloscKabli;
        public double silaSprez;
        public double tarcie;
        public List<double[,]> rzedneKabla;

        public Kabel()
        {
            nazwaSystemu = "";
            nrKabla = 0;
            iloscKabli = 0;
            silaSprez = 0;
            tarcie = 0;
            rzedneKabla = new List<double[,]>();
        }

        public Kabel(string nazwaSystemu, int nrKabla, int iloscKabli, double silaSprez, double tarcie)
        {
            this.nazwaSystemu = nazwaSystemu;
            this.nrKabla = nrKabla;
            this.iloscKabli = iloscKabli;
            this.silaSprez = silaSprez;
            this.tarcie = tarcie;
            rzedneKabla = new List<double[,]>();
        }

        public double[,] Sily() 
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
            
            oR = rzedneKabla[0].GetLength(0);
            sily = new double[oR, 2];

            cos = (rzedneKabla[0][1, 0] - rzedneKabla[0][0, 0])
               / Math.Sqrt(Math.Pow((rzedneKabla[0][1, 0] - rzedneKabla[0][0, 0]), 2) + Math.Pow((rzedneKabla[0][1, 1] - rzedneKabla[0][0, 1]), 2));

            sin = (rzedneKabla[0][1, 1] - rzedneKabla[0][0, 1])
               / Math.Sqrt(Math.Pow((rzedneKabla[0][1, 0] - rzedneKabla[0][0, 0]), 2) + Math.Pow((rzedneKabla[0][1, 1] - rzedneKabla[0][0, 1]), 2));

            silaPx = iloscKabli * silaSprez * cos;
            silaPy = iloscKabli * silaSprez * sin;

            sily[0, 0] = silaPx;
            sily[0, 1] = silaPy;


            cos = (rzedneKabla[0][oR-1, 0] - rzedneKabla[0][oR-2, 0])
               / Math.Sqrt(Math.Pow((rzedneKabla[0][oR-1, 0] - rzedneKabla[0][oR-2, 0]), 2) + Math.Pow((rzedneKabla[0][oR-1, 1] - rzedneKabla[0][oR-2, 1]), 2));

            sin = (rzedneKabla[0][oR-1, 1] - rzedneKabla[0][oR-2, 1])
               / Math.Sqrt(Math.Pow((rzedneKabla[0][oR-1, 0] - rzedneKabla[0][oR-2, 0]), 2) + Math.Pow((rzedneKabla[0][oR-1, 1] - rzedneKabla[0][oR-2, 1]), 2));

                silaPx = iloscKabli * silaSprez * cos;
                silaPy = iloscKabli * silaSprez * sin;

            sily[oR-1, 0] = -silaPx;
            sily[oR-1, 1] = -silaPy;


            //------------------------------------------------------------------------------------------------------//

            //----------------------------------- OBLICZENIE SIL W SRODKU KABLA-----------------------------------//

           for (int i = 1; i < oR-1; i++)
            {
                cos1 = (rzedneKabla[0][i, 0] - rzedneKabla[0][i-1, 0])
                    / Math.Sqrt(Math.Pow((rzedneKabla[0][i, 0] - rzedneKabla[0][i-1, 0]), 2) + Math.Pow((rzedneKabla[0][i, 1] - rzedneKabla[0][i-1, 1]), 2));

                sin1 = (rzedneKabla[0][i, 1] - rzedneKabla[0][i-1, 1])
                    / Math.Sqrt(Math.Pow((rzedneKabla[0][i, 0] - rzedneKabla[0][i-1, 0]), 2) + Math.Pow((rzedneKabla[0][i, 1] - rzedneKabla[0][i-1, 1]), 2));

                cos2 = (rzedneKabla[0][i + 1, 0] - rzedneKabla[0][i, 0])
                    / Math.Sqrt(Math.Pow((rzedneKabla[0][i + 1, 0] - rzedneKabla[0][i, 0]), 2) + Math.Pow((rzedneKabla[0][i + 1, 1] - rzedneKabla[0][i, 1]), 2));

                sin2 = (rzedneKabla[0][i + 1, 1] - rzedneKabla[0][i, 1])
                    / Math.Sqrt(Math.Pow((rzedneKabla[0][i + 1, 0] - rzedneKabla[0][i, 0]), 2) + Math.Pow((rzedneKabla[0][i + 1, 1] - rzedneKabla[0][i, 1]), 2));

                dfi = Math.Atan((rzedneKabla[0][i,1]-rzedneKabla[0][i-1,1]))/(rzedneKabla[0][i, 0] - rzedneKabla[0][i - 1, 0])+
                            (rzedneKabla[0][i+1, 1] - rzedneKabla[0][i, 1])/ (rzedneKabla[0][i+1, 0] - rzedneKabla[0][i, 0]);

                SilaSpreznew = silaSprez;

                SilaSpreznew = iloscKabli * SilaSpreznew * (1 - tarcie * dfi);

                silaPx1 = iloscKabli * silaSprez * (1 - tarcie * dfi) * cos1;
                silaPy1 = -iloscKabli * silaSprez * sin1;

                silaPx2 = iloscKabli * silaSprez * (1 - tarcie * dfi) * cos2;
                silaPy2 = iloscKabli * silaSprez * sin2;

                sily[i, 0] = 0;
                sily[i, 1] = silaPy1+silaPy2;
            }

            return sily;

        }

    }
}

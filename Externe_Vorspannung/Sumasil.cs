using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Externe_Vorspannung
{
    public partial class Sumasil : Form
    {
        public Sumasil(Dictionary<double,double> SumaSilX,Dictionary<double,double> SumaSilY, List<double> rzedneX)
        {
            InitializeComponent();
            //for (int i = 0; i < rzedneX.Count();i++)
            //{
            //    sumaSilDataGridView.Rows.Add(i+1,rzedneX[i],SumaSilX[i],SumaSilY[i]);
            //}
            int i = 0;
            foreach (double x in rzedneX)
            {
                i++;
                sumaSilDataGridView.Rows.Add(i, rzedneX[i - 1].ToString("N2"), 
                    SumaSilX[x].ToString("N2"), SumaSilY[x].ToString("N2"));
            }
        }
    }
}

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
    public partial class SumForces : Form
    {
        public SumForces(double [,] sumForces)
        {
            InitializeComponent();

            for (int i = 1; i <= sumForces.GetLength(0); i++)
            {
                sumaSilDataGridView.Rows.Add(i, sumForces[i-1,2].ToString("N2"),
                    sumForces[i - 1, 0].ToString("N2"), sumForces[i - 1, 1].ToString("N2"));
            }
        }
    }
}

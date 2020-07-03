using Externe_Vorspannung.Model;
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
        public SumForces(List<Force> sumForces)
        {
            InitializeComponent();
            int i = 0;
            foreach(var force in sumForces)
            {
                i++;
                sumaSilDataGridView.Rows.Add(i, force.point.X.ToString(),
                    force.X.ToString("N2"), force.Y.ToString("N2"));

            }

        }
    }
}

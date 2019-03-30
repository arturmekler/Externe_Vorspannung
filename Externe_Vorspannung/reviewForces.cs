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
    public partial class reviewForces : Form
    {
        public reviewForces(Cable k)
        {
            InitializeComponent();

            for (int i = 0; i < k.Forces().GetLength(0); i++)
            {
                silyDataGridView.Rows.Add((i+1).ToString(), k.Forces()[i, 0].ToString("N2"), k.Forces()[i, 1].ToString("N2"));
                
            }
        }
    }
}

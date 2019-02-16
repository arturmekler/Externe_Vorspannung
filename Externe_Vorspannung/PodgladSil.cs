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
    public partial class PodgladSil : Form
    {
        public PodgladSil(Kabel k)
        {
            InitializeComponent();

            for (int i = 0; i < k.Sily().GetLength(0); i++)
            {
                silyDataGridView.Rows.Add((i+1).ToString(), k.Sily()[i, 0].ToString("N2"), k.Sily()[i, 1].ToString("N2"));
            }
        }
    }
}

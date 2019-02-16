using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;




namespace Externe_Vorspannung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            nrKablaTypbox.SelectedIndex = 0;
        }

        public double[,] RysowanieKabla()
        {
            chart1.Series.Clear();
            //-------------------------------------RYSOWANIE KABLA---------------------------------//
            var chart = chart1.ChartAreas[0];
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;
            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;
            //chart.AxisX.Minimum = 12;
            //chart.AxisX.Maximum = 2;
            //chart.AxisY.Minimum = 0;
            //chart.AxisY.Maximum = 12;
            chart.AxisX.Interval = 0;
            chart.AxisY.Interval = 0;
            chart1.Series.Add("Kabel");
            chart1.Series["Kabel"].ChartType = SeriesChartType.Line;
            chart1.Series["Kabel"].Color = Color.Red;

            //-----------------------------------------------------------------------------------------//
            double[,] rzedne = new double[dataGridView2.Rows.Count - 1, 2];

            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                for (int j = 0; j <= 1; j++)
                {
                    rzedne[i, j] = Convert.ToDouble(dataGridView2.Rows[i].Cells[j].Value);
                }
            }
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)  // ---------przypisywanie rzednych------------
            {
                chart1.Series["Kabel"].Points.AddXY(rzedne[i, 0], rzedne[i, 1]);
            }
            return rzedne;
        }

        public void DodawanieKabla(int nrKabla, Kabel k)
        {
            if (kable.ContainsKey(nrKabla) == false)
            {
                kable[nrKabla] = k;
            }

            else
            {
                DialogResult dialogResult = MessageBox.Show("Dany nr kabla już istnieje. Czy chcesz go nadpisać?", "Nadpisanie kabla", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    kable.Remove(nrKabla);
                    kable[nrKabla] = k;
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }

        public Dictionary<int, Kabel> kable = new Dictionary<int, Kabel>();

        public double[,] rzedne;

        private void aktualizaca_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (textBoxIloscPrzesel.Text == "")
            {
                MessageBox.Show("Wypełnij wszystkie pola!");
            }

            else
            {
                int x = Int32.Parse(textBoxIloscPrzesel.Text);
                for (int i = 1; i <= x; i++)
                {
                    dataGridView1.Rows.Add(textBoxIloscPrzesel.Text = i.ToString(), silaSprezTextbox.Text);
                }
            }
        }

        private void dodajKabelbutton_Click(object sender, EventArgs e)
        {
            if (nazwaSystexTextbox.Text == "" || nrKablaTypbox.Text == "" || iloscKabliTextbox.Text == "" || tarcieTextBox.Text == "")
            {
                MessageBox.Show("Wypełnij wszystkie pola!", "Błąd");
            }

            else if (System.Text.RegularExpressions.Regex.IsMatch(silaSprezTextbox.Text, "[^0-9]")
                || System.Text.RegularExpressions.Regex.IsMatch(silaSprezTextbox.Text, "[^0-9]"))
            {
                MessageBox.Show("Prosze wpisać liczby w odpowiednim formacie.");
                iloscKabliTextbox.Text = iloscKabliTextbox.Text.Remove(iloscKabliTextbox.Text.Length - 1);
            }

            else if (dataGridView2.Rows.Count < 3)
            {
                MessageBox.Show("Rzędne kabla zostały nieprawidłowo wprowadzone.");
            }

            else
            {
                RysowanieKabla();

                Kabel k = new Kabel(nazwaSystexTextbox.Text, Int32.Parse(nrKablaTypbox.Text), Int32.Parse(iloscKabliTextbox.Text),
                    Double.Parse(silaSprezTextbox.Text), Double.Parse(tarcieTextBox.Text));


                rzedne = RysowanieKabla();

                k.rzedneKabla.Add(rzedne);

                DodawanieKabla(Int32.Parse(nrKablaTypbox.Text), k);
                k.Sily();

            }
        }

        private void nrKablaTypbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nrKabla = Int32.Parse(nrKablaTypbox.Text);


            if (kable.ContainsKey(nrKabla) == true)
            {
                dataGridView2.Rows.Clear();
                silaSprezTextbox.Clear();
                nazwaSystexTextbox.Text = kable[nrKabla].nazwaSystemu;
                silaSprezTextbox.Text = kable[nrKabla].silaSprez.ToString();
                iloscKabliTextbox.Text = kable[nrKabla].iloscKabli.ToString();
                tarcieTextBox.Text = kable[nrKabla].tarcie.ToString();


                /////////////////////////////      PĘTLA PRZYPISUJACA RZEDNE DO DATAGRIDVIEW       //////////////////////////////////
                for (int i = 0; i < kable[nrKabla].rzedneKabla[0].GetLength(0); i++)
                {
                    dataGridView2.Rows.Add(kable[nrKabla].rzedneKabla[0][i, 0], kable[nrKabla].rzedneKabla[0][i, 1]);
                }
                RysowanieKabla();
            }
            else
            {
                dataGridView2.Rows.Clear();
                chart1.Series.Clear();
            }
        }

        private void podgladSil_Click(object sender, EventArgs e)
        {

            if (kable.ContainsKey(Int32.Parse(nrKablaTypbox.Text)) == false)
            {
                MessageBox.Show("Podany kabel nie istnieje", "Błąd");
            }
            else
            {
                PodgladSil openForm = new PodgladSil(kable[Int32.Parse(nrKablaTypbox.Text)]);
                openForm.Show();
            }
        }

        private void SilaSum_Click(object sender, EventArgs e)
        {

            double[,] SumaSil;

            HashSet<double> rzedneXa;
            rzedneXa = new HashSet<double>();
            List<double> rzedneX;
            Dictionary<double, double> SumaSilX;
            Dictionary<double, double> SumaSilY;
            //rzedneX = new List<double>();        // wszystkie rzedne X w modelu
            //

            for (int i = 1; i <= kable.Count(); i++)
            {
                for (int j = 0; j < kable[i].rzedneKabla[0].GetLength(0); j++)
                {
                    rzedneXa.Add(kable[i].rzedneKabla[0][j, 0]);
                }
            }
            rzedneX = rzedneXa.ToList<double>();

            SumaSil = new double[rzedneX.Count(), 2];
            SumaSilX = new Dictionary<double, double>();
            SumaSilY = new Dictionary<double, double>();

            // tworzenie Dictionary
            for (int i = 0; i < rzedneX.Count(); i++)
            {
                SumaSilX.Add(rzedneX[i], 0);
                SumaSilY.Add(rzedneX[i], 0);
            }


            for (int i = 1; i <= kable.Count(); i++) // pętla po kablach
            {
                for (int j = 0; j < kable[i].rzedneKabla[0].GetLength(0); j++) // pętla po rzędnych kabla poszczegolnego kabla
                {
                    for (int k = 0; k < rzedneX.Count(); k++) // pętla poszukujaca wspolnego "X"
                    {
                        if (kable[i].rzedneKabla[0][j, 0] == rzedneX[k])
                        {
                            SumaSilX[rzedneX[k]] = kable[i].Sily()[j, 0] + SumaSilX[rzedneX[k]];
                            SumaSilY[rzedneX[k]] = kable[i].Sily()[j, 1] + SumaSilY[rzedneX[k]];
                        }
                    }
                }
            }

            Sumasil openForm = new Sumasil(SumaSilX, SumaSilY, rzedneX);
            openForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();

                StreamWriter sw = new StreamWriter(fs);

                for (int i = 1; i <= kable.Count; i++)
                {
                    sw.WriteLine("Kabel nr: " + kable[i].nrKabla);
                    sw.WriteLine("Nazwa systemu: " + kable[i].nazwaSystemu);
                    sw.WriteLine("Siła sprężająca [kN]: " + kable[i].silaSprez);
                    sw.WriteLine("Współczynnik tarcia: " + kable[i].tarcie);
                    sw.WriteLine("Ilość kabli: " + kable[i].iloscKabli+"\n");
                    sw.WriteLine("Rzędne kabla [m]");
                    sw.WriteLine("Nr" + "\t" + "X" + "\t" + "Y");

                    for (int j = 0; j < kable[i].rzedneKabla[0].GetLength(0); j++)
                    {
                        sw.WriteLine((j + 1) + "\t" + kable[i].rzedneKabla[0][j, 0] + "\t" + kable[i].rzedneKabla[0][j, 1]);
                    }

                    sw.WriteLine("\n");
                }

                sw.Close();
            }
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {             
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string linia;
                string[] rzedneasd;
                List<string> text = new List<string>();

                

                while ((linia = sr.ReadLine()) != null)
                {
                    text.Add(linia);
                }

                for(int i=0; i<text.Count();i++)
                {

                    if (text[i].Contains("Kabel nr: "))
                    {
                        Kabel k = new Kabel();

                        k.nrKabla = Int32.Parse(text[i].Remove(0, 9));
                        k.nazwaSystemu = text[i + 1].Remove(0, 15);
                        k.silaSprez = Double.Parse(text[i + 2].Remove(0, 22));
                        k.tarcie = Double.Parse(text[i + 3].Remove(0, 21));
                        k.iloscKabli = Int32.Parse(text[i + 4].Remove(0, 13));


                        //----------------------------------PRZYPISYWANIE DANCYH DO RZEDNYCH--------------------------------------------
                        int n = 0;
                        for (int j = i + 8; text[j] != ""; j++)
                        {
                            n++;
                        }
                        rzedne = new double[n,2];


                        n = 0;
                        for(int j=i+8;text[j]!=""; j++)
                        {
                            rzedneasd = (Regex.Split(text[j], "\t"));
                            
                            rzedne[n, 0] = Double.Parse(rzedneasd[1]);
                            rzedne[n, 1] = Double.Parse(rzedneasd[2]);
                            n++;
                        }

                        k.rzedneKabla.Add(rzedne);

                        kable[k.nrKabla] = k;
                    }

                }

                

                nazwaSystexTextbox.Text = kable[1].nazwaSystemu;
                silaSprezTextbox.Text = kable[1].silaSprez.ToString();
                iloscKabliTextbox.Text = kable[1].iloscKabli.ToString();
                tarcieTextBox.Text = kable[1].tarcie.ToString();

                for (int i = 0; i < kable[1].rzedneKabla[0].GetLength(0); i++)
                {
                    dataGridView2.Rows.Add(kable[1].rzedneKabla[0][i, 0], kable[1].rzedneKabla[0][i, 1]);
                }
                RysowanieKabla();
                nrKablaTypbox.Text = "1";
            }
            else
            {
                MessageBox.Show("Plik nie istnieje!", "Błąd");
            }
        }
    }

}

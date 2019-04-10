﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Text.RegularExpressions;


namespace Externe_Vorspannung
{
    public partial class Externe_Vorspannung : Form
    {
        public Dictionary<int, Cable> cables = new Dictionary<int, Cable>();

        public double[,] ordinates;

        public Externe_Vorspannung()
        {
            InitializeComponent();
            nrCableTypbox.SelectedIndex = 0;
        }

        public void CableDrawing()  //draws a cable graph for review
        {
            
            chart1.Series.Clear();

            var chart = chart1.ChartAreas[0];
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;
            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;
            chart.AxisX.Interval = 0;
            chart.AxisY.Interval = 0;
            chart1.Series.Add("Cable");
            chart1.Series["Cable"].ChartType = SeriesChartType.Line;
            chart1.Series["Cable"].Color = Color.Red;
            chart.AxisX.Title = "[m]";
            chart.AxisY.Title = "[m]";

            for (int i = 0; i < Ordinates().GetLength(0); i++) 
            {
                chart1.Series["Cable"].Points.AddXY(Ordinates()[i, 0], Ordinates()[i, 1]);
            }
        }

        public double[,] Ordinates() //takes values from dataGridView and returns the 2D array with ordinates of the cable
        {
            double[,] ordinates = new double[dataGridView2.Rows.Count - 1, 2];

            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                for (int j = 0; j <= 1; j++)
                {
                    if(dataGridView2.Rows[i].Cells[j].Value!=null)
                    {
                        bool isDouble = Double.TryParse(dataGridView2.Rows[i].Cells[j].Value.ToString(), out ordinates[i, j]);
                        if (isDouble)
                        {
                            ordinates[i, j] = Convert.ToDouble(dataGridView2.Rows[i].Cells[j].Value);
                        }
                    }
                    else
                    {
                        ordinates[i, j] = 0;
                    } 
                }
            }
            return ordinates;
        } 

        public void CableAdd(int nrCable, Cable k)  //adds a cable to the list "cables"
        {
            if (cables.ContainsKey(nrCable) == false)
            {
                cables[nrCable] = k;
            }

            else
            {
                DialogResult dialogResult = MessageBox.Show("Dany nr kabla już istnieje. Czy chcesz go nadpisać?", "Nadpisanie kabla", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    cables.Remove(nrCable);
                    cables[nrCable] = k;
                }
            }
        }

        private void cableAddButton_Click(object sender, EventArgs e)   
        {
            //the function first checks the correctness of the entered data, and then the "CableAdd" function is called


            double prestressForce;
            double friction;
            bool prestressForceisDouble = Double.TryParse(prestressForceTextbox.Text, out prestressForce);
            bool frictionForceisDouble = Double.TryParse(frictionTextBox.Text, out friction);

            if (systemNameTextbox.Text == "" || nrCableTypbox.Text == "" || quantitiyCableTextbox.Text == "" || frictionTextBox.Text == "")
            {
                MessageBox.Show("Wypełnij wszystkie pola!", "Błąd");
            }


            else if (!prestressForceisDouble)
            {
                MessageBox.Show("Siła sprężająca w złym formacie");
            }

            else if (!frictionForceisDouble)
            {
                MessageBox.Show("Tarcie w złym formacie");
            }


            else if (dataGridView2.Rows.Count < 3)
            {
                MessageBox.Show("Rzędne kabla zostały nieprawidłowo wprowadzone.");
            }

            else if (!cableBeginActive.Checked && !cableEndActive.Checked)
            {
                MessageBox.Show("Zakotwienie czynne musi być chociaż z jednej strony");
            }

            else if (System.Text.RegularExpressions.Regex.IsMatch(quantitiyCableTextbox.Text, "[^0-9]"))
            {
                MessageBox.Show("Prosze wpisać ilość kabli w odpowiednim formacie","błąd");
                quantitiyCableTextbox.Clear();
            }

            else
            {
                CableDrawing();
                Ordinates();

                Cable k = new Cable(systemNameTextbox.Text, Int32.Parse(nrCableTypbox.Text), Int32.Parse(quantitiyCableTextbox.Text),
                Double.Parse(prestressForceTextbox.Text), Double.Parse(frictionTextBox.Text), cableBeginActive.Checked, cableEndActive.Checked);

                k.cableOrdinates.Add(Ordinates());

                CableAdd(Int32.Parse(nrCableTypbox.Text), k);
            }
        }

        private void nrCableTypbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //function takes values from variables and writes to Form1 depending on nrCabla in Typbox
            int nrCable = Int32.Parse(nrCableTypbox.Text);


            //it writes to Form1
            if (cables.ContainsKey(nrCable) == true)
            {
                dataGridView2.Rows.Clear();
                prestressForceTextbox.Clear();
                systemNameTextbox.Text = cables[nrCable].systemName;
                prestressForceTextbox.Text = cables[nrCable].prestressForce.ToString();
                quantitiyCableTextbox.Text = cables[nrCable].quantityCable.ToString();
                frictionTextBox.Text = cables[nrCable].friction.ToString();
                cableBeginActive.Checked = cables[nrCable].cableBeginActive;
                cableEndActive.Checked = cables[nrCable].cableEndActive;



                //loop writes data to the datagridview
                for (int i = 0; i < cables[nrCable].cableOrdinates[0].GetLength(0); i++)    
                {
                    dataGridView2.Rows.Add(cables[nrCable].cableOrdinates[0][i, 0], cables[nrCable].cableOrdinates[0][i, 1]);
                }
                CableDrawing();
            }
            else
            {
                dataGridView2.Rows.Clear();
                chart1.Series.Clear();
            }
        }

        private void reviewForces_Click(object sender, EventArgs e) //shows a new window with the forces for the selected cable
        {

            if (cables.ContainsKey(Int32.Parse(nrCableTypbox.Text)) == false)
            {
                MessageBox.Show("Podany kabel nie istnieje", "Błąd");
            }
            else
            {
                reviewForces openForm = new reviewForces(cables[Int32.Parse(nrCableTypbox.Text)]);
                openForm.Show();
            }
        }

        private void ForcesSum_Click(object sender, EventArgs e)    //shows a new window with sum forces
        {
            sumForces openForm = new sumForces(SummForces());
            openForm.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) //save a data to txt
        {
            saveToTxt();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) //open file dialog and clears everything
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            TextClear();
            cables.Clear();

            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    string line;
                    string[] ordinatesTemp;
                    List<string> text = new List<string>();


                    while ((line = sr.ReadLine()) != null)
                    {
                        text.Add(line);
                    }

                    for (int i = 0; i < text.Count(); i++)
                    {

                        if (text[i].Contains("Cable nr: "))
                        {
                            Cable k = new Cable();

                            k.nrCable = Int32.Parse(text[i].Remove(0, 9));
                            k.systemName = text[i + 1].Remove(0, 15);
                            k.prestressForce = Double.Parse(text[i + 2].Remove(0, 22));
                            k.friction = Double.Parse(text[i + 3].Remove(0, 21));
                            k.quantityCable = Int32.Parse(text[i + 4].Remove(0, 13));
                            k.cableBeginActive = bool.Parse(text[i + 5].Remove(0, 35));
                            k.cableEndActive = bool.Parse(text[i + 6].Remove(0, 33));



                            //----------------------------------PRZYPISYWANIE DANCYH DO RZEDNYCH--------------------------------------------
                            int n = 0;
                            for (int j = i + 10; text[j] != ""; j++)
                            {
                                n++;
                            }
                            ordinates = new double[n, 2];


                            n = 0;
                            for (int j = i + 10; text[j] != ""; j++)
                            {
                                ordinatesTemp = (Regex.Split(text[j], "\t"));
                                ordinates[n, 0] = Double.Parse(ordinatesTemp[1]);
                                ordinates[n, 1] = Double.Parse(ordinatesTemp[2]);
                                n++;
                            }

                            k.cableOrdinates.Add(ordinates);

                            cables[k.nrCable] = k;
                        }
                    }


                    systemNameTextbox.Text = cables[1].systemName;
                    prestressForceTextbox.Text = cables[1].prestressForce.ToString();
                    quantitiyCableTextbox.Text = cables[1].quantityCable.ToString();
                    frictionTextBox.Text = cables[1].friction.ToString();
                    cableBeginActive.Checked = cables[1].cableBeginActive;
                    cableEndActive.Checked = cables[1].cableEndActive;


                    for (int i = 0; i < cables[1].cableOrdinates[0].GetLength(0); i++)
                    {
                        dataGridView2.Rows.Add(cables[1].cableOrdinates[0][i, 0], cables[1].cableOrdinates[0][i, 1]);
                    }
                    CableDrawing();
                    nrCableTypbox.Text = "1";
                    sr.Close();
                }
                else
                {
                    MessageBox.Show("Plik nie istnieje!", "Błąd");
                }
            }

            catch
            {
                MessageBox.Show("Plik uszkodzony ");
            }

        }

        private void saveToTxt() //saves data to txt
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();

                StreamWriter sw = new StreamWriter(fs);

                for (int i = 1; i <= cables.Count; i++)
                {
                    sw.WriteLine("Cable nr: " + cables[i].nrCable);
                    sw.WriteLine("Nazwa systemu: " + cables[i].systemName);
                    sw.WriteLine("Siła sprężająca [kN]: " + cables[i].prestressForce);
                    sw.WriteLine("Współczynnik tarcia: " + cables[i].friction);
                    sw.WriteLine("Ilość kabli: " + cables[i].quantityCable);
                    sw.WriteLine("Zakotwienie czynne kabla: Poczatek=" + cables[i].cableBeginActive.ToString());
                    sw.WriteLine("Zakotwienie czynne kabla: Koniec=" + cables[i].cableEndActive.ToString() + "\n");
                    sw.WriteLine("Rzędne kabla nr " + i + "[m]");
                    sw.WriteLine("Nr" + "\t" + "X" + "\t" + "Y");

                    for (int j = 0; j < cables[i].cableOrdinates[0].GetLength(0); j++)
                    {
                        sw.WriteLine((j + 1) + "\t" + cables[i].cableOrdinates[0][j, 0] + "\t" + cables[i].cableOrdinates[0][j, 1]);
                    }

                    sw.WriteLine("\n");

                    // -----------------------------SILY W JEDNYM KABLU-------------------------------------//
                    sw.WriteLine("Sily od kabla nr " + i + " [kN]");
                    sw.WriteLine("Nr" + "\t" + "X" + "\t" + "Y");

                    for (int j = 0; j < cables[i].Forces().GetLength(0); j++)
                    {
                        sw.WriteLine((j + 1) + "\t" + cables[i].Forces()[j, 0].ToString("N2") + "\t" + cables[i].Forces()[j, 1].ToString("N2"));
                    }
                    sw.WriteLine("\n");

                    // -----------------------------SUMA SIL -------------------------------------//

                }


                sw.WriteLine("Sily calkowite");
                sw.WriteLine("Nr" + "\t" + "X" + "\t" + "Y");


                for (int i = 0; i < SummForces().GetLength(0); i++)
                {
                    sw.WriteLine((i + 1) + "\t" + SummForces()[i, 0].ToString("N2") + "\t" + SummForces()[i, 1].ToString("N2"));
                }
                sw.WriteLine("\n");

                sw.Close();
            }
        }

        private int quantityCommonOrdinates() //function to determine the number of x ordinates (without repetitions) 
        {
            List<double> quantity = new List<double>();

            for (int nrCable = 1; nrCable <= cables.Count(); nrCable++)     //loop through the cables
            {
                for (int ordinatesX = 0; ordinatesX < cables[nrCable].Forces().GetLength(0); ordinatesX++) //loop through the "X" ordinate
                {
                    quantity.Add(cables[nrCable].Forces()[ordinatesX, 0]);
                }
            }
            return quantity.Distinct().Count();
        }

        public double[,] SummForces()   //sums the forces from the cables
        {
            double[,] sumForces;

            HashSet<double> globalOrdinatesX;
            globalOrdinatesX = new HashSet<double>();
            List<double> ordinatesX;
            Dictionary<double, double> sumForcesX;
            Dictionary<double, double> sumForcesY;


            for (int i = 1; i <= cables.Count(); i++)
            {
                for (int j = 0; j < cables[i].cableOrdinates[0].GetLength(0); j++)
                {
                    globalOrdinatesX.Add(cables[i].cableOrdinates[0][j, 0]);
                }
            }
            ordinatesX = globalOrdinatesX.ToList<double>();

            sumForces = new double[ordinatesX.Count(), 3];
            sumForcesX = new Dictionary<double, double>();
            sumForcesY = new Dictionary<double, double>();


            // tworzenie Dictionary
            for (int i = 0; i < ordinatesX.Count(); i++)
            {
                sumForcesX.Add(ordinatesX[i], 0);
                sumForcesY.Add(ordinatesX[i], 0);
            }


            for (int i = 1; i <= cables.Count(); i++) // loop through cables
            {
                for (int j = 0; j < cables[i].cableOrdinates[0].GetLength(0); j++) // loop through "X" ordinate
                {
                    for (int k = 0; k < ordinatesX.Count(); k++) // loop looking for a common "X" ordinate
                    {
                        if (cables[i].cableOrdinates[0][j, 0] == ordinatesX[k])
                        {
                            ordinatesX.Sort();
                            sumForcesX[ordinatesX[k]] = cables[i].Forces()[j, 0] + sumForcesX[ordinatesX[k]];
                            sumForcesY[ordinatesX[k]] = cables[i].Forces()[j, 1] + sumForcesY[ordinatesX[k]];
                        }
                    }
                }
            }


            for (int i = 0; i < ordinatesX.Count; i++) // loop writes values into one array
            {
                sumForces[i, 0] = sumForcesX[ordinatesX[i]];
                sumForces[i, 1] = sumForcesY[ordinatesX[i]];
                sumForces[i, 2] = ordinatesX[i];
            }

            return sumForces;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy zapisać zmiany?", "Zapis", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                saveToTxt();
                TextClear();
                cables.Clear();
            }
            else if (dialogResult == DialogResult.No)
            {
                TextClear();
                cables.Clear();
            }
        }

        private void endToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy zapisać zmiany?", "Zapis", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                saveToTxt();
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Close();
            }

        }

        private void wyświetlPomocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Users\\Artur\\source\\repos\\Externe_Vorspannung\\Externe_Vorspannung\\SpreZew.chm");
        }

        private void TextClear()
        {
            dataGridView2.Rows.Clear();
            chart1.Series.Clear();
            systemNameTextbox.Clear();
            prestressForceTextbox.Clear();
            quantitiyCableTextbox.Clear();
            frictionTextBox.Clear();
        }

        private void deleteCableButton_Click(object sender, EventArgs e)
        {
            cables.Remove(Convert.ToInt32(nrCableTypbox.Text));
            TextClear();
        }
    }

}

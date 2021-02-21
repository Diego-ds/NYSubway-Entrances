using New_York_Subway.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace New_York_Subway
{
    public partial class Form1 : Form
    {
        private Manager manager;
        private Form2 form2;

        public Form1()
        {
            InitializeComponent();
            manager = new Manager();
            form2 = new Form2(manager, this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //load File
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (var reader = new StreamReader(openFileDialog1.FileName))
                {
                    String raw = reader.ReadLine();
                    raw = reader.ReadLine();

                    while (raw != null)
                    {
                        string[] report = raw.Split(',');

                        manager.addDivision(report[0]);
                        bool vending = false;
                        if (report[4].Equals("YES"))
                        {
                            vending = true;
                        }

                        bool staffing = false;
                        if (report[5].Equals("FULL"))
                        {
                            staffing = true;
                        }

                        manager.addEntrance(report[0], report[1], report[2], Convert.ToDouble(report[6], CultureInfo.InvariantCulture),
                            Convert.ToDouble(report[7], CultureInfo.InvariantCulture), report[3], vending, staffing);
                        raw = reader.ReadLine();
                    }
                }
            }

            // Carga la tabla
            Hashtable temp = manager.getDivisions();
            foreach (DictionaryEntry element in temp)
            {
                Division div = (Division)element.Value;

                List<Entrance> ent = div.GetEntrances();

                foreach (Entrance entry in ent)
                {
                    int n = table.Rows.Add();

                    table.Rows[n].Cells[0].Value = div.getName();
                    table.Rows[n].Cells[1].Value = entry.getLine();
                    table.Rows[n].Cells[2].Value = entry.getStationName();
                    table.Rows[n].Cells[3].Value = entry.getLatitude();
                    table.Rows[n].Cells[4].Value = entry.getLongitude();
                    table.Rows[n].Cells[5].Value = entry.getType();
                    table.Rows[n].Cells[6].Value = entry.getVendingText();
                    table.Rows[n].Cells[7].Value = entry.getStaffingText();
                }
            }
            searchLineButton.Enabled = true;
            searchNameButton.Enabled = true;
            searchLatitudeButton.Enabled = true;
            searchLongitudeButton.Enabled = true;
            loadMapButton.Enabled = true;
            resetTableButton.Enabled = true;
            graphButton.Enabled = true;
            comboBox1.Enabled = true;
            typeComboBox.Enabled = true;
            vendingComboBox.Enabled = true;
            staffingComboBox.Enabled = true;
        }

        private void searchLineButton_Click(object sender, EventArgs e)
        {
            Hashtable temp = manager.getDivisions();
            table.Rows.Clear();
            string line = lineTextBox.Text;

            if (!line.Equals(""))
            {
                foreach (DictionaryEntry element in temp)
                {
                    Division div = (Division)element.Value;

                    List<Entrance> ent = div.GetEntrances();

                    foreach (Entrance entry in ent)
                    {
                        if (entry.getLine().Contains(line))
                        {
                            int n = table.Rows.Add();

                            table.Rows[n].Cells[0].Value = div.getName();
                            table.Rows[n].Cells[1].Value = entry.getLine();
                            table.Rows[n].Cells[2].Value = entry.getStationName();
                            table.Rows[n].Cells[3].Value = entry.getLatitude();
                            table.Rows[n].Cells[4].Value = entry.getLongitude();
                            table.Rows[n].Cells[5].Value = entry.getType();
                            table.Rows[n].Cells[6].Value = entry.getVendingText();
                            table.Rows[n].Cells[7].Value = entry.getStaffingText();
                        }
                    }
                }
            }
        }

        private void searchNameButton_Click(object sender, EventArgs e)
        {
            Hashtable temp = manager.getDivisions();
            table.Rows.Clear();
            string name = nameStationTextBox.Text;

            if (!name.Equals(""))
            {
                foreach (DictionaryEntry element in temp)
                {
                    Division div = (Division)element.Value;

                    List<Entrance> ent = div.GetEntrances();

                    foreach (Entrance entry in ent)
                    {
                        if (entry.getStationName().Contains(name))
                        {
                            int n = table.Rows.Add();

                            table.Rows[n].Cells[0].Value = div.getName();
                            table.Rows[n].Cells[1].Value = entry.getLine();
                            table.Rows[n].Cells[2].Value = entry.getStationName();
                            table.Rows[n].Cells[3].Value = entry.getLatitude();
                            table.Rows[n].Cells[4].Value = entry.getLongitude();
                            table.Rows[n].Cells[5].Value = entry.getType();
                            table.Rows[n].Cells[6].Value = entry.getVendingText();
                            table.Rows[n].Cells[7].Value = entry.getStaffingText();
                        }
                    }
                }
            }
        }

        private void searchLatitudeButton_Click(object sender, EventArgs e)
        {
            
            if (!latMinTextBox.Text.Equals("") && !latMaxTextBox.Text.Equals(""))
            {
                Hashtable temp = manager.getDivisions();
                table.Rows.Clear();

                double latMin = Double.Parse(latMinTextBox.Text);
                double latMax = Double.Parse(latMaxTextBox.Text);

                if (latMin != 0.0 && latMax != 0.0)
                {
                    foreach (DictionaryEntry element in temp)
                    {
                        Division div = (Division)element.Value;

                        List<Entrance> ent = div.GetEntrances();

                        foreach (Entrance entry in ent)
                        {
                            double lat = entry.getLatitude();
                            if (lat >= latMin && lat <= latMax)
                            {
                                int n = table.Rows.Add();

                                table.Rows[n].Cells[0].Value = div.getName();
                                table.Rows[n].Cells[1].Value = entry.getLine();
                                table.Rows[n].Cells[2].Value = entry.getStationName();
                                table.Rows[n].Cells[3].Value = entry.getLatitude();
                                table.Rows[n].Cells[4].Value = entry.getLongitude();
                                table.Rows[n].Cells[5].Value = entry.getType();
                                table.Rows[n].Cells[6].Value = entry.getVendingText();
                                table.Rows[n].Cells[7].Value = entry.getStaffingText();
                            }
                        }
                    }
                }
            }
            
        }

        private void searchLongitudeButton_Click(object sender, EventArgs e)
        {
            if (!longMinTextBox.Text.Equals("") && !longMaxTextBox.Text.Equals(""))
            {
                Hashtable temp = manager.getDivisions();
                table.Rows.Clear();
                double longMin = Double.Parse(longMinTextBox.Text);
                double longMax = Double.Parse(longMaxTextBox.Text);

                if (longMin != 0.0 && longMax != 0.0)
                {
                    foreach (DictionaryEntry element in temp)
                    {
                        Division div = (Division)element.Value;

                        List<Entrance> ent = div.GetEntrances();

                        foreach (Entrance entry in ent)
                        {
                            double lon = entry.getLongitude();
                            if (lon >= longMin && lon <= longMax)
                            {
                                int n = table.Rows.Add();

                                table.Rows[n].Cells[0].Value = div.getName();
                                table.Rows[n].Cells[1].Value = entry.getLine();
                                table.Rows[n].Cells[2].Value = entry.getStationName();
                                table.Rows[n].Cells[3].Value = entry.getLatitude();
                                table.Rows[n].Cells[4].Value = entry.getLongitude();
                                table.Rows[n].Cells[5].Value = entry.getType();
                                table.Rows[n].Cells[6].Value = entry.getVendingText();
                                table.Rows[n].Cells[7].Value = entry.getStaffingText();
                            }
                        }
                    }
                }
            }
        }

        private void loadMapButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hashtable temp = manager.getDivisions();
            table.Rows.Clear();
            string nameDiv = comboBox1.SelectedItem.ToString();

            foreach (DictionaryEntry element in temp)
            {
                Division div = (Division)element.Value;

                List<Entrance> ent = div.GetEntrances();

                if (div.getName().Equals(nameDiv))
                {
                    foreach (Entrance entry in ent)
                    {
                        int n = table.Rows.Add();

                        table.Rows[n].Cells[0].Value = div.getName();
                        table.Rows[n].Cells[1].Value = entry.getLine();
                        table.Rows[n].Cells[2].Value = entry.getStationName();
                        table.Rows[n].Cells[3].Value = entry.getLatitude();
                        table.Rows[n].Cells[4].Value = entry.getLongitude();
                        table.Rows[n].Cells[5].Value = entry.getType();
                        table.Rows[n].Cells[6].Value = entry.getVendingText();
                        table.Rows[n].Cells[7].Value = entry.getStaffingText();
                    }
                }

               
            }
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hashtable temp = manager.getDivisions();
            table.Rows.Clear();
            string type = typeComboBox.SelectedItem.ToString();

            foreach (DictionaryEntry element in temp)
            {
                Division div = (Division)element.Value;

                List<Entrance> ent = div.GetEntrances();

                foreach (Entrance entry in ent)
                {
                    if (entry.getType().Equals(type))
                    {
                        int n = table.Rows.Add();

                        table.Rows[n].Cells[0].Value = div.getName();
                        table.Rows[n].Cells[1].Value = entry.getLine();
                        table.Rows[n].Cells[2].Value = entry.getStationName();
                        table.Rows[n].Cells[3].Value = entry.getLatitude();
                        table.Rows[n].Cells[4].Value = entry.getLongitude();
                        table.Rows[n].Cells[5].Value = entry.getType();
                        table.Rows[n].Cells[6].Value = entry.getVendingText();
                        table.Rows[n].Cells[7].Value = entry.getStaffingText();
                    }
                }
            }
        }

        private void vendingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool ven = true;
            Hashtable temp = manager.getDivisions();
            table.Rows.Clear();
            string txt = vendingComboBox.SelectedItem.ToString();
            if (txt.Equals("No"))
            {
                ven = false;
            }

            foreach (DictionaryEntry element in temp)
            {
                Division div = (Division)element.Value;

                List<Entrance> ent = div.GetEntrances();

                foreach (Entrance entry in ent)
                {
                    if (entry.getVending() == ven)
                    {
                        int n = table.Rows.Add();

                        table.Rows[n].Cells[0].Value = div.getName();
                        table.Rows[n].Cells[1].Value = entry.getLine();
                        table.Rows[n].Cells[2].Value = entry.getStationName();
                        table.Rows[n].Cells[3].Value = entry.getLatitude();
                        table.Rows[n].Cells[4].Value = entry.getLongitude();
                        table.Rows[n].Cells[5].Value = entry.getType();
                        table.Rows[n].Cells[6].Value = entry.getVendingText();
                        table.Rows[n].Cells[7].Value = entry.getStaffingText();
                    }
                }
            }
        }

        private void staffingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool staff = true;
            Hashtable temp = manager.getDivisions();
            table.Rows.Clear();
            string txt = staffingComboBox.SelectedItem.ToString();
            if (txt.Equals("None"))
            {
                staff = false;
            }

            foreach (DictionaryEntry element in temp)
            {
                Division div = (Division)element.Value;

                List<Entrance> ent = div.GetEntrances();

                foreach (Entrance entry in ent)
                {
                    if (entry.getStaffing() == staff)
                    {
                        int n = table.Rows.Add();

                        table.Rows[n].Cells[0].Value = div.getName();
                        table.Rows[n].Cells[1].Value = entry.getLine();
                        table.Rows[n].Cells[2].Value = entry.getStationName();
                        table.Rows[n].Cells[3].Value = entry.getLatitude();
                        table.Rows[n].Cells[4].Value = entry.getLongitude();
                        table.Rows[n].Cells[5].Value = entry.getType();
                        table.Rows[n].Cells[6].Value = entry.getVendingText();
                        table.Rows[n].Cells[7].Value = entry.getStaffingText();
                    }
                }
            }
        }

        private void resetTableButton_Click(object sender, EventArgs e)
        {
            table.Rows.Clear();
            Hashtable temp = manager.getDivisions();
            foreach (DictionaryEntry element in temp)
            {
                Division div = (Division)element.Value;

                List<Entrance> ent = div.GetEntrances();

                foreach (Entrance entry in ent)
                {
                    int n = table.Rows.Add();

                    table.Rows[n].Cells[0].Value = div.getName();
                    table.Rows[n].Cells[1].Value = entry.getLine();
                    table.Rows[n].Cells[2].Value = entry.getStationName();
                    table.Rows[n].Cells[3].Value = entry.getLatitude();
                    table.Rows[n].Cells[4].Value = entry.getLongitude();
                    table.Rows[n].Cells[5].Value = entry.getType();
                    table.Rows[n].Cells[6].Value = entry.getVendingText();
                    table.Rows[n].Cells[7].Value = entry.getStaffingText();
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void graphButton_Click(object sender, EventArgs e)
        {
            pieChart.Titles.Add("Divisions");
            pieChart.Series["Series1"].IsValueShownAsLabel = true;
            barChart.Titles.Add("Divisions");
            barChart.Series["Series1"].IsValueShownAsLabel = true;
            PointsChart.Titles.Add("Divisions");
            PointsChart.Series["Series1"].IsValueShownAsLabel = true;

            Hashtable temp = manager.getDivisions();
            foreach (DictionaryEntry element in temp)
            {
                Division div = (Division)element.Value;
                pieChart.Series["Series1"].Points.AddXY(div.getName(), div.getSize());
                barChart.Series["Series1"].Points.AddXY(div.getName(), div.getSize());
                PointsChart.Series["Series1"].Points.AddXY(div.getName(), div.getSize());
            }
            graphButton.Enabled = false;
        }  
    }
}
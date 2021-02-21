using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using New_York_Subway.model;

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
            form2 = new Form2(manager);
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

                        manager.addEntrance(report[0], report[1], report[2], Double.Parse(report[6]), 
                            Double.Parse(report[7]), report[3], vending, staffing);
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
            
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            comboBox4.Enabled = true;
        }

        private void searchLineButton_Click(object sender, EventArgs e)
        {

        }

        private void searchNameButton_Click(object sender, EventArgs e)
        {

        }

        private void searchLatitudeButton_Click(object sender, EventArgs e)
        {

        }

        private void searchLongitudeButton_Click(object sender, EventArgs e)
        {

        }

        private void loadMapButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

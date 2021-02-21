using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_York_Subway
{
    public partial class Form1 : Form
    {

        private Form2 form2;

        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //load File

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
    }
}

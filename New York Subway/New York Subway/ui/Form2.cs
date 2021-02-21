using New_York_Subway.model;
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
    public partial class Form2 : Form
    {

        private Manager manager;

        public Form2(Manager manager)
        {
            InitializeComponent();
            this.manager = manager;
        }

        private void gMap_Load(object sender, EventArgs e)
        {
            gMap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMap.Position = new GMap.NET.PointLatLng(40.6643, -73.9385);
        }
    }
}

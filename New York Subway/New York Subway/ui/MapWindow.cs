using New_York_Subway.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using System.Windows.Forms;
using System.Collections;

namespace New_York_Subway
{
    public partial class Form2 : Form
    {

        private Manager manager;

        private GMapOverlay BMTmarkers;
        private GMapOverlay IRTmarkers;
        private GMapOverlay INDmarkers;
        private Form1 form1;
        public Form2(Manager manager, Form1 form1)
        {
            InitializeComponent();
            this.manager = manager;
            BMTmarkers = new GMapOverlay("BMT markers");
            IRTmarkers = new GMapOverlay("IRT markers");
            INDmarkers = new GMapOverlay("IND markers");
            this.form1 = form1;
        }

        private void gMap_Load(object sender, EventArgs e)
        {
            gMap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMap.Position = new GMap.NET.PointLatLng(40.6643, -73.9385);
            gMap.ShowCenter = false;

            overlayCreation();
        }

        private void overlayCreation()
        {
            

            markerAssignation();
        }

        private void markerAssignation()
        {
            Hashtable temp = manager.getDivisions();
            foreach (DictionaryEntry element in temp)
            {
                Division div = (Division)element.Value;

                List<Entrance> ent = div.GetEntrances();

                foreach (Entrance entry in ent)
                {
                   if (div.getName().Equals("BMT"))
                    {
                        GMapMarker marker = new GMarkerGoogle(new PointLatLng(entry.getLatitude(),entry.getLongitude()),
                            GMarkerGoogleType.blue_dot);
                        BMTmarkers.Markers.Add(marker);
                    }
                    else if (div.getName().Equals("IRT"))
                    {
                        GMapMarker marker = new GMarkerGoogle(new PointLatLng(entry.getLatitude(), entry.getLongitude()),
                            GMarkerGoogleType.orange_dot);
                        IRTmarkers.Markers.Add(marker);
                    }
                    if (div.getName().Equals("IND"))
                    {
                        GMapMarker marker = new GMarkerGoogle(new PointLatLng(entry.getLatitude(), entry.getLongitude()),
                            GMarkerGoogleType.red_dot);
                        INDmarkers.Markers.Add(marker);
                    }

                }
            }
            gMap.Overlays.Add(BMTmarkers);
            gMap.Overlays.Add(IRTmarkers);
            gMap.Overlays.Add(INDmarkers);
        }

        private void divisionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            gMap.Overlays.Remove(BMTmarkers);
            gMap.Overlays.Remove(IRTmarkers);
            gMap.Overlays.Remove(INDmarkers);

            if (divisionComboBox.SelectedItem.ToString().Equals("BMT"))
            {
                gMap.Overlays.Add(BMTmarkers);
            }
            else if (divisionComboBox.SelectedItem.ToString().Equals("IRT"))
            {
                gMap.Overlays.Add(IRTmarkers);
            }
            else
            {
                gMap.Overlays.Add(INDmarkers);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.Show();
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            gMap.Overlays.Remove(BMTmarkers);
            gMap.Overlays.Remove(IRTmarkers);
            gMap.Overlays.Remove(INDmarkers);
            gMap.Overlays.Add(BMTmarkers);
            gMap.Overlays.Add(IRTmarkers);
            gMap.Overlays.Add(INDmarkers);
        }
    }
}

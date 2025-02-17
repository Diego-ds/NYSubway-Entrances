﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_York_Subway.model
{
    class Entrance
    {
        private String line;
        private String stationName;
        private double latitude;
        private double longitude;
        private String type;
        private bool vending;
        private bool staffing;

        // Constructor
        public Entrance(string line, string stationName, double latitude, double longitude, string type, bool vending, bool staffing)
        {
            this.line = line;
            this.stationName = stationName;
            this.latitude = latitude;
            this.longitude = longitude;
            this.type = type;
            this.vending = vending;
            this.staffing = staffing;
        }

        //Getters and setters
        public string getLine()
        {
            return line;
        }

        public string getStationName()
        {
            return stationName;
        }

        public double getLatitude()
        {
            return latitude;
        }

        public double getLongitude()
        {
            return longitude;
        }

        public string getType()
        {
            return type;
        }

        public bool getVending()
        {
            return vending;
        }

        public bool getStaffing()
        {
            return staffing;
        }

        public string getStaffingText()
        {
            if (staffing == true)
            {
                return "Full";
            }
            else
            {
                return "None";
            }
        }

        public string getVendingText()
        {
            if (vending == true)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }

        public void setLine(string line)
        {
            this.line = line;
        }

        public void setStationName(string stationName)
        {
            this.stationName = stationName;
        }

        public void setLatitude(double latitude)
        {
            this.latitude = latitude;
        }

        public void setLongitude(double longitude)
        {
            this.longitude = longitude;
        }

        public void setType(string type)
        {
            this.type = type;
        }

        public void setVending(bool vending)
        {
            this.vending = vending;
        }

        public void setStaffing(bool staffing)
        {
            this.staffing = staffing;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_York_Subway.model
{
    class Entrance
    {
        private String division;
        private String line;
        private String stationName;
        private double latitude;
        private double longitude;
        private String type;
        private bool vending;
        private bool staffing;

        // Constructor
        public Entrance(string division, string line, string stationName, double latitude, double longitude, string type, bool vending, bool staffing)
        {
            this.division = division;
            this.line = line;
            this.stationName = stationName;
            this.latitude = latitude;
            this.longitude = longitude;
            this.type = type;
            this.vending = vending;
            this.staffing = staffing;
        }

        //Getters and setters
        
    }
}

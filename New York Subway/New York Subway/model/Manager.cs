using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_York_Subway.model
{
    public class Manager
    {
        private Hashtable divisions;

        //constructor
        public Manager()
        {
            divisions = new Hashtable();
        }

        public void addDivision(String name)
        {
            if (!divisions.ContainsKey(name)){
                divisions.Add(name, new Division(name));
            }
        }

        public void addEntrance(string divName, string line, string stationName, double latitude, double longitude, string type, bool vending, bool staffing)
        {
            Division div = (Division)divisions[divName];
            div.addEntrance(line, stationName, latitude, longitude, type, vending, staffing);
        }

        public Hashtable getDivisions()
        {
            return divisions;
        }

    }
}

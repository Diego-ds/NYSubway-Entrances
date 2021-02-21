using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_York_Subway.model
{
    
    class Division
    {
        private String name;
        private int size;

        private List<Entrance> entrances;

        //Constructor
        public Division(string name)
        {
            this.size = 0;
            this.name = name;
            entrances = new List<Entrance>();
        }

        //Methods

        public void addEntrance(string line, string stationName, double latitude, double longitude, string type, bool vending, bool staffing)
        {
            entrances.Add(new Entrance(line, stationName, latitude, longitude, type, vending, staffing));
            size++;
        }

        //Getters

        public List<Entrance> GetEntrances()
        {
            return entrances;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public int getSize()
        {
            return size;
        }
    }
}

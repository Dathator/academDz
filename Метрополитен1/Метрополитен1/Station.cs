using System;
using System.Collections.Generic;
using System.Text;

namespace Метрополитен1
{
    public class Station
    {
        string name;
        string color;
        Line line;
        bool isWheelchairAccessible;
        bool hasParkAndride;
        bool hasNearbyCableCar;
        List<Station> transfers = new List<Station>();
        public Station(string name, string color)
        {
            this.name = name;
            this.color = color;
        }
        public Station(string name, string color, List<Station> transfers)
        {
            this.name = name;
            this.color = color;
            this.transfers = transfers;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public bool IsWheelchairAccessible()
        {
            return isWheelchairAccessible;
        }
        public bool HasParkAndride()
        {
            return hasParkAndride;
        }
        public bool HasNearbyCableCar()
        {
            return hasNearbyCableCar;
        }
        public string GetLineName()
        {
            return line.GetName();
        }
        public List<Station> GetTransferList()
        {
            return transfers;
        }
    }
}

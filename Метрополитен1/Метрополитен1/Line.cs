using System;
using System.Collections.Generic;
using System.Text;

namespace Метрополитен1
{
    public class Line
    {
        List<Station> stations = new List<Station>();
        string name;
        string color;
        public Line(string name, string color)
        {
            this.name = name;
            this.color = color;
        }
        public Station GetStation(string name)
        {
            foreach (Station i in stations)
            {
                if (i.GetName() == name)
                {
                    return i;
                }
            }
            return null;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetColor()
        {
            return color;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }
        public void AddStation(string name, string color)
        {
            stations.Add(new Station(name, color));
        }
        public void AddStation(string name, string color, List<Station> transfers)
        {
            stations.Add(new Station(name, color, transfers));
        }
        public void RemoveStation(string name)
        {
            foreach (Station i in stations)
            {
                if (i.GetName() == name)
                {
                    stations.Remove(i);
                    break;
                }
            }
        }
        public Station FindStationByName(string name)
        {
            foreach (Station i in stations)
            {
                if (i.GetName() == name)
                {
                    return i;
                }
            }
            return null;
        }
        public List<Station> GetStationList(string name)
        {
            foreach (Station i in stations)
            {
                if (i.GetName() == name)
                    return i.GetTransferList();
            }
            return null;
        }
    }
}

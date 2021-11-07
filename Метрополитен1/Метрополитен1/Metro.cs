using System;
using System.Collections.Generic;

namespace Метрополитен1
{
    public class Metro
    {
        List<Line> lines = new List<Line>();
        string city;
        public Metro(string city)
        {
            this.city = city;
        }
        public string GetCity()
        {
            return city;
        }
        public void AddLine(string name, string color)
        {
            lines.Add(new Line(name, color));
        }
        public void RemoveLine(string name)
        {
            foreach(Line i in lines)
            {
                if (i.GetName() == name)
                {
                    lines.Remove(i);
                    break;
                }
            }
        }
        public void GetStationList(string name)
        {
            
        }
        public void LoadStationsFromFile(string filename)
        {

        }
    }
}

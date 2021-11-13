using System;
using System.Collections.Generic;

namespace Метрополитен1
{
    public class Metro
    {
        private List<Line> lines
        {
            get { return lines; }
            set { lines = value; }
        }
        public string city // возвращает и изменяет название города city
        {
            get { return city; }
            set { city = value; }
        }
        public Metro(string city) // конструкор класса
        {
            this.city = city;
            new List<Line>();
        }
        public void AddLine(string name, string color) // добавляет линию метро с названием name и цветом color в список lines
        {
            lines.Add(new Line(name, color));
        }
        public void RemoveLine(string name) // удаляет линию метро под названием name из списка lines
        {
            foreach (Line i in lines)
            {
                if (i.GetName() == name)
                {
                    lines.Remove(i);
                    break;
                }
            }
        }
        public List<Station> FindStation(string name) // находит станцию по названию среди всех линий метро
        {
            foreach (Line i in lines)
            {
                if (i.FindStationByName(name).Name == name)
                {
                    return i.GetStationList();
                }
            }
            return null;
        }
        public Station FindStation(string name, string linename) // находит станцию по названию в определенной линии метро
        {
            foreach (Line i in lines)
            {
                if (i.GetName() == linename)
                {
                    return i.GetStation(name);
                }
            }
            return null;
        }
        public void GetStationList(string name)
        {
            
        }
        public void LoadStationsFromFile(string filename)
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}

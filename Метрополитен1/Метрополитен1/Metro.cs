using System;
using System.Collections.Generic;

namespace Метрополитен1
{
    public class Metro
    {
        List<Line> lines = new List<Line>();
        string city;
        public Metro(string city) // конструкор класса
        {
            this.city = city;
        }
        public string GetCity() // возвращает название города city
        {
            return city;
        }
        public void AddLine(string name, string color) // добавляет линию метро с названием name и цветом color в список lines
        {
            lines.Add(new Line(name, color));
        }
        public void RemoveLine(string name) // удаляет линию метро под названием name из списка lines
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

using System;
using System.Collections.Generic;
using System.Text;

namespace Метрополитен1
{
    public class Line
    {
        protected List<Station> stations;
        protected string name;
        protected ConsoleColor color;
        public Line(string name, ConsoleColor color) // конструктор класса
        {
            this.name = name;
            this.color = color;
            new List<Station>();
        }
        public Station GetStation(string name) // возвращает станцию с названием name
        {
            foreach (Station i in stations)
            {
                if (i.Name == name)
                {
                    return i;
                }
            }
            return null;
        }
        public string GetName() // возвращает название линии метро name
        {
            return name;
        }
        public void SetName(string name) // изменяет название линии метро name
        {
            this.name = name;
        }
        public ConsoleColor GetColor() // возвращает цвет линии метро color
        {
            return color;
        }
        public void SetColor(ConsoleColor color) // изменяет цвет линии метро color
        {
            this.color = color;
        }
        public void AddStation(string name, ConsoleColor color) // добавляет станцию с названием name и цветом color в список stations
        {
            stations.Add(new Station(name, color));
        }
        public void AddStation(string name, ConsoleColor color, List<Station> transfers) // добавляет станцию с названием name и цветом color и списком станций, вкоторые можно попасть, в список stations
        {
            stations.Add(new Station(name, color, transfers));
        }
        public void RemoveStation(string name) // удаляет станцию с названием name из списка stations
        {
            foreach (Station i in stations)
            {
                if (i.Name == name)
                {
                    stations.Remove(i);
                    break;
                }
            }
        }
        public Station FindStationByName(string name) // возвращает станцию с назанием name
        {
            foreach (Station i in stations)
            {
                if (i.Name == name)
                {
                    return i;
                }
            }
            return null;
        }
        public List<Station> GetStationTransferList(string name) // возвращает список станций, вкоторые можно попасть со станции с названием name
        {
            foreach (Station i in stations)
            {
                if (i.Name == name)
                    return i.TransferList;
            }
            return null;
        }
        public List<Station> GetStationList()
        {
            return stations;
        }
        public virtual void PrintLine()
        {

        }
    }
    public class UndergroundLine : Line
    {
        public UndergroundLine(string name, ConsoleColor color) : base(name, color)
        {

        }
        public override void PrintLine()
        {
            base.PrintLine();
        }
    }
    public class DiameterLine : Line
    {
        public DiameterLine(string name, ConsoleColor color) : base(name, color)
        {

        }
        public override void PrintLine()
        {
            base.PrintLine();
        }
    }
    public class MCCLine : Line
    {
        public MCCLine(string name, ConsoleColor color) : base(name, color)
        {

        }
        public override void PrintLine()
        {
            base.PrintLine();
        }
    }
}

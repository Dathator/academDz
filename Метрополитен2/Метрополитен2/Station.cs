using System;
using System.Collections.Generic;
using System.Text;

namespace Метрополитен1
{
    public class Station
    {
        protected string name;
        protected ConsoleColor color;
        protected Line line;
        protected bool isWheelchairAccessible;
        protected bool hasParkAndride;
        protected bool hasNearbyCableCar;
        protected List<Station> transfers;
        public Station(string name, ConsoleColor color, params string[] info) // конструктор класса
        {
            this.name = name;
            this.color = color;
            new List<Station>();
        }
        public Station(string name, ConsoleColor color, List<Station> transfers, params string[] info) // конструктор класса со списком станций, в которые можно попасть
        {
            this.name = name;
            this.color = color;
            this.transfers = transfers;
        }
        public string Name // возвращает и изменяет название станции
        {
            get { return name; }
            set { name = value; }
        }
        public bool IsWheelchairAccessible // возвращает, доступна ли станция для людей в инвалидных креслах
        {
            get { return isWheelchairAccessible; }
        }
        public bool HasParkAndRide // возвращает, есть ли рядом парк
        {
            get { return hasParkAndride; }
        }
        public bool HasNearbyCableCar // возвращает, есть ли рядом канатная дорога
        {
            get { return hasNearbyCableCar; }
        }
        public string LineName // возвращает название линии метро, на которой находится станция
        {
            get { return line.GetName(); }
        }
        public List<Station> TransferList // возвращает список станций, в которые можно попасть с этой станции
        {
            get { return transfers; }
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}

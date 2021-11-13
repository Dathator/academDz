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
        List<Station> transfers;
        public Station(string name, string color) // конструктор класса
        {
            this.name = name;
            this.color = color;
            transfers = new List<Station>();
        }
        public Station(string name, string color, List<Station> transfers) // конструктор класса со списком станций, в которые можно попасть
        {
            this.name = name;
            this.color = color;
            foreach (Station i in transfers)
            {
                this.transfers.Add(i);
            }
        }
        public string GetName() // возвращает название станции
        {
            return name;
        }
        public void SetName(string name) // устанавливает название станции name
        {
            this.name = name;
        }
        public bool IsWheelchairAccessible() // возвращает, доступна ли станция для людей в инвалидных креслах
        {
            return isWheelchairAccessible;
        }
        public bool HasParkAndRide() // возвращает, есть ли рядом парк
        {
            return hasParkAndride;
        }
        public bool HasNearbyCableCar() // возвращает, есть ли рядом канатная дорога
        {
            return hasNearbyCableCar;
        }
        public string GetLineName() // возвращает название линии метро, на которой находится станция
        {
            return line.GetName();
        }
        public List<Station> GetTransferList() // возвращает список станций, в которые можно попасть с этой станции
        {
            return transfers;
        }
    }
}

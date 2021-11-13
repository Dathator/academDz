using System;
using System.Collections.Generic;

namespace Машазин_музыкальных_дисков
{
    class Program
    {
        interface IStoreItem
        {
            double price { get; set; }
            void DiscountPrice(int percent);
        }
        class Disc : IStoreItem
        {
            public string name
            {
                get { return name; }
                set { name = value; }
            }
            public string genre
            {
                get { return genre; }
                set { genre = value; }
            }
            public int burnCount
            {
                get { return burnCount; }
                set { burnCount = value; }
            }
            public double price 
            { 
                get { return price; } 
                set { price = value; } 
            }
            public Disc(string name, string genre)
            {
                this.name = name;
                this.genre = genre;
            }
            public virtual int DiskSize()
            {
                return 0;
            }
            public virtual void Burn(params string[] values)
            {

            }
            public void DiscountPrice(int percent)
            {
                Convert.ToDouble(percent);
                Price = Price - (Price * (percent / 100));
            }
        }
        class Audio : Disc
        {
            public string artist
            {
                get { return artist; }
                set { artist = value; }
            }
            public string recordingStudio
            {
                get { return recordingStudio; }
                set { recordingStudio = value; }
            }
            public int songsNumber
            {
                get { return songsNumber; }
                set { songsNumber = (value); }
            }
            public Audio(string name, string genre, string artist, string recordingStudio, int songsNumber) : base(name, genre)
            {
                this.artist = artist;
                this.recordingStudio = recordingStudio;
                this.songsNumber = songsNumber;
            }
            public override int DiskSize()
            {
                return songsNumber * 8;
            }
            public override void Burn(params string[] values)
            {
                name = values[0];
                genre = values[1];
                artist = values[2];
                recordStudio = values[3];
                songsNumber = int.Parse(values[4]);
                burnCount += 1;
            }
            public override string ToString()
            {
                return name + " " + genre + " "+ " " + artist + " " + recordStudio + " " + songsNumber + " " + burnCount;
            }
        }
        class DVD : Disc
        {
            public string producer
            {
                get { return producer; }
                set { producer = value; }
            }
            public string filmCompany
            {
                get { return filmCompany; }
                set { filmCompany = value; }
            }
            public int minutesCount
            {
                get { return minutesCount; }
                set { minutesCount = value; }
            }
            public DVD(string name, string genre, string producer, string filmCompany, int minutesCount) : base(name, genre)
            {
                this.producer = producer;
                this.filmCompany = filmCompany;
                this.minutesCount = minutesCount;
            }
            public override int DiskSize()
            {
                return (minutesCount / 64) * 2;
            }
            public override void Burn(params string[] values)
            {
                name = values[0];
                genre = values[1];
                producer = values[2];
                filmCompany = values[3];
                minutesCount = int.Parse(values[4]);
                burnCount += 1;
            }
            public override string ToString()
            {
                return name + " " + genre + " "+ " " + producer + " " + filmCompany + " " + minutesCount + " " + burnCount;
            }
        }
        class Store
        {
            public string storeName
            {
                get { return storeName; }
                set { storeName = value; }
            }
            public string address
            {
                get { return address; }
                set { address = value; }
            }
            public List<Audio> audios
            {
                get { return audios; }
                set { audios = value; }
            }
            public List<DVD> dvds
            {
                get { return dvds; }
                set { dvds = value; }
            }
            public Store(string storeName, string address)
            {
                this.storeName = storeName;
                this.address = address;
            }
            public static Store operator +(Store store, DVD dvd)
            {
                store.dvds.Add(dvd);
                return store;
            }
            public static Store operator +(Store store, Audio audio)
            {
                store.audios.Add(audio);
                return store;
            }
            public static Store operator -(Store store, DVD dvd)
            {
                store.dvds.Remove(dvd);
                return store;
            }
            public static Store operator -(Store store, Audio audio)
            {
                store.audios.Remove(audio);
                return store;
            }
            public override string ToString()
            {
                string str = "Audio:\n";
                if (audios.Count == 0)
                    str += "None";
                else
                {
                    foreach (Audio i in audios)
                    {
                        str += i.Name;
                        if (i != audios[audios.Count - 1])
                            str += ", ";
                    }
                }
                str += "\n";
                str += "DVD:\n";
                if (dvds.Count == 0)
                    str += "None";
                else
                {
                    foreach (DVD i in dvds)
                    {
                        str += i.Name;
                        if (i != dvds[dvds.Count - 1])
                            str += ", ";
                    }
                }
                return str;
            }
        }
        static void Main(string[] args)
        {
            Store store = new Store("Музыкальный", "Богданова, 10");
            store = store + new Audio("Mikle", "pank", "kish", "звук", 10);
            store = store + new Audio("310", "pank", "Severniy Flot", "звук", 20);
            store = store + new Audio("Ulica Ros", "pank", "Aria", "звук", 30);
            store = store + new DVD("Pirati Karibscogo morya", "comedy", "Charls", "WB", 200);
            store = store + new DVD("Vina", "triller", "Charls", "WB", 100);
            Console.WriteLine(store.ToString());
            store.audios[0].Burn("Red Ailert", "rock", "Radio Tapok", "зыук", "10");
            foreach (Audio i in store.audios)
                Console.WriteLine(i.name + " - " + i.DiskSize());
            foreach (DVD i in store.dvds)
                Console.WriteLine(i.name + " - " + i.DiskSize());
        }
    }
}

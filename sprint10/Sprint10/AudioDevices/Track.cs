using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AudioDevices;
using AudioDevices1;



namespace AudioDevices
{
    public class Track
    {

        private int ID;
        private string name;
        private string artist;
        private string albumsource;
        private Category type;
        private Time length;




        public Track(int id, string name)
        {
            this.ID = id;
            this.name = name;
            
        }
        public Track(int id, string name, string artist)
        {
            this.ID = id;
            this.name = name;
            this.artist = artist;

        }
        public Time GetLength()
        {
            return this.length;

        }

        public int GetLengthInSeconds()
        {
            return int.Parse(this.length.ToString().Substring(0, 2)) * 3600 +
                int.Parse(this.length.ToString().Substring(3, 2)) * 60 +
                int.Parse(this.length.ToString().Substring(6, 2));
        }






        public Category Type
        {
            get { return type; }
            set {type = value; }
        }

        public Time Length
        {
           get { return Length ; }
            set { Length = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Artist
        {
            get { return this.artist; }
            set { this.artist = value; }
        }

        public string Albumsource
        {
            get { return albumsource; }
            set { albumsource = value; }
        }

        public string Style
        {
            get { return this.artist; }
            set { this.artist = value; }

        }
        public string Displayname
        {
            get
            {
                if (this.name != null && this.artist != null)
                {
                    return this.artist + " - " + this.name;
                }
                else
                {
                    return "Unknown";
                }
            }
        }

        public string DisplayLength
        {
            get
            {
                return this.length.ToString();
            }
        }

    }
}




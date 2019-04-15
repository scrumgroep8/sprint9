using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AudioDevices1
{

         public enum Category
    {
        Ambient,
        Country,
        Disco,
        Electro,
        Hardcore,
        HardRock,
        HeavyMetal,
        Jumpstyle,
        Klassiek,
        Latin,
        Other,
        Pop,
        Punk,
        Reggae,
        Soul,
        Trance,
        Techno,
        Rock,
        HipHop,
        Jazz,
        Blues
    }
}

public struct Time
{
    //Hier maak je de int fields aan met de uren, minuten en secondes.
    private int hours;
    private int minutes;
    private int seconds;


    public Time(int seconds)
    {
        //berekn het aantal uren
        this.hours = seconds / 3600;
        //bereken het aantal seconden dat overblijft
        int remainder = seconds % 3600;
        //bereken het aantal minuten
        this.minutes = remainder / 60;
        //bereken het aantal seconden
        this.seconds = remainder % 60;
    }

    public Time(int minutes, int seconds) : this(minutes * 60 + seconds)
    {
    }
    public Time(int hours, int minutes, int seconds) : this((hours * 3600) + (minutes * 600) + seconds)
    {
    }

    public override string ToString()
    {
        string timeString = "";
        timeString += hours < 10 ? "0" + hours : hours.ToString();
        timeString += minutes < 10 ? "0" + minutes : minutes.ToString();
        timeString += seconds < 10 ? "0" + seconds : seconds.ToString();
        return timeString;
    }

}
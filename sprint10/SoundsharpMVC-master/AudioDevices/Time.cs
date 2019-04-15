using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDevices
{
    /// <summary>
    /// 
    /// </summary>
    public struct Time
    {

        #region Fields and Properties
        /// <summary>
        /// The hours
        /// </summary>
        private int hours;
        /// <summary>
        /// The minutes
        /// </summary>
        private int minutes;
        /// <summary>
        /// The seconds
        /// </summary>
        private int seconds;

        public int Seconds
        {
            get { return this.hours * 3600 + this.minutes * 60 + this.seconds; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Time"/> struct.
        /// </summary>
        /// <param name="seconds">The seconds.</param>
        public Time(int seconds)
        {
            this.hours = seconds / 3600;
            int remainder = seconds % 3600;
            this.minutes = remainder / 60;
            this.seconds = remainder % 60;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Time"/> struct.
        /// </summary>
        /// <param name="minutes">The minutes.</param>
        /// <param name="seconds">The seconds.</param>
        public Time(int minutes, int seconds) : this(minutes * 60 + seconds) { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Time"/> struct.
        /// </summary>
        /// <param name="hours">The hours.</param>
        /// <param name="minutes">The minutes.</param>
        /// <param name="seconds">The seconds.</param>
        public Time(int hours, int minutes, int seconds) : this(hours * 3600 + minutes * 60 + seconds) { } 
        #endregion

        #region Methods
        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            string timeString = "";
            timeString += hours.ToString() + ":";
            timeString += minutes < 10 ? "0" + minutes : minutes.ToString();
            timeString += ":";
            timeString += seconds < 10 ? "0" + seconds : seconds.ToString();
            return timeString;
        } 
        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDevices.Tracks
{
    /// <summary>
    /// 
    /// </summary>
    public class TrackList
    {
        /// <summary>
        /// A randomizer
        /// </summary>
        private Random r = new Random();
        /// <summary>
        /// The tracks
        /// </summary>
        private List<Track> tracks;

        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <value>
        /// The count.
        /// </value>
        public int Count
        {
            get
            {
                return tracks.Count();
            }
        }

        /// <summary>
        /// Gets the total time.
        /// </summary>
        /// <value>
        /// The total time.
        /// </value>
        public Time TotalTime
        {
            get
            {
                int totalSeconds = 0;
                foreach (Track t in tracks)
                {
                    totalSeconds += t.GetLengthInSeconds();
                }
                return new Time(totalSeconds);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackList"/> class.
        /// </summary>
        public TrackList()
        {
            tracks = new List<Track>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackList"/> class.
        /// </summary>
        /// <param name="tracks">The tracks.</param>
        public TrackList(List<Track> tracks)
        {
            this.tracks = tracks;
        }

        /// <summary>
        /// Adds the specified t.
        /// </summary>
        /// <param name="t">The t.</param>
        public void Add(Track t)
        {
            tracks.Add(t);
        }

        /// <summary>
        /// Removes the specified t.
        /// </summary>
        /// <param name="t">The t.</param>
        public void Remove(Track t)
        {
            tracks.Remove(t);
        }

        /// <summary>
        /// Clears this instance.
        /// </summary>
        public void Clear()
        {
            tracks.Clear();
        }

        /// <summary>
        /// Gets all tracks.
        /// </summary>
        /// <returns></returns>
        public List<Track> GetAllTracks()
        {
            return tracks;
        }

        /// <summary>
        /// Shuffles this instance.
        /// </summary>
        /// <returns></returns>
        public List<Track> Shuffle()
        {

            List<Track> temp = new List<Track>();
            foreach (Track t in tracks)
            {
                temp.Add(t);
            }


            return temp.OrderBy(item => r.Next()).ToList();
        }

    }
}

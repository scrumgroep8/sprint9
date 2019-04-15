using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDevices.Tracks
{
    /// <summary>
    /// Enumaration with music genres
    /// </summary>
    public enum Category
    {
        Ambient,
        Blues,
        Disco,
        Electro,
        Hardcore,
        HardRock,
        HeavyMetal,
        Hiphop,
        Jazz,
        Jumpstyle,
        Klassiek,
        Latin,
        Other,
        Pop,
        Punk,
        Reggae,
        Rock,
        Soul,
        Trance,
        Techno
    }


    public class Track
    {

        #region Fields and Properties

        private int lastId = 0;
        /// <summary>
        /// The identifier
        /// </summary>
        private int id;
        /// <summary>
        /// The name
        /// </summary>
        private string name;
        /// <summary>
        /// The artist
        /// </summary>
        private string artist;
        /// <summary>
        /// The album source
        /// </summary>
        private string albumSource;
        /// <summary>
        /// The style
        /// </summary>
        private Category style;
        /// <summary>
        /// The length
        /// </summary>
        private Time length;


        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [Key]
        public int Id { get => id; set => id = value; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get => name; set => name = value; }
        /// <summary>
        /// Gets or sets the artist.
        /// </summary>
        /// <value>
        /// The artist.
        /// </value>
        public string Artist { get => artist; set => artist = value; }
        /// <summary>
        /// Gets the display name.
        /// </summary>
        /// <value>
        /// The display name.
        /// </value>
        public string DisplayName
        {
            get
            {
                if(artist != null && name != null)
                {
                    return artist + ": " + name;
                }
                else
                {
                    return "Unknown";
                }
            }
        }
        /// <summary>
        /// Sets the length.
        /// </summary>
        /// <value>
        /// The length.
        /// </value>
        public Time Length { set => length = value; }
        /// <summary>
        /// Gets the display length.
        /// </summary>
        /// <value>
        /// The display length.
        /// </value>
        public string DisplayLength
        {
            get
            {
                return this.length.ToString();
            }
        }
        /// <summary>
        /// Gets or sets the style.
        /// </summary>
        /// <value>
        /// The style.
        /// </value>
        public Category Style { get => style; set => style = value; }
        /// <summary>
        /// Gets or sets the album source.
        /// </summary>
        /// <value>
        /// The album source.
        /// </value>
        public string AlbumSource { get => albumSource; set => albumSource = value; }

        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Track"/> class.
        /// </summary>
        public Track() { this.Id = ++lastId; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Track"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public Track(int id)
        {
            this.Id = ++lastId;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Track"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        public Track(int id, string name)
        {
            this.Id = ++lastId;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Track"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="artist">The artist.</param>
        public Track(int id, string name, string artist)
        {
            this.Id = ++lastId;
            this.Name = name;
            this.Artist = artist;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Gets the length.
        /// </summary>
        /// <returns></returns>
        public Time GetLength()
        {
            return this.length;
        }

        /// <summary>
        /// Gets the length in seconds.
        /// </summary>
        /// <returns></returns>
        public int GetLengthInSeconds()
        {
            return this.length.Seconds;
        } 
        #endregion

    }
}

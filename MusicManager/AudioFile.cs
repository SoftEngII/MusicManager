using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLib;

namespace MusicManager
{
    public class AudioFile : IComparable<AudioFile>
    {
        public string filePath { get; set; }

        private TagLib.File _metaData;
        public readonly int trackID;

        

        //public TagLib.File track
        //{
        //    get { return _metaData; }
        //}

        public uint Sequence
        { 
            get { return _metaData.Tag.Track; } 
            set
            {
                _metaData.Tag.Track = value;
                _metaData.Save();
            }
        }
        public string Artist
        {
            get
            {
                if (!(_metaData.Tag.Performers == null))
                {
                    return _metaData.Tag.Performers[0].ToString();
                }
                return "";
            }
            set
            {
                _metaData.Tag.Performers = null;
                _metaData.Tag.Performers = new string[] { value };
                _metaData.Save();
            }
        }

        public string Album
        {
            get
            {
                if (_metaData.Tag.Album != null)
                {
                    return _metaData.Tag.Album;
                }
                else
                {
                    return "";
                }
            }
            set
            {
                _metaData.Tag.Album = value;
                _metaData.Save();
            }
        }

        public string TrackTitle
        {
            get
            {
                if (_metaData.Tag.Title != null)
                {
                    return _metaData.Tag.Title;
                }
                else
                {
                    return "";
                }
            }
            set
            {
                _metaData.Tag.Title = value;
                _metaData.Save();
            }
        }
        public string Comment
        {
            get
            {
                if (_metaData.Tag.Comment != null)
                {
                    return _metaData.Tag.Comment;
                }
                else
                {
                    return "";
                }
            }
            set
            {
                _metaData.Tag.Comment = value;
                _metaData.Save();
            }
        }
        public string Genre
        {
            get
            {
                if(!(_metaData.Tag.Genres.Count() < 1))
                {
                    return _metaData.Tag.Genres[0].ToString();
                }
                return "";
                //try
                //{
                //    return _metaData.Tag.Genres[0].ToString();
                //}
                //catch (Exception)
                //{
                //    _metaData.Tag.Genres.Initialize();
                //    return "";
                //}
            }
            set
            {
                _metaData.Tag.Genres = null;
                _metaData.Tag.Genres = new string[] { value };
                _metaData.Save();
            }
        }
        public TimeSpan Duration
        {
            get { return _metaData.Properties.Duration; }
        }
        public string DateModified
        {
            get
            {
                var lastModified = System.IO.File.GetLastWriteTime(filePath);
                return lastModified.ToString("dd/MM/yy HH:mm");

            }
        }


        public AudioFile(string _filePath, int trackID)
        {
            filePath = _filePath;
            _metaData = TagLib.File.Create(filePath);
            this.trackID = trackID;
        }

        public string[] ReturnRowColumnData()
        {
            //This returns data for each column in a row. It must be in order and account for columns that aren't visible.
            string[] rowData = new string[] { Sequence.ToString() ,ReturnFileName(), Artist, TrackTitle, Album, Duration.ToString("mm':'ss"), Genre , filePath, trackID.ToString(), DateModified };
            return rowData;
        }

        public string ReturnFileName()
        {
            string Name = filePath;
            Name = Name.Substring(0, Name.LastIndexOf(@"."));
            Name = Name.Remove(0, Name.LastIndexOf(@"\") + 1);
            return Name;
        }


        public int CompareTo(AudioFile other)
        {
            if (other.filePath == this.filePath)
            { return 0; }
              return 1;
        }
    }
}

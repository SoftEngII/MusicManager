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
        private string _filePath;
        private TagLib.File _metaData;
        public readonly int trackID;

        public uint Sequence
        { get { return _metaData.Tag.Track; } }
        public string Artist
        {
            get
            {
                try
                {
                    return _metaData.Tag.Performers[0].ToString();

                }
                catch (Exception)
                {
                    _metaData.Tag.Performers.Initialize();
                    return "None";

                }
                //if (_metaData.Tag.Performers != null)
                //{
                //    return _metaData.Tag.Performers[0].ToString();
                //}
                //else
                //{
                //    return "None";
                //}
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
                    return "None";
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
                    return "None";
                }
            }
            set
            {
                _metaData.Tag.Title = value;
                _metaData.Save();
            }
        }

        public string Duration
        {
            get { return _metaData.Properties.Duration.ToString("mm':'ss"); }
        }

        public AudioFile(string filePath, int trackID)
        {
            _filePath = filePath;
            _metaData = TagLib.File.Create(filePath);
            this.trackID = trackID;
        }

        public string GetFilePath()
        {
            return _filePath;
        }

        public string[] ReturnRowColumnData()
        {
            //This returns data for each column in a row. It must be in order and account for columns that aren't visible.
            string[] rowData = new string[] { Sequence.ToString() ,ReturnFileName(), Artist, TrackTitle, Album, Duration, _filePath, trackID.ToString() };
            return rowData;
        }

        public string ReturnFileName()
        {
            string Name = _filePath;
            Name = Name.Substring(0, Name.LastIndexOf(@"."));
            Name = Name.Remove(0, Name.LastIndexOf(@"\") + 1);
            return Name;
        }



        public int CompareTo(AudioFile other)
        {
            if (other._filePath == this._filePath)
            {
                return 0;
            }
            return 1;
        }
    }
}

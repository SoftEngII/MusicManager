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

        public string Artist
        {
            get { return _metaData.Tag.Performers[0].ToString(); }
            set
            {
                _metaData.Tag.Performers = null;
                _metaData.Tag.Performers = new string[] { value };
                _metaData.Save();
            }
        }

        public string Album
        {
            get { return _metaData.Tag.Album; }
            set
            {
                _metaData.Tag.Album = value;
                _metaData.Save();
            }
        }

        public string TrackTitle
        {
            get { return _metaData.Tag.Title; }
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

        public string[] ReturnRowColumnData()
        {   
            //This returns data for each column in a row. It must be in order and account for columns that aren't visible.
            string[] rowData = new string[] { ReturnFileName(), Artist, TrackTitle, Album, Duration, _filePath, trackID.ToString() };
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
            throw new NotImplementedException();
        }
    }
}

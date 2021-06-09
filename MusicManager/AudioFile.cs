
using TagLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicManager
{
    public class AudioFile : IComparable<AudioFile>
    {
        private string _emPeeThree;
        private TagLib.File tagLibFile;
        public AudioFile(string emPeeThree)
        {
            _emPeeThree = emPeeThree;
            tagLibFile = TagLib.File.Create(emPeeThree);
        }

        public string GetName() { return _emPeeThree; }

        public TagLib.File SingleTagChanger(string tagName, string tagType)
        {
            tagType.ToLower();
            if (tagType.Equals("title"))
            {
                TitleTagChanger(tagName, tagType);
            }
            if (tagType.Equals("album"))
            {
                AlbumTagChanger(tagName, tagType);
            }
            if (tagType.Equals("comment"))
            {
                CommentTagChanger(tagName, tagType);
            }
            tagLibFile.Save();
            return tagLibFile;
        }

        public TagLib.File MultiTagChanger(string[] tagName, string tagType)
        {
            tagType.ToLower();
            if (tagType.Equals("artist"))
            {
                ArtistTagChanger(tagName, tagType);
            }
            if (tagType.Equals("genre"))
            {
                GenreTagChanger(tagName, tagType);
            }
            tagLibFile.Save();
            return tagLibFile;
        }

        private TagLib.File TitleTagChanger(string tagName, string tagType)
        {
            tagLibFile.Tag.Title = tagName;
            return tagLibFile;
        }
        private TagLib.File ArtistTagChanger(string[] tagName, string tagType)
        {
            tagLibFile.Tag.AlbumArtists = tagName;
            return tagLibFile;
        }
        private TagLib.File AlbumTagChanger(string tagName, string tagType)
        {
            tagLibFile.Tag.Album = tagName;
            return tagLibFile;
        }
        private TagLib.File GenreTagChanger(string[] tagName, string tagType)
        {
            tagLibFile.Tag.Genres = tagName;
            return tagLibFile;
        }
        private TagLib.File CommentTagChanger(string tagName, string tagType)
        {
            tagLibFile.Tag.Comment = tagName;
            return tagLibFile;
        }

        public override string ToString()
        {
            return $"Artist: {tagLibFile.Tag.Performers}, Title: {tagLibFile.Tag.Title}, Album: {tagLibFile.Tag.Album}";

        }


        public int CompareTo(AudioFile song2)
        {
            for (int i = 0; i < this.tagLibFile.Tag.Title.Length; i++)
            {
                if (song2.ToString().Length > i)
                {
                    if (this.tagLibFile.Tag.Title[i] > song2.tagLibFile.Tag.Title[i])
                    { return -1; }
                    else if (this.tagLibFile.Tag.Title[i] < song2.tagLibFile.Tag.Title[i])
                    { return 1; }
                }
            }
            return 0;
        }
        public string[] RowData()
        {
            string[] row = new string[] { tagLibFile.Tag.Performers[0], tagLibFile.Tag.Title, tagLibFile.Tag.Album, tagLibFile.Properties.Duration.ToString("mm':'ss") };
            return row;
        }
    }

}
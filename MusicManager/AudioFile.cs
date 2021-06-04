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

        public string GetName()
        { return _emPeeThree; }

        public TagLib.File TitleTagChanger(string tagName, string tagType)
        {
            tagType.ToLower();
            if (tagType.Equals("title"))
            {
                tagLibFile.Tag.Title = tagName;
            }
            tagLibFile.Save();
            return tagLibFile;
        }
        public TagLib.File ArtistTagChanger(string[] tagName, string tagType)
        {
            tagType.ToLower();
            if (tagType.Equals("artist"))
            {
                tagLibFile.Tag.AlbumArtists = tagName;
            }
            tagLibFile.Save();
            return tagLibFile;
        }
        public TagLib.File AlbumTagChanger(string tagName, string tagType)
        {
            tagType.ToLower();
            if (tagType.Equals("album"))
            {
                tagLibFile.Tag.Album = tagName;
            }
            tagLibFile.Save();
            return tagLibFile;
        }
        public TagLib.File GenreTagChanger(string[] tagName, string tagType)
        {
            tagType.ToLower();
            if (tagType.Equals("genre"))
            {
                tagLibFile.Tag.Genres = tagName;
            }
            tagLibFile.Save();
            return tagLibFile;
        }
        public TagLib.File CommentTagChanger(string tagName, string tagType)
        {
            tagType.ToLower();
            if (tagType.Equals("comment"))
            {
                tagLibFile.Tag.Comment = tagName;
            }
            tagLibFile.Save();
            return tagLibFile;
        }

        public override string ToString()
        {
            //The tag to get the artist returns a string[] not a string. 
            return $"Artist: {tagLibFile.Tag.Performers[0]}, Title: {tagLibFile.Tag.Title}, Album: {tagLibFile.Tag.Album}";
            

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
    }

}

using TagLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicManager
{
    public class AudioFile
    {
        public string name;
        public TagLib.File tagLibFile;
        public AudioFile(string emPeeThree)
        {
            name = emPeeThree;
            tagLibFile = TagLib.File.Create(name);
        }

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
            return $"Artist: {tagLibFile.Tag.Performers}, Title: {tagLibFile.Tag.Title}, Album: {tagLibFile.Tag.Album}";

        }


    }

}

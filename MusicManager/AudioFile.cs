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
        private string _emPeeThree;
        private TagLib.File tagLibFile;
        public AudioFile(string emPeeThree)
        {
            _emPeeThree = emPeeThree;
            tagLibFile = TagLib.File.Create(emPeeThree);
        }

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


    }

}

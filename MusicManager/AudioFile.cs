using TagLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicManager
{
    public class AudioFile : IDisposable
    {
        private string _emPeeThree;
        public TagLib.File file;
        public AudioFile(string emPeeThree)
        {
            _emPeeThree = emPeeThree;
            file = TagLib.File.Create(_emPeeThree);
        }

        public TagLib.File TitleTagChanger(string tagName, string tagType)
        {
            tagType.ToLower();
            if (tagType.Equals("title"))
            {
                file.Tag.Title = tagName;
            }
            file.Save();
            return file;
        }
        public TagLib.File GenreTagChanger(string[] tagName, string tagType)
        {
            tagType.ToLower();
            if (tagType.Equals("artist"))
            {
                file.Tag.AlbumArtists = tagName;
            }
            file.Save();
            return file;
        }
        public TagLib.File AlbumTagChanger(string tagName, string tagType)
        {
            tagType.ToLower();
            if (tagType.Equals("album"))
            {
                file.Tag.Album = tagName;
            }
            file.Save();
            return file;
        }
        public TagLib.File GenresTagChanger(string[] tagName, string tagType)
        {
            tagType.ToLower();
            if (tagType.Equals("genre"))
            {
                file.Tag.Genres = tagName;
            }
            file.Save();
            return file;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }



        //var year = file.Tag.Year;


    }

}

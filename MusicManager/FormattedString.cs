using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicManager
{
    public static class FormattedString
    {
        public static string AudioFileString(string artist = "Artist", string title = "Title", string album = "Album", TimeSpan duration = default(TimeSpan))
        {
            //76 char max 25 char each section
            char[] artistArr = artist.ToCharArray();
            char[] titleArr = title.ToCharArray();
            char[] albumArr = album.ToCharArray();
            string durStr = duration.ToString();
            char[] durArr = durStr.ToCharArray();
            

            

            char[] artistFull = "                        |".ToCharArray();
            for (int i = 0; i < artistArr.Length; i++)
            {
                artistFull[i] = artistArr[i];
            }

            char[] titleFull = "                        |".ToCharArray();
            for (int i = 0; i < titleArr.Length; i++)
            {
                titleFull[i] = titleArr[i];
            }
            char[] albumFull = "                        |".ToCharArray();
            for (int i = 0; i < albumArr.Length; i++)
            {
                albumFull[i] = albumArr[i];
            }
            char[] durationFull = "                        |".ToCharArray();
                for (int i = 0; i < durArr.Length; i++)
                {
                    durationFull[i] = durArr[i];
                }
            
            





            string artistStr = new string(artistFull);
            string titleStr = new string(titleFull);
            string albumStr = new string(albumFull);



            return artistStr + titleStr + albumStr + durStr ;
        }
    }
}

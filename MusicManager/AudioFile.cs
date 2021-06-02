using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicManager
{
    public class AudioFile
    {
        public AudioFile(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        // Meta-Data
        public string Genre { get; set; }
        public string Album { get; set; }
        public List<string> Artist { get; set; }
        public string Title { get; set; }
        
    }



}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Practice
{
    class Song
    {
            public string title;
            public string artist;
            public int seconds;
            private string rating; // set to private so we can use a setter/getter 
            public static int songCount = 0;
            public Song(string aTitle, string aArtist, int aSeconds, string aRating)
            {
            title = aTitle;
            artist = aArtist;
            seconds = aSeconds;
            Rating = aRating; // calling on getter/setter
            Console.WriteLine(title + " " + artist + " " + seconds + " " + rating);
            Console.WriteLine("This song is short: " + isShort());
            songCount++;
            Console.WriteLine("Total Songs: " + songCount);
        }
        public bool isShort()
        {
            if (seconds >= 250)
            {
                return true;
            }
            return false;
        }
        public string Rating
        {
            get  { return rating; }
            set  { 
                if (value == "G" || value == "PG" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Description
    {
        int episodeNubmer;
        string episodeName;
        TimeSpan lenght;

        public Description(int episodeNubmer, TimeSpan lenght, string episodeName)
        {
            this.episodeNubmer = episodeNubmer;
            this.episodeName = episodeName;
            this.lenght = lenght;
        }
        public override string ToString()
        {
            return $"{episodeNubmer},{lenght},{episodeName}";
        }

    }
}

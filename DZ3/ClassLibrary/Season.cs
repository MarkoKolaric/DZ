using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Season
    {
        public int Lenght=>episodes.Length;
        int SeasonNumber;
        public Episode[] episodes;
         
        public Season(int seasonNumber, Episode[] episodes)
        {
            SeasonNumber = seasonNumber;
            this.episodes = episodes;
        }

        public Season()
        {
        }

        public Episode this[int index]
        {
            get => episodes[index];
            set => episodes[index] = value;
        }
        

        public override string ToString()
        {
            string EpisodesOutput = string.Join<Episode>(Environment.NewLine, episodes);
            return $"Season "+SeasonNumber+ ":\n=================================================\n"+EpisodesOutput+ "\nReport:\n=================================================\nTotal viewers: "+Episode.TotalViewers(episodes)+"\nTotal duration: "+Episode.TotalDuration(episodes)+ "\n=================================================";
        }
    }
}

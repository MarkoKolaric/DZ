using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.IO;

namespace ClassLibrary
{
    public class TvUtilities
    {
        public static Episode Parse(string episodesInput)
        {
            string[] episodesInputs = episodesInput.Split(",");
            int viewers = int.Parse(episodesInputs[0]);
            double SumScore = double.Parse(episodesInputs[1], System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture);
            double MaxScore = double.Parse(episodesInputs[2], System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture);
            int episodeNubmer = int.Parse(episodesInputs[3]);
            string episodeName = episodesInputs[5];
            int minutes = int.Parse(episodesInputs[4]);
            TimeSpan lenght = new TimeSpan(0,minutes,0);
            Description description = new Description(episodeNubmer, lenght, episodeName);
            Episode ep = new Episode(viewers, SumScore, MaxScore, description);
            return ep;
        }
        public static Episode[] LoadEpisodesFromFile(string fileName)
        {
            string[] episodesInputs = File.ReadAllLines(fileName);
            Episode[] episodes = new Episode[episodesInputs.Length];
            for (int i = 0; i < episodes.Length; i++)
            {
                episodes[i] = Parse(episodesInputs[i]);
            }
            return episodes;
        }
        public static double GenerateRandomScore()
        {
            Random random = new Random();
            return random.NextDouble() * (10.00);
        }
        public static void Sort(Episode[] episodes)
        {
            int n = episodes.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (episodes[j+1].GetAverageScore() > episodes[j].GetAverageScore())
                    {
                        Episode temp = episodes[j];
                        episodes[j] = episodes[j + 1];
                        episodes[j + 1] = temp;
                    }
        }
        

    }
}

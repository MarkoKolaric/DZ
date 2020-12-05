using System;
using System.Globalization;

namespace ClassLibrary
{
    public class Episode
    { 
        int viewers;
        public double SumScore;
        public double MaxScore;
        public Description description { get; }
        public void AddView(double score)
        {
            SumScore += score;
            if (score > MaxScore) MaxScore = score;
        }
        public  double GetAverageScore()
        {
            double Average;
            Average = SumScore / viewers;
            return Average;
        }
        public int GetViewerCount()
        {
            return viewers;
        }
        public double GetMaxScore()
        {
            return MaxScore;
        }
        public static int  TotalViewers(Episode[] episodes)
        {
            int totalv = 0;
            int i = 0;
            foreach (Episode episode in episodes)
            {
                totalv += episodes[i].GetViewerCount();
                i++;
            }
            return totalv;
        }
        public static TimeSpan TotalDuration(Episode[] episodes)
        {
            TimeSpan totald = TimeSpan.Zero;
            int i = 0;
            foreach (Episode episode in episodes)
            {
                totald += episodes[i].description.GetTimeSpan();
                i++;
            }
            return totald;
        }
        
        public Episode(int viewers, double SumScore, double MaxScore, Description description)
        {
            this.SumScore = SumScore;
            this.viewers = viewers;
            this.MaxScore = MaxScore;
            this.description = description;
        }
        public Episode()
        {
            this.SumScore = 0.0;
            this.viewers = 0;
            this.MaxScore = 0.0;
            this.description = null;
        }
        public void SetViewers(int viewers)
        {
            this.viewers = viewers;
        }
        
        
        public override string ToString ()
        {
            return $"{viewers},{SumScore},{MaxScore},{description}";
        }
    }
    
}

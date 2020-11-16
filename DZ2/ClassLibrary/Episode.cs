using System;
using System.Globalization;

namespace ClassLibrary
{
    public class Episode
    { 
        int viewers;
        double SumScore;
        double MaxScore;
        Description description;
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
        public double GenerateRandomScore()
        {
            Random random = new Random();
            return random.NextDouble() * (10.00);
        }
        
        public override string ToString ()
        {
            return $"{viewers},{SumScore},{MaxScore},{description}";
        }
    }
    
}

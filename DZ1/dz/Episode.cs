using System;
namespace dz
{
    class Episode
    {
        int viewers;
        double SumScore;
        double MaxScore;
        public void AddView(double score)
        {
            SumScore += score;
            if (score > MaxScore) MaxScore = score;
        }
        public double GetAverageScore()
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
        public Episode(int viewers, double AverageScore, double MaxScore)
        {
            this.SumScore = AverageScore;
            this.viewers = viewers;
            this.MaxScore = MaxScore;
        }
        public Episode()
        {

        }
        public void SetViewers(int viewers)
        {
            this.viewers = viewers;
        }
    }
}

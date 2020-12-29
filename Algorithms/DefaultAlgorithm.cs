using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YTR.Objects;

namespace YTR
{
    public class DefaultAlgorithm
    {
        public string Calculate(KeywordQuickSearch C, IDifficulty D)
        {

            int bad = 0;
            int good = 0;
            string overall = "EASY/MEDIUM/HARD";

            foreach (var v in C.Details.Videos)
            {
                if (v.ViewCount > D.AvgViewCount)
                    bad += 10;
                else good += 10;

                if (DateTime.Now.Year - v.UploadedDate.Year > 1)
                    bad += 5;
                else good += 5;

                if (v.Likes > D.AvgLikes)
                    bad += 3;
                else good += 3;

                if (v.Dislikes > D.AvgDislikes)
                    good += 3;
                else bad += 3;

                if (v.VideoDuration.TotalMinutes > 5)
                    bad += 3;
                else good += 3;
            }

            double T = (double)((double)good / (double)bad);
            if (T <= 0.5)
                overall = "HARD";
            else if (T > 0.5 && T <= 1.5)
                overall = "MEDIUM";
            else
                overall = "EASY";

            return overall;
        }
    }
}

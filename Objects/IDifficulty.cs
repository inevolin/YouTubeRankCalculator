using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YTR.Objects
{
    public interface IDifficulty
    {
        int AvgViewCount { get; }
        int AvgLikes { get; }
        int AvgDislikes { get; }
    }

    public class Easy : IDifficulty
    {
        public int AvgViewCount { get { return 10000; } }
        public int AvgLikes { get { return 500; } }
        public int AvgDislikes { get { return 500; } }
    }

    public class Medium : IDifficulty
    {
        public int AvgViewCount { get { return 50000; } }
        public int AvgLikes { get { return 5000; } }
        public int AvgDislikes { get { return 5000; } }
    }

    public class Hard : IDifficulty
    {
        public int AvgViewCount { get { return 200000; } }
        public int AvgLikes { get { return 15000; } }
        public int AvgDislikes { get { return 15000; } }
    }
}

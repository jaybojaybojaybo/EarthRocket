using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EarthRocket.Models
{
    public class Coordinate
    {
        private int DegreeLat;
        private int MinuteLat;
        private int DegreeLon;
        private int MinuteLon;

        public Coordinate(int dLat, int mLat, int dLon, int mLon)
        {
            this.DegreeLat = dLat;
            this.MinuteLat = mLat;
            this.DegreeLon = dLon;
            this.MinuteLon = mLon;
        }

        public static int GetDistance(Coordinate a, Coordinate b)
        {
            float aLatDegrees = a.DegreeLat + a.MinuteLat / 60f;
            float aLonDegrees = a.DegreeLon + a.MinuteLon / 60f;

            float bLatDegrees = b.DegreeLat + b.MinuteLat / 60f;
            float bLonDegrees = b.DegreeLon + b.MinuteLon / 60f;

            float distLat = aLatDegrees - bLatDegrees;
            float distLon = aLonDegrees - bLonDegrees;

            float distDegrees = (float)Math.Sqrt(distLat * distLat + distLon * distLon);

            return (int)Math.Round(distDegrees * 60);
        }
    }
}

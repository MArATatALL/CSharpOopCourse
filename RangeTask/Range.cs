namespace Range
{
    internal class Range
    {
        public double[] Interval1 { get; set; }

        public double[] Interval2 { get; set; }

        public Range(double[] interval1, double[] interval2)
        {
            Interval1 = interval1;
            Interval2 = interval2;
        }

        public double[] GetIntervalIntersection(double[] interval1, double[] interval2)
        {
            double[] intervalIntersection = new double[2];

            if (interval1[1] <= interval2[0] || interval2[1] <= interval1[0])
            {
                return new double[1];
            }

            if (interval1[0] <= interval2[0])
            {
                intervalIntersection[0] = interval2[0];
            }
            else
            {
                intervalIntersection[0] = interval1[0];
            }

            if (interval1[1] >= interval2[1])
            {
                intervalIntersection[1] = interval2[1];
            }
            else
            {
                intervalIntersection[1] = interval1[1];
            }

            return intervalIntersection;
        }

        public double[] GetIntervalUnion(double[] interval1, double[] interval2)
        {
            if (interval1[1] <= interval2[0] || interval2[1] <= interval1[0])
            {
                return new double[4] { interval1[0], interval1[1], interval2[0], interval2[1] };
            }

            double[] intervalUnion = new double[2];

            if (interval1[0] <= interval2[0])
            {
                intervalUnion[0] = interval1[0];
            }
            else
            {
                intervalUnion[0] = interval2[0];
            }

            if (interval1[1] >= interval2[1])
            {
                intervalUnion[1] = interval1[1];
            }
            else
            {
                intervalUnion[1] = interval2[1];
            }

            return intervalUnion;
        }

        public double[] GetIntervalDifference(double[] interval1, double[] interval2)
        {
            if (interval1[1] <= interval2[0] || interval2[1] <= interval1[0])
            {
                return new double[2] { interval1[0], interval1[1] };
            }

            if (interval1[0] >= interval2[0] && interval1[1] <= interval2[1])
            {
                return new double[1];
            }

            if (interval1[0] >= interval2[0] && interval1[1] > interval2[1])
            {
                return new double[2] { interval2[1], interval1[1] };
            }

            if (interval1[0] < interval2[0] && interval1[1] <= interval2[1])
            {
                return new double[2] { interval1[0], interval2[0] };
            }

            double[] intervalDifference = new double[4];

            if (interval1[0] < interval2[0] && interval1[1] > interval2[1])
            {
                intervalDifference[0] = interval1[0];
                intervalDifference[1] = interval2[0];
                intervalDifference[2] = interval2[1];
                intervalDifference[3] = interval1[1];
            }

            return intervalDifference;
        }
    }
}
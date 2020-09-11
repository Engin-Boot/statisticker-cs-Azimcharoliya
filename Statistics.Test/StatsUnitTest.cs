using System;
using Xunit;
using Statistics;

namespace Statistics.Test
{
    public class StatsUnitTest
    {
        [Fact]
        public void ReportsAverageMinMaxForFloatValues()
        {
            var statsComputer = new StatsComputer<float>();
            var computedStats = statsComputer.CalculateStatistics(
                new List<float>{1.5F, 8.9F, 3.2F, 4.5F});
            float epsilon = 0.001F;
            Assert.True(Math.Abs(computedStats.average - 4.525) <= epsilon);
            Assert.True(Math.Abs(computedStats.max - 8.9) <= epsilon);
            Assert.True(Math.Abs(computedStats.min - 1.5) <= epsilon);
        }
        
        [Fact]
        public void ReportsAverageMinMaxForDoubleValues()
        {
            var statsComputer = new StatsComputer<double>();
            var computedStats = statsComputer.CalculateStatistics(
                new List<double>{1.5, 8.9, 3.2, 4.5});
            float epsilon = 0.001F;
            Assert.True(Math.Abs(computedStats.average - 4.525) <= epsilon);
            Assert.True(Math.Abs(computedStats.max - 8.9) <= epsilon);
            Assert.True(Math.Abs(computedStats.min - 1.5) <= epsilon);
        }
        
        [Fact]
        public void ReportsAverageMinMaxForIntegerValues()
        {
            var statsComputer = new StatsComputer<int>();
            var computedStats = statsComputer.CalculateStatistics(
                new List<int>{1, 2, 3, 4, 5});
            float epsilon = 0.001F;
            Assert.True(Math.Abs(computedStats.average - 3) <= epsilon);
            Assert.True(Math.Abs(computedStats.max - 5) <= epsilon);
            Assert.True(Math.Abs(computedStats.min - 1) <= epsilon);
        }
        
        [Fact]
        public void ReportsNaNForEmptyInput()
        {
            var statsComputer = new StatsComputer<double>();
            var computedStats = statsComputer.CalculateStatistics(
                new List<double>{});
            Assert.True(Double.IsNaN(computedStats.average));
            Assert.True(Double.IsNaN(computedStats.max - 8.9));
            Assert.True(Double.IsNaN(computedStats.min - 1.5));    
            //All fields of computedStats (average, max, min) must be
            //Double.NaN (not-a-number), as described in
            //https://docs.microsoft.com/en-us/dotnet/api/system.double.nan?view=netcore-3.1
        }
    }
}

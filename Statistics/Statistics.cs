using System;
using System.Collections.Generic;

namespace Statistics
{
    
    public struct Stats
    {
        public double average, min, max;
    }

    class StatsComputer
    {
        public Stats CalculateStatistics(List<double> values)
        {
            //Implement statistics here
            Stats computedValues;

            if (values.Count == 0)
            {
                computedValues.average = Double.NaN;
                computedValues.min = Double.NaN;
                computedValues.max = Double.NaN;
                return computedValues;
            }
            
            computedValues.min = calculateMin(values);
            computedValues.max = calculateMax(values);
            computedValues.average = calculateAverage(values);
            return computedValues;
        }

        double calculateAverage(List<double> values)
        {
            double sum = 0;
            for(int i = 0; i<values.Count;i++)
            {
                sum = sum + values[i];
            }
            sum /= values.Count;
            return sum;
        }

        double calculateMin(List<double> values)
        {
            double min = values[0];
            for(int i = 1; i<values.Count;i++)
            {
                if(min > values[i])
                    min = values[i];
            }

            return min;
        }

        double calculateMax(List<double> values)
        {
            double max = values[0];
            for (int i = 1; i < values.Count; i++)
            {
                if (max < values[i])
                    max = values[i];
            }

            return max;
        }
    }
}

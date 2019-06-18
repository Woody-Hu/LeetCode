using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Generate_Random_Point_in_a_Circle
    {
        private readonly double _radius;

        private readonly double _xCenter;

        private readonly double _yCenter;

        private readonly Random _random;

        public Generate_Random_Point_in_a_Circle(double radius, double x_center, double y_center)
        {
            _radius = radius;
            _xCenter = x_center;
            _yCenter = y_center;
            _random = new Random();
        }

        public double[] RandPoint()
        {
            var res = new double[2];
            var xDegree = _random.NextDouble();
            var yDegree = _random.NextDouble();
            while (xDegree*xDegree + yDegree*yDegree > 1)
            {
                xDegree = _random.NextDouble();
                yDegree = _random.NextDouble();
            }

            var xSignal = _random.Next(2) == 1 ? 1 : -1;
            var ySignal = _random.Next(2) == 1 ? 1 : -1;
            res[0] = _xCenter + xSignal * _radius * xDegree;
            res[1] = _yCenter + ySignal * _radius * yDegree;
            return res;
        }
    }
}

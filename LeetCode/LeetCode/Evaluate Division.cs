using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Evaluate_Division
    {
        public double[] CalcEquation(string[,] equations, double[] values, string[,] queries)
        {
            var nodes = new Dictionary<string, Dictionary<string, double>>();
            for (int i = 0; i < equations.GetLength(0); i++)
            {
                string e0 = equations[i, 0];
                string e1 = equations[i, 1];
                if (!nodes.ContainsKey(e0)) nodes[e0] = new Dictionary<string, double>();
                if (!nodes.ContainsKey(e1)) nodes[e1] = new Dictionary<string, double>();
                nodes[e0][e1] = values[i];
                nodes[e1][e0] = 1.0 / values[i];
            }

            double[] res = new double[queries.GetLength(0)];
            for (int i = 0; i < queries.GetLength(0); i++)
            {
                var value = Solve(queries[i, 0], queries[i, 1], nodes);
                res[i] = value ?? -1.0;
            }

            return res;
        }

        public double? Solve(string e0, string e1, Dictionary<string, Dictionary<string, double>> allNodes)
        {
            double? value = null;
            if (!allNodes.ContainsKey(e0) || !allNodes.ContainsKey(e1))
                return value;
            if (e0 == e1)
            {
                value = 1.0;
                return value;
            }

            var e0Nodes = allNodes[e0];
            allNodes.Remove(e0);
            foreach (string n in e0Nodes.Keys)
            {
                value = Solve(n, e1, allNodes);
                if (value != null)
                {
                    value *= e0Nodes[n];
                    break;
                }
            }

            allNodes[e0] = e0Nodes;
            return value;
        }
    }
}

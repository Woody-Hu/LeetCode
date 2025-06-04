using System;
using System.Collections.Generic;

namespace LeetCode;

public class maximize_amount_after_two_days_of_conversions
{
    public double MaxAmount(string initialCurrency, IList<IList<string>> pairs1, double[] rates1, IList<IList<string>> pairs2, double[] rates2) {
        IDictionary<string, IDictionary<string, double>> graph1 = GenerateGraph(pairs1, rates1);
        IDictionary<string, IDictionary<string, double>> graph2 = GenerateGraph(pairs2, rates2);
        IDictionary<string, double> ratesFromInitialCurrency1 = CalculateRatesFromInitialCurrency(initialCurrency, graph1);
        IDictionary<string, double> ratesFromInitialCurrency2 = CalculateRatesFromInitialCurrency(initialCurrency, graph2);
        double maximumAmount = 1.0;
        ICollection<string> currencies = ratesFromInitialCurrency1.Keys;
        foreach (string currency in currencies) {
            if (!ratesFromInitialCurrency2.ContainsKey(currency)) {
                continue;
            }
            double amount = ratesFromInitialCurrency1[currency] / ratesFromInitialCurrency2[currency];
            maximumAmount = Math.Max(maximumAmount, amount);
        }
        return maximumAmount;
    }

    public IDictionary<string, IDictionary<string, double>> GenerateGraph(IList<IList<string>> pairs, double[] rates) {
        IDictionary<string, IDictionary<string, double>> graph = new Dictionary<string, IDictionary<string, double>>();
        int length = rates.Length;
        for (int i = 0; i < length; i++) {
            IList<string> pair = pairs[i];
            string currency0 = pair[0], currency1 = pair[1];
            double rate = rates[i];
            graph.TryAdd(currency0, new Dictionary<string, double>());
            graph[currency0].Add(currency1, rate);
            graph.TryAdd(currency1, new Dictionary<string, double>());
            graph[currency1].Add(currency0, 1 / rate);
        }
        return graph;
    }

    public IDictionary<string, double> CalculateRatesFromInitialCurrency(string initialCurrency, IDictionary<string, IDictionary<string, double>> graph) {
        IDictionary<string, double> ratesFromInitialCurrency = new Dictionary<string, double>();
        ratesFromInitialCurrency.Add(initialCurrency, 1.0);
        Queue<string> currencyQueue = new Queue<string>();
        Queue<double> rateQueue = new Queue<double>();
        currencyQueue.Enqueue(initialCurrency);
        rateQueue.Enqueue(1.0);
        while (currencyQueue.Count > 0) {
            string currency = currencyQueue.Dequeue();
            double rate = rateQueue.Dequeue();
            IDictionary<string, double> adjacent = graph.ContainsKey(currency) ? graph[currency] : new Dictionary<string, double>();
            foreach (KeyValuePair<string, double> pair in adjacent) {
                string nextCurrency = pair.Key;
                double nextRate = rate * pair.Value;
                if (!ratesFromInitialCurrency.ContainsKey(nextCurrency)) {
                    ratesFromInitialCurrency.Add(nextCurrency, nextRate);
                    currencyQueue.Enqueue(nextCurrency);
                    rateQueue.Enqueue(nextRate);
                }
            }
        }
        return ratesFromInitialCurrency;
    }
}
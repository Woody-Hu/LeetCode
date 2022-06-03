using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class all_paths_from_source_to_target
	{
		public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
		{
			var res = new List<IList<int>>();
			var path = new List<int>() { 0 };
			Visit(graph, 0, res, path);
			return res;
		}

		private void Visit(int[][] graph, int index, IList<IList<int>> res, IList<int> path)
		{
            if (index == graph.Length - 1)
            {
				res.Add(new List<int>(path));
				return;
			}

            foreach (var item in graph[index])
            {
				path.Add(item);
				Visit(graph, item, res, path);
				path.RemoveAt(path.Count - 1);
            }
		}
	}
}


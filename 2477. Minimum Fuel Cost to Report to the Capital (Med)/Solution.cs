public class Solution
{
    private long minFuel;
    private long seats;
    private Dictionary<int, List<int>> adj;
    public long MinimumFuelCost(int[][] roads, int seats)
    {
        if (roads.Length == 0) return 0;
        this.minFuel = 0;
        this.seats = seats;
        this.adj = new();

        foreach (var road in roads)
        {
            if (!adj.ContainsKey(road[0])) adj.Add(road[0], new());
            if (!adj.ContainsKey(road[1])) adj.Add(road[1], new());
            adj[road[0]].Add(road[1]);
            adj[road[1]].Add(road[0]);
        }

        CheckPath(-1, 0);

        return minFuel;
    }

    private int CheckPath(int parent, int node)
    {
        int representatives = 1;
        foreach (var child in adj[node])
        {
            if (child == parent) continue;
            representatives += CheckPath(node, child);
        }

        if (node != 0) minFuel += (long) Math.Ceiling((double)representatives / seats);
        return representatives;
    }
}
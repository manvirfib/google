using System;
using System.Collections.Generic;

class DikstraApproach {
    int GetMin(int[] distance, bool[] visited){
        int len = distance.Length;
        int min = int.MaxValue;
        int index = -1;
        for(int i = 0; i < len; i++){
            if(!visited[i] && distance[i] < min){
                min = distance[i];
                index = i;
            }
        }
        
        return index;
    }
    public int[] dijkstra(int V, int[,] edges, int src) {
        int[] distance = new int[V];
        Array.Fill(distance, int.MaxValue);
        distance[src] = 0;
        bool[] visited = new bool[V];
        
        List<int[]>[] adj = new List<int[]>[V];
        for (int i = 0; i < V; i++) adj[i] = new List<int[]>();

        int len = edges.GetLength(0);
        
        for (int i = 0; i < len; i++) {
            adj[edges[i, 0]].Add(new int[] { edges[i, 1], edges[i, 2] });
            adj[edges[i, 1]].Add(new int[] { edges[i, 0], edges[i, 2] }); // undirected
        }
        
        int length = 0;
        
        while(length <= V){
            int val = GetMin(distance, visited);
            if(val == -1) break;
            visited[val] = true;
            var list = adj[val];
            for(int i = 0; i < list.Count; i++){
                if((distance[val] + list[i][1]) < distance[list[i][0]]){
                    distance[list[i][0]] = distance[val] + list[i][1];
                }
            }
            length++;
        }
        
        return distance;
    }
}

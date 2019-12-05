/*
This is an implementation of the adjacency list for a graph

The adjacency list is an array of LinkedList<>, where each element is a Tuple<>. Each Tuple stores two values, the destination
vertex and the weight of the edge

*/

using System;
using System.Collections.Generic;

namespace graph_implementaiton
{
    class AdjacencyList
    {
        LinkedList<Tuple<int, int>>[] adjacencyList;
        // This is the constructor methods, which creates an empty Adjacency List
        public AdjacencyList(int vertices)
        {
            adjacencyList = new LinkedList<Tuple<int, int>>[vertices];
            for(int i = 0; i < adjacencyList.Length; i++)
            {
                adjacencyList[i] = new LinkedList<Tuple<int, int>>();
            }
        }

        // this method appends a new edge to the linked list
        public void addEdgeAtEnd(int startVertex, int endVertex, int weight)
        {
            adjacencyList[startVertex].AddLast(new Tuple<int, int>(endVertex, weight));
        }
        // this method adds a new edge to the linked list from teh front
        public void addEdgeAtBegin(int startVertex, int endVertex, int weight)
        {
            adjacencyList[startVertex].AddFirst(new Tuple<int, int>(endVertex, weight));
        }
        // returns the number of vertices in the graph
        public int getNumberOfVertices()
        {
            return adjacencyList.Length;
        }
        // prints the adjacenty list
        public void printAdjacencyList()
        {
            int i = 0;
            foreach (LinkedList<Tuple<int, int>> list in adjacencyList)
            {
                Console.WriteLine("adjacencyList[" + i + "] --> ");
                foreach (Tuple<int, int> edge in list)
                {
                    Console.Write(edge.Item1 + "(" + edge.Item2 + ")");
                }
                i++;
                Console.WriteLine();
            }
        }
        // this method removes the first occurance of an edge and returns true if there was any removal, else returns false
        public Boolean removeEdge(int startVertex, int endVertex, int weight)
        {
            Tuple<int, int> edge = new Tuple<int, int>(endVertex, weight);
            return adjacencyList[startVertex].Remove(edge);
        }
    }
}
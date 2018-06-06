using System;
using System.Collections;

namespace Graphs
{
    public class Node
    {

        private ArrayList neighbours;
        private object val;

        public object Name
        {
            get { return val; }
            set { val = value; }
        }

        public ArrayList Neighbours
        {
            get
            {
                return this.neighbours;
            }
        }

        public Node(string val)
        {
            neighbours = new ArrayList();
            this.val = val;
        }
       
        //DEPTH
        public Node GetNextUnvisited(Node[] visited)
        {
            if (this.neighbours.Count == 0)
            {
                return null;
            }
            else
            {
                for(int a = 0; a < this.neighbours.Count; a++)
                {
                    bool Contained = false;
                    for (int b = 0; b < visited.Length; b++)
                    {
                        if(this.neighbours[a] == visited[b])
                        {
                            Contained = true;
                        }
                    }
                    if(Contained == false)
                    {
                        return (Node)this.neighbours[a];
                    }
                }
                return null;
            }          
        }

        //BREADTH
        public ArrayList GetUnvisitedNeighbours(Node[] visited)
        {
            ArrayList unvisitedNeighbours = new ArrayList();
            for (int a = 0; a < this.neighbours.Count; a++)
            {
                bool Contained = false;
                for (int b = 0; b < visited.Length; b++)
                {
                    if (this.neighbours[a] == visited[b])
                    {
                        Contained = true;
                    }
                }
                if (Contained == false)
                {
                    unvisitedNeighbours.Add(this.neighbours[a]);
                }
            }
            if(unvisitedNeighbours.Count > 0)
            {
                return unvisitedNeighbours;
            }
            else
            {
                return null;
            }
   
        }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Collections;

namespace GraphApplication
{
    public partial class Form1 : Form
    {
        
        Graphs.Node nodeA;
        Graphs.Node nodeB;
        Graphs.Node nodeC;
        Graphs.Node nodeD;
        Graphs.Node nodeE;
        Graphs.Node nodeF;
        Graphs.Node nodeG;
        Graphs.Node nodeH;
        Graphs.Node nodeI;
        Graphs.Node nodeX;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            nodeA = new Graphs.Node("A");
            nodeB = new Graphs.Node("B");
            nodeC = new Graphs.Node("C");
            nodeD = new Graphs.Node("D");
            nodeE = new Graphs.Node("E");
            nodeF = new Graphs.Node("F");
            nodeG = new Graphs.Node("G");
            nodeH = new Graphs.Node("H");
            nodeI = new Graphs.Node("I");
            nodeX = new Graphs.Node("X");

            nodeA.Neighbours.Add(nodeB);
            nodeA.Neighbours.Add(nodeC);

            nodeB.Neighbours.Add(nodeA);
            nodeB.Neighbours.Add(nodeD);
            nodeB.Neighbours.Add(nodeE);

            nodeC.Neighbours.Add(nodeA);
            nodeC.Neighbours.Add(nodeF);
            nodeC.Neighbours.Add(nodeG);

            nodeD.Neighbours.Add(nodeB);
            nodeD.Neighbours.Add(nodeE);

            nodeE.Neighbours.Add(nodeB);
            nodeE.Neighbours.Add(nodeD);

            nodeF.Neighbours.Add(nodeC);
            nodeF.Neighbours.Add(nodeG);

            nodeG.Neighbours.Add(nodeC);
            nodeG.Neighbours.Add(nodeF);
            nodeG.Neighbours.Add(nodeH);
            nodeG.Neighbours.Add(nodeI);

            nodeH.Neighbours.Add(nodeG);
            nodeH.Neighbours.Add(nodeI);

            nodeI.Neighbours.Add(nodeG);
            nodeI.Neighbours.Add(nodeH);
            nodeI.Neighbours.Add(nodeX);

            nodeX.Neighbours.Add(nodeI);
            
        }

        private void depthBtn_Click(object sender, EventArgs e)
        {

            ArrayList allVisitedNodes = new ArrayList();

            Stack<Graphs.Node> nodeStack = new Stack<Graphs.Node>();

            bool end = false;

            Graphs.Node currentNode = nodeA;

            allVisitedNodes.Add(currentNode);

            while (!end)
            {

                Graphs.Node nextNode = currentNode.GetNextUnvisited((Graphs.Node[])allVisitedNodes.ToArray(typeof(Graphs.Node)));

                if(nextNode != null)
                {
                    nodeStack.Push(currentNode);
                    currentNode = nextNode;
                    allVisitedNodes.Add(currentNode);
                }
                else
                {
                    if(currentNode == nodeA)
                    {
                        end = true;
                    }
                    else
                    {
                        currentNode = nodeStack.Pop();
                    }
                }
            }

            foreach(Graphs.Node node in allVisitedNodes)
            {
                nodeBox.Text += node.Name;
            }
        }

        private void breadthBtn_Click(object sender, EventArgs e)
        {
            ArrayList allVisitedNodes = new ArrayList();
            Queue<Graphs.Node> nodeQueue = new Queue<Graphs.Node>();

            bool end = false;
            Graphs.Node currentNode = nodeA;

            allVisitedNodes.Add(currentNode);

            while (!end)
            {

                ArrayList unvisitedNodes = new ArrayList();

                unvisitedNodes.AddRange(currentNode.GetUnvisitedNeighbours((Graphs.Node[])allVisitedNodes.ToArray(typeof(Graphs.Node))));

                foreach (Graphs.Node node in unvisitedNodes)
                {
                    nodeQueue.Enqueue(node);
                }

                if(nodeQueue.Count > 0)
                {
                    allVisitedNodes.Add(currentNode);
                    currentNode = nodeQueue.Dequeue();
                }
                else
                {
                    end = true;
                }
            
            }

            foreach (Graphs.Node node in allVisitedNodes)
            {
                nodeBox.Text += node.Name;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

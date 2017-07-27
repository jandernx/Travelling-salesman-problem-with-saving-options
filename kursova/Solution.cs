using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursova
{
    class Solution
    {
        private List<int> parents = new List<int>();
        private List<int> children = new List<int>();
        private int number;
        private int currencyWeight;

        public static int[,] adjMatrix = new int[10, 10];
        public static int n = 5;
        public static List<int> minimalCycle = new List<int>();
        public static int minimalWeight = -1;

        public Solution(List<int> parents, int number, int weight)
        {
            //this.parents = parents;
            for (int i = 0; i < parents.Count; i++)
            {
                this.parents.Add(parents[i]);
            }
            this.number = number;
            this.currencyWeight = weight;
        }

        public Solution()
        {
            this.number = 0;
            this.currencyWeight = 0;
        }

        public void getChildren()
        {
            for (int i = 0; i < n; i++)
            {
                if (adjMatrix[this.number, i] != 0)
                {
                    bool parent = false;
                    for (int j = 0; j < this.parents.Count; j++)
                    {
                        if (this.parents[j] == i)
                        {
                            parent = true;
                            break;
                        }
                    }
                    if (!parent)
                    {
                        this.children.Add(i);
                    }
                }
            }
        }
        public void algorithm()
        {
            this.getChildren();
            if (this.parents.Count != 0) this.currencyWeight += adjMatrix[this.parents[this.parents.Count - 1], this.number];
            this.parents.Add(this.number);
            if (this.children.Count == 0 && this.parents.Count == n)
            {

                if (minimalWeight == -1 || minimalWeight > this.currencyWeight + adjMatrix[this.number, this.parents[0]])
                {
                    minimalCycle = this.parents;
                    minimalCycle.Add(this.parents[0]);
                    minimalWeight = this.currencyWeight + adjMatrix[this.number, this.parents[0]];
                }

            }
            for (int i = 0; i < this.children.Count; i++)
            {
                Solution solution = new Solution(this.parents, this.children[i], this.currencyWeight);
                if (minimalWeight == -1 || this.currencyWeight + adjMatrix[this.parents[this.parents.Count - 1], i] < minimalWeight)
                {
                    solution.algorithm();
                }

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Cities
    {
        private string name;
        private List<string> connections;

        public Cities(string name)
        {
            this.name = name;
            this.connections = new List<string>();
        }

        public Cities(string name, string connectedCity, int cost)
        {
            this.name = name;
            this.connections = new List<string>();
            connections.Add(connectedCity + ":" + cost);
        }

        public void Connection(string cityName, int cost)
        {
            connections.Add(cityName + ":" + cost);
        }

        public override string ToString()
        {
            if (connections.Count == 0)
            {
                return name + ": Нет связей";
            }
            string res = name + ": ";
            for (int i = 0; i < connections.Count; i++)
            {
                res += connections[i];
                if (i < connections.Count - 1)
                {
                    res += ", ";
                }
            }
            return res;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Cities
    {
        string name;
        string[] connected = new string[10];
        int[] paths = new int[10];
        int count = 0;
        public Cities(string name) 
        {
            this.name = name;
        }
        public Cities(string name, string[] connect, int[] pathCities)
        {
            this.name = name;

            if (connect != null && pathCities != null && connect.Length == pathCities.Length)
            {
                for (int i = 0; i < connect.Length && count < connected.Length; i++)
                {
                    connected[count] = connect[i];
                    paths[count] = pathCities[i];
                    count++;
                }
            }
        }

        public void Connection(string nameConnect, int path)
        {
            if (count < connected.Length)
            {
                connected[count] = nameConnect;
                paths[count] = path;
                count++;
            }
        }

        public override string ToString()
        {
            string res = "";
            if (count == 0)
            {
                return name + "Нет связи";
            }
            for (int i = 0; i < count; i++)
            {
                res += name + "->" + connected[i] + ": " + paths[i];
                if (i < count - 1)
                    res += ", ";
            }
            return res;
        }



    }
}

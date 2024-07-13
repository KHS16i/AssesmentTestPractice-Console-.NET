using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProyect.Tests
{
    public class TestCarlosAsaustre
    {
        #region HELLO NAME

        public string helloWorld(string name)
        {
            return "Hello " + name;
        }

        #endregion

        #region CUIDADES REPETIDAS ORDENADAS

        public List<string> sortCities(List<string> cities)
        {
            List<string> res = new List<string>();

            string aux = "";
            int n = 0;

            Dictionary<string, int> sort = new Dictionary<string, int>();

            for (int i = 0; i < cities.Count; i++)
            {
                aux = cities[i];
                for (int j = 0; j < cities.Count; j++)
                {
                    if (cities[j] == aux)
                    {
                        n++;
                    }
                }
                if (!(sort.ContainsKey(aux)))
                {
                    sort.Add(aux, n);
                }
                n = 0;
            }

            var SortedDic = sort.OrderByDescending(x => x.Value);

            res = SortedDic.Select(x => x.Key).ToList();

            return res;
        }

        #endregion
    }
}

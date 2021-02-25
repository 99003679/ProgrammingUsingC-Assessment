using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public class GourmetCoffeeShop : GourmetShop, ITaxCompute
    {
        private int Gprod_id;
        private string Gprod_name;
        private Dictionary<int, double> coffeePriceDict;

        public GourmetCoffeeShop(int c_id, string c_name, Dictionary<int, double> coffeePriceDict)
        {
            this.Gprod_id = c_id;
            this.Gprod_name = c_name;
            this.coffeePriceDict = coffeePriceDict;
        }
    }
}

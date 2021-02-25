using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public class GourmetOrganicShop : GourmetShop,ITaxCompute
    {
        public int Oprod_id;
        public string Oprod_name;
        private Dictionary<int, double> organicPriceDict;

        public GourmetOrganicShop(int , string, )
        {

        }

        public GourmetOrganicShop(int Gid, string Gname, Dictionary<int, double> organicPriceDict)
        {
            this.Oprod_id = Gid;
            this.Oprod_name = Gname;
            this.organicPriceDict = organicPriceDict;
        }

        public int ItemName { get; set; }
    }
    
}

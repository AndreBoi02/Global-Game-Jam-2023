using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets
{
    internal interface IVendible
    {
        public float[] CostBuy { get; set; }
        public float[] CostSale { get; set; }
    }
}

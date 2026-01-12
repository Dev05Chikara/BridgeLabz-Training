using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.metal_factory_pipe_cutting
{
    internal class PriceChart
    {
        private Dictionary<int, int> PriceList = new Dictionary<int, int>();

        
        // Add Prices woth correspond to length
        
        public void AddPrice(int length, int price)
        {
            PriceList[length] = price;
        }

        // get price of each pices
        public int GetPrice(int length)
        {
            return PriceList.ContainsKey(length)?PriceList[length]:0;
        }

        // get all Prices
        public Dictionary<int, int> GetAll()
        {
            return PriceList;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.custom_furniture_manufacturing
{
    internal class PriceChart
    {
        private Dictionary<int, int> PriceList = new Dictionary<int, int>();
    
    
        // Add Prices with correspond to length
    
        public void AddPrice(int length, int price)
        {
            PriceList[length] = price;
        }
    
        // get price of each pieces
        public int GetPrice(int length)
        {
            return PriceList.ContainsKey(length) ? PriceList[length] : 0;
        }
    
        // get all Prices
        public Dictionary<int, int> GetAll()
        {
            return PriceList;
        }
    }
}

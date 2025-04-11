using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    internal class Item
    {
        public string Name { get; set; }
        public decimal startingPrice { get; set; }
        public decimal currentPrice { get; set; }
        public int BidCount { get; set; }
        public Bidder HighestBidder { get; set; }

        public double StartingPrice { get; set; }

        public Item( string name,  decimal StartingPrice)
        {
            Name = name;
            startingPrice = StartingPrice;
            currentPrice = StartingPrice;
            BidCount = 0;
            HighestBidder = null;
        }
    }
}

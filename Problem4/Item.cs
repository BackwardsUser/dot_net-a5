using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{/// <summary>
/// the item that is being auctioned
/// </summary>
    public class Item
    {
        /// <summary>
        /// name  of item
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// starting price of item
        /// </summary>
        public decimal startingPrice { get; set; }
        /// <summary>
        /// current price in auction
        /// </summary>
        public decimal currentPrice { get; set; }
        /// <summary>
        /// how  many bid have happened on the item
        /// </summary>
        public int BidCount { get; set; }
        /// <summary>
        /// Bidder object of highest bidder of the item
        /// </summary>
        public Bidder HighestBidder { get; set; }
        /// <summary>
        /// starting price for the item
        /// </summary>
        public double StartingPrice { get; set; }

        /// <summary>
        /// create the item to be auction
        /// </summary>
        /// <param name="name">name of item</param>
        /// <param name="StartingPrice">starting price of item</param>
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

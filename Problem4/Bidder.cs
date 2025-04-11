using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    /// <summary>
    /// bidder class that inherits from Auction Observer
    /// </summary>
    public class Bidder : AuctionObserver
    {
        /// <summary>
        /// create a budder
        /// </summary>
        /// <param name="name"> name of bidder </param>
        /// <param name="maxSpending"> spending limit for bidder </param>
        public Bidder(string name, decimal maxSpending) : base(name, maxSpending) { }
        
        /// <summary>
        /// sends message to user
        /// </summary>
        /// <param name="message"> message content</param>
        public override void Update( string message)
        {
            Console.WriteLine("Notification for "+Name +": "+ message);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    /// <summary>
    /// Abstract class of bidder/ auction observer
    /// </summary>
    public abstract class AuctionObserver
    {
        public string Name { get; }
        public decimal maxSpending { get; set; }
        /// <summary>
        /// creates a auction observer
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="maxSpending">spending limit</param>
        protected AuctionObserver(string name, decimal maxSpending)
        {
            Name = name;
            this.maxSpending = maxSpending;
        }
        /// <summary>
        /// send message to user
        /// </summary>
        /// <param name="message"> send message to user </param>
        public abstract void Update( string message);

        

    }
}

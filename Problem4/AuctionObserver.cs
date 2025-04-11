using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    public abstract class AuctionObserver
    {
        public string Name { get; }
        public decimal maxSpending { get; set; }

        protected AuctionObserver(string name, decimal maxSpending)
        {
            Name = name;
            this.maxSpending = maxSpending;
        }

        public abstract void Update( string message);

        

    }
}

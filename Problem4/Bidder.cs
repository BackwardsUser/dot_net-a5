using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    public class Bidder : AuctionObserver
    {

        public Bidder(string name, decimal maxSpending) : base(name, maxSpending) { }
        

        public override void Update( string message)
        {
            Console.WriteLine("Notification for "+Name +": "+ message);
        }

    }
}

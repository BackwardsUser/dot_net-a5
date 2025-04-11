namespace Problem4
{
    /// <summary>
    /// Auctioneer class
    /// </summary>
    internal class Auctioneer
    {

        private List<AuctionObserver> bidders = new List<AuctionObserver>();
        private Item currentItem;
        /// <summary>
        /// create the aution with a empty list of observers
        /// </summary>
        public Auctioneer() 
        { 
            bidders = new List<AuctionObserver> ();
        }
        /// <summary>
        /// registor a new bidder in the auction
        /// </summary>
        /// <param name="bidder"> object to be added to auctionobsever list </param>
        public void registorBidder(AuctionObserver bidder) 
        {
            bidders.Add(bidder);
        }

        /// <summary>
        /// unregistor bidder from the auction
        /// </summary>
        /// <param name="bidder">need the object of the bidder</param>
        public void unRegistorBidder(AuctionObserver bidder) 
        {
            bidders.Remove(bidder);
        }

        /// <summary>
        /// announces new item when they are auctioned
        /// </summary>
        /// <param name="item">item being auctioned</param>
        public void AnnounceItem(Item item)
        {
            currentItem = item;
            NotifyBidders($"New item: {currentItem.Name}, Current Price: ${currentItem.currentPrice}");
        }
        /// <summary>
        /// when a bid is recieved the auctionneer processes it here 
        /// </summary>
        /// <param name="bidder"> object of bidder</param>
        /// <param name="bid"> bit amount in decimal </param>
        public void ReveiveBid(Bidder bidder, decimal bid)
        {
            if (currentItem == null)
            {
                Console.WriteLine("No item is being auctioned currunty");
            }
            else if (bid <= currentItem.currentPrice)
            {
                Console.WriteLine(bidder.Name + " you bid is too low");
            }
            else if (bid > bidder.maxSpending)
            {
                Console.WriteLine(bidder.Name + "  you bid exceeds you max bid limit");

            }else 
            {
                currentItem.currentPrice = bid;
                currentItem.HighestBidder = bidder;
                currentItem.BidCount++;
                NotifyBidders(currentItem.Name + " current price is now "+ currentItem.BidCount);
            }

            if (currentItem.BidCount >= 5) 
            {
                NotifyBidders(currentItem.Name+" has been sold to "+currentItem.HighestBidder);
                unRegistorBidder(currentItem.HighestBidder);
                currentItem = null;
            }

        }

        /// <summary>
        /// notify all observer of the aution using the Observer pattern f
        /// </summary>
        /// <param name="message"> message content </param>
        public void NotifyBidders( string message) 
        {
            foreach (AuctionObserver observer in bidders) 
            {
                observer.Update(message);
            }
        }

    }
}

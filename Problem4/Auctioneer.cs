namespace Problem4
{
    internal class Auctioneer
    {

        private List<AuctionObserver> bidders = new List<AuctionObserver>();
        private Item currentItem;

        public Auctioneer() 
        { 
            bidders = new List<AuctionObserver> ();
        }

        public void registorBidder(AuctionObserver bidder) 
        {
            bidders.Add(bidder);
        }

        public void unRegistorBidder(AuctionObserver bidder) 
        {
            bidders.Remove(bidder);
        }

        public void AnnounceItem(Item item)
        {
            currentItem = item;
            NotifyBidders($"New item: {currentItem.Name}, Current Price: ${currentItem.currentPrice}");
        }

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


        public void NotifyBidders( string message) 
        {
            foreach (AuctionObserver observer in bidders) 
            {
                observer.Update(message);
            }
        }

    }
}

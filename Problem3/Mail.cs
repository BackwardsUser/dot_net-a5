using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    internal class Mail
    {
        public Person Sender { get; }
        public Person Reciever { get; }
        public decimal PostalCost { get; }
        public float Weight { get; }
        public bool IsFlagged { get; }

        public abstract void Process(MailboxHandler handler);
    }
}

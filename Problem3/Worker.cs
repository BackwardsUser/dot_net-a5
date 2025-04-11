using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    internal class Worker
    {
        private readonly BlockingCollection<Mail> _mailQueue;
        private readonly MailboxHandler _handler;

        public Worker(BlockingCollection<Mail> mailQueue, MailboxHandler handler)
        {
            _mailQueue = mailQueue;
            _handler = handler;
        }

        public void Work()
        {
            foreach (var mail in _mailQueue.GetConsumingEnumerable())
            {
                mail.Process(_handler);
            }
    }
}

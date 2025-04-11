using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    internal class Dispatcher
    {
        private BlockingCollection<Mail> _mailQueue = new BlockingCollection<Mail>();
        private List<Worker> _workers = new List<Worker>();
        private MailboxHandler _handler = new MailboxHandler();

        public void Start(int initialWorkerCount)
        {
            for (int i = 0; i < initialWorkerCount; i++)
            {
                var worker = new Worker(_mailQueue, _handler);
                _workers.Add(worker);
                Task.Run(() => worker.Work());
            }
        }

        public void Dispatch(Mail mail)
        {
            _mailQueue.Add(mail);
        }

        public void ScaleUp(int additionalWorker)
        {
            for (int i = 0; i < additionalWorker; i++)
            {
                var worker = new Worker(_mailQueue, _handler);
                _workers.Add(worker);
                Task.Run(() => worker.Work());
            }
        }
    }
}

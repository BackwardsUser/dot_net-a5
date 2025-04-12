using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    public class Worker
    {
        public EventHandler Running = delegate { };
        public EventHandler Completed = delegate { };

        private Mail? mail;
        private readonly IHandler handler = new FlaggedHandler(new MailHandler(new DefaultHandler()));

        public Worker() { }

        public void AssignMail(Mail _mail)
        {
            this.mail = _mail;
        }

        public void DoWork()
        {
            this.Running?.Invoke(this, EventArgs.Empty);
            Console.WriteLine("[Worker] Processing mail...");
            if (this.mail != null)
            {
                handler.HandleRequest(this.mail);
            }
            this.Completed?.Invoke(this, EventArgs.Empty);
        }
    }
}

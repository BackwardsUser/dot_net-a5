using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    public interface IHandler
    {
        void HandleRequest(object request);
        IHandler Successor { get; set; }
    }

    public abstract class Handler : IHandler
    {
        protected Handler() { }
        protected Handler(IHandler successor)
        {
            this.Successor = successor;
        }
        public abstract void HandleRequest(object request);
        public IHandler Successor { get; set; }
    }

    public class FlaggedHandler : Handler
    {
        public FlaggedHandler() { }
        public FlaggedHandler(IHandler successor) : base(successor) { }
        public override void HandleRequest(object request)
        {
            if (request is Mail mail && mail.IsFlagged)
            {
                Console.WriteLine("Mail is flagged! Placing it in the review queue.");
            }
            else
            {
                Successor.HandleRequest(request);
            }
        }
    }

    public class MailHandler : Handler
    {
        public MailHandler() { }
        public MailHandler(IHandler successor) : base(successor) { }

        public override void HandleRequest(object request)
        {
            if (request is Mail)
            {
                Console.WriteLine(request.ToString());
                Console.WriteLine("I'm Mail!");
            }
            else
            {
                this.Successor.HandleRequest(request);
            }
        }
    }

    public class DefaultHandler : Handler
    {
        public override void HandleRequest(object request)
        {
            throw new InvalidOperationException("No Handler to handle this type of request: " +  request.GetType());
        }
    }
}

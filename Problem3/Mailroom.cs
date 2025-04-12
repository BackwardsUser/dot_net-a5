using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    public class Mailroom
    {
        private static Mailroom instance;
        private Queue<Worker> availableInstances = new Queue<Worker>();
        private Queue<Worker> usedInstances = new Queue<Worker>();
        private Queue<Worker> waitingInstances = new Queue<Worker>();

        private Mailroom()
        {

        }

        public static Mailroom Instance => instance ?? (instance = new Mailroom());

        public void QueueWorkItem(Func<int, int, int> function)
        {
            if (!this.availableInstances.Any())
            {
                this.waitingInstances.Enqueue(new Worker(function));
            }
            else
            {
                var workingInstance = this.availableInstances.Dequeue();

                workingInstance.Running += (sender, args) =>
                {
                    Console.WriteLine("working is running");
                };

                this.usedInstances.Enqueue(workingInstance);

                workingInstance.Completed += (sender, args) =>
                {
                    var innerInstance = this.usedInstances.Dequeue();
                    this.availableInstances.Enqueue(innerInstance);
                };
            }
        }
    }
}

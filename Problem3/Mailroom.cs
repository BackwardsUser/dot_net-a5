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
        private Queue<Mail> waitingMail = new Queue<Mail>();

        private Mailroom()
        {

        }

        public void RegisterWorker(Worker worker)
        {
            this.availableInstances.Enqueue(worker);
        }

        public static Mailroom Instance => instance ?? (instance = new Mailroom());

        public void QueueWorkItem(Mail mail)
        {
            if (!this.availableInstances.Any())
            {
                Console.WriteLine("No available workers. Queuing mail...");
                waitingMail.Enqueue(mail);
            }
            else
            {
                var worker = availableInstances.Dequeue();
                usedInstances.Enqueue(worker);

                worker.AssignMail(mail);

                worker.Running += (sender,args) => Console.WriteLine("Worker is running");
                worker.Completed += (sender, args) =>
                {
                    Console.WriteLine("Worker completed");
                    if (!usedInstances.Any())
                    {
                        return;
                    }
                    usedInstances.Dequeue();
                    availableInstances.Enqueue(worker);

                    if (waitingMail.Any())
                    {
                        var nextMail = waitingMail.Dequeue();
                        QueueWorkItem(nextMail);
                    }
                };

                worker.DoWork();
            }
        }
    }
}

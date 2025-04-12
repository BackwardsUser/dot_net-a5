using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    internal class Worker
    {
        public EventHandler Running;
        public EventHandler Completed;

        private readonly Func<int, int, int> function;

        public Worker(Func<int, int, int> function)
        {
            this.Running?.Invoke(this, EventArgs.Empty);
            this.function = function;
        }

        public void DoWork(int value1, int value2)
        {
            this.function(value1, value2);
            Console.WriteLine("Doing Work...");

            this.Completed?.Invoke(this, EventArgs.Empty);
        }
    }
}

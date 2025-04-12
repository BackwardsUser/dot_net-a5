using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    public class Mail
    {
        public Person Sender { get; set; }
        public Person Receiver { get; set; }
        public int Cost { get; set; }
        public double Weight { get; set; }
        public string Type { get; set; } // "Mail" or "Package"
        public bool IsFlagged { get; set; }
        public override string ToString()
        {
            return $"Mail from {Sender?.Name} to {Receiver?.Name}, Cost: {Cost}, Weight: {Weight}kg, Type: {Type}, Flagged: {IsFlagged}";
        }
    }
}

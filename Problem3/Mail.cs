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
        public Person Reciever { get; set; }
        public int Cost { get; set; }
        public double weight { get; set; }
        public string Type { get; set; } // "Mail" or "Package"
        public bool Flagged { get; set; }
    }
}

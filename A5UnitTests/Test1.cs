using Problem3;

namespace A5UnitTests
{
    [TestClass]
    public sealed class Test1
    {
        //[TestMethod]
        //public void TestMethod1()
        //{
        //}

        [TestMethod]
        public void MailIsFlagged()
        {
            Mailroom.Instance.RegisterWorker(new Worker());
            var mail = new Mail
            {
                Sender = new Person { Name = "Eve", Address = "789 Spy Ave" },
                Receiver = new Person { Name = "Mallory", Address = "999 Secret Rd" },
                Cost = 15,
                Weight = 1.5,
                Type = "Package",
                IsFlagged = true
            };

            Mailroom.Instance.QueueWorkItem(mail);
        }

        [TestMethod]
        public void Mail_MoreThanWorkers()
        {
            Mailroom.Instance.RegisterWorker(new Worker());

            var mail1 = new Mail
            {
                Sender = new Person { Name = "Alex", Address = "123 Main St" },
                Receiver = new Person { Name = "Jordan", Address = "456 Elm St" },
                Cost = 10,
                Weight = 0.5,
                Type = "Mail",
                IsFlagged = false
            };
            var mail2 = new Mail
            {
                Sender = new Person { Name = "Nina", Address = "111 North Lane" },
                Receiver = new Person { Name = "Sam", Address = "222 South Blvd" },
                Cost = 7,
                Weight = 0.3,
                Type = "Package",
                IsFlagged = true
            };

            Mailroom.Instance.QueueWorkItem(mail1);
            Mailroom.Instance.QueueWorkItem(mail2); // Has no available worker, should wait to complete.
        }
    }
}

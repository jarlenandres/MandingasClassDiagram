using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagram.Core
{
    internal class Order
    {
        public int IdOrder { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Hour { get; set; }
        public decimal TotalValue { get; set; }
        public string PaymentType { get; set; }
        public int IdClient { get; set; }
        public int IdChecker { get; set; }
        public int IdState { get; set; }

        public Client Client { get; set; }
        public Checker Checker { get; set; }
        public State State { get; set; }

        public List<OrderDetails> Details { get; set; } = new();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagram.Core
{
    internal class Domicile
    {
        public int IdDomicile { get; set; }
        public int IdOrder { get; set; }
        public int IdDomicilary { get; set; }
        public string Estate { get; set; }
        public TimeSpan DeliveryTime { get; set; }

        public Order Order { get; set; }
        public Domiciliary Domiciliary { get; set; }
    }
}

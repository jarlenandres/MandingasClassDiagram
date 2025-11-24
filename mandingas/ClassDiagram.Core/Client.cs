using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagram.Core
{
    internal class Client : User
    {
        public Client()
        {
        }

        public int IdClient { get; set; }

        public override string GetAdd()
        {
            throw new NotImplementedException();
        }

        public override string GetDelete()
        {
            throw new NotImplementedException();
        }

        public override string GetUpdate()
        {
            throw new NotImplementedException();
        }
    }

}
